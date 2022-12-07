using YamlDotNet.Core;
using YamlDotNet.Serialization;

namespace DTDL2OAS
{
    internal class OASDocument
    {
        public readonly string openapi = "3.0.3";
        public Info? info;
        public Components components = new Components();

        public Dictionary<string, Path> paths = new Dictionary<string, Path>();
        public List<Dictionary<string, string>>? servers;

        public class Info
        {
            [YamlMember(ScalarStyle = ScalarStyle.DoubleQuoted)]
            public string? version;
            public string? title;
            public License? license;
            public Contact? contact;
            public string? description;
        }

        public class License
        {
            public string? name;
        }

        public class Contact
        {
            public string? name;
            public string? url;
        }

        public class Parameter
        {
            private string? _referenceTo;
            [YamlMember(Alias = "$ref")]
            public string? ReferenceTo
            {
                get
                {
                    return _referenceTo;
                }
                set
                {
                    _referenceTo = "#/components/parameters/"  + value;
                }
            }

            public enum InFieldValues
            {
                path = 1,
                query = 2,
                header = 3,
                cookie = 4
            }

            public string? name;
            [YamlMember(Alias = "in")]
            public InFieldValues InField { get; set; }
            public string? description;
            public bool required;
            public Schema? schema;
            public string? style;
        }

        public class Components
        {
            public Dictionary<string, Parameter> parameters = new Dictionary<string, Parameter> {
                { "pageParam", new Parameter
                    {
                        name = "page",
                        description = "If the result set is large, pagination across the results can be employed; in that case, this parameter defines the page number (zero-indexed) that is requested by the client. The number of items included in each page is defined by the 'size' parameter. Default is 0, i.e., the first results page is returned.",
                        InField = Parameter.InFieldValues.query,
                        required = false,
                        schema = new PrimitiveSchema {
                            type = "integer",
                            format = "int32",
                            minimum = "0",
                            DefaultValue = "0"
                        }
                    }
                },
                {
                    "sizeParam", new Parameter
                    {
                        name = "size",
                        description = "The number of items to display on a returned results page (see the page parameter).",
                        InField = Parameter.InFieldValues.query,
                        required = false,
                        schema = new PrimitiveSchema {
                            type = "integer",
                            format = "int32",
                            minimum = "0",
                            maximum = "100",
                            DefaultValue = "20"
                        }
                    }
                },
                {
                    "sortParam", new Parameter
                    {
                        name = "sort",
                        description = "The field and direction to sort results on.",
                        InField = Parameter.InFieldValues.query,
                        required = false,
                        schema = new ReferenceSchema("SortingSchema"),
                        style = "deepObject"
                    }
                }
            };
            public Dictionary<string, Schema> schemas = new Dictionary<string, Schema>
            {
                // Add Hydra Colletions wrapper schema
                {"HydraCollectionWrapper",
                    new ComplexSchema
                    {
                        required = new List<string>
                        {
                            "@context",
                            "@type",
                            "hydra:member"
                        },
                        properties = new Dictionary<string, OASDocument.Schema>
                        {
                            {"@context", new ReferenceSchema("Context") },
                            {"@type", new PrimitiveSchema { type="string", DefaultValue="hydra:Collection"} },
                            {"hydra:totalItems", new PrimitiveSchema { type="integer" } },
                            {"hydra:view", new ComplexSchema
                            {
                                properties = new Dictionary<string, Schema>
                                {
                                    {"@id", new PrimitiveSchema { type="string", format="uri"} },
                                    {"@type", new PrimitiveSchema { type="string", DefaultValue="hydra:PartialCollectionView"} },
                                    {"hydra:first", new PrimitiveSchema { type="string"} },
                                    {"hydra:previous", new PrimitiveSchema { type="string"} },
                                    {"hydra:next", new PrimitiveSchema { type="string"} },
                                    {"hydra:last", new PrimitiveSchema { type="string"} },
                                }
                            } }
                        }
                    }
                },
                // Add the default query operator filter schemas
                {"IntegerFilter", new ComplexSchema {
                    properties = new Dictionary<string, Schema>
                    {
                        {"eq", new PrimitiveSchema {type="integer"} },
                        {"lt", new PrimitiveSchema {type="integer"} },
                        {"lte", new PrimitiveSchema {type="integer"} },
                        {"gt", new PrimitiveSchema {type="integer"} },
                        {"gte", new PrimitiveSchema {type="integer"} }
                    }
                }},
                {"NumberFilter", new ComplexSchema {
                    properties = new Dictionary<string, Schema>
                    {
                        {"eq", new PrimitiveSchema {type="number"} },
                        {"lt", new PrimitiveSchema {type="number"} },
                        {"lte", new PrimitiveSchema {type="number"} },
                        {"gt", new PrimitiveSchema {type="number"} },
                        {"gte", new PrimitiveSchema {type="number"} }
                    }
                }},
                {"StringFilter", new ComplexSchema {
                    properties = new Dictionary<string, Schema>
                    {
                        {"eq", new PrimitiveSchema {type="string"} },
                        {"contains", new PrimitiveSchema {type="string"} },
                        {"regex", new PrimitiveSchema {type="string"} }
                    }
                }},
                {"DateTimeFilter", new ComplexSchema {
                    properties = new Dictionary<string, Schema>
                    {
                        {"eq", new PrimitiveSchema {type="string", format="date-time"} },
                        {"starting", new PrimitiveSchema {type="string", format="date-time"} },
                        {"ending", new PrimitiveSchema {type="string", format="date-time"} },
                        {"before", new PrimitiveSchema {type="string", format="date-time"} },
                        {"after", new PrimitiveSchema {type="string", format="date-time"} },
                        {"latest", new PrimitiveSchema {type="boolean" } }
                    }
                }},
                // And the sort operators schema
                {"SortingSchema", new ComplexSchema {
                    properties = new Dictionary<string, Schema>
                    {
                        {"asc", new PrimitiveSchema {type="string"} },
                        {"desc", new PrimitiveSchema {type="string"} }
                    }
                }}
            };
        }
        
        public class Schema
        {

        }

        public class ComplexSchema: Schema
        {
            public readonly string type = "object";
            public List<string>? required;
            public Dictionary<string, Schema>? properties;
            public int maxProperties;
            public int minProperties;
        }

        public class PrimitiveSchema: Schema
        {
            public string? type;
            public string? format;
            public string? minimum;
            public string? maximum;
            [YamlMember(Alias = "default")]
            public string? DefaultValue { get; set; }
            [YamlMember(Alias = "enum")]
            public string[]? Enumeration { get; set; }
        }

        public class ReferenceSchema: Schema
        {
            public ReferenceSchema(string referenceType)
            {
                Reference = "#/components/schemas/" + referenceType.Replace(":", "_", StringComparison.Ordinal);
            }
            [YamlMember(Alias = "$ref")]
            public string Reference { get; set; }
        }

        public class AllOfSchema: Schema
        {
            public Schema[]? allOf;
        }

        public class ArraySchema: Schema
        {
            public readonly string type = "array";
            public Schema? items;
            public int maxItems;
            public int minItems;
        }

        public class Path
        {
            public Operation? get;
            public Operation? put;
            public Operation? patch;
            public Operation? post;
            public Operation? delete;
        }

        public class Operation
        {
            public string? summary;
            public List<Parameter> parameters = new List<Parameter>();
            public RequestBody? requestBody;
            public Dictionary<string, Response> responses = new Dictionary<string, Response>();
            public List<string> tags = new List<string>();
        }

        public class RequestBody
        {
            public string? description;
            public bool required;
            public Dictionary<string, Content>? content;
        }

        public class Response
        {
            public string? description;
            public Dictionary<string, Content>? content;
        }

        public class Content
        {
            public Schema? schema;
        }
    }
}