using Microsoft.Azure.DigitalTwins.Parser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTDL2OAS
{
    internal class OperationGenerators
    {
        internal static OASDocument.Operation GenerateGetEntityByIdOperation(string endpointName, string schemaName, string interfaceLabel)
        {
            OASDocument.Operation getOperation = new OASDocument.Operation();
            getOperation.summary = $"Get a specific '{interfaceLabel}' object.";
            getOperation.tags.Add(endpointName);

            // Add the ID parameter
            OASDocument.Parameter idParameter = new OASDocument.Parameter
            {
                name = "id",
                description = $"Id of '{interfaceLabel}' to return.",
                InField = OASDocument.Parameter.InFieldValues.path,
                required = true,
                schema = new OASDocument.PrimitiveSchema
                {
                    type = "string"
                }
            };
            getOperation.parameters.Add(idParameter);

            // Create each of the HTTP response types
            OASDocument.Response response404 = new OASDocument.Response();
            response404.description = $"An object of type '{interfaceLabel}' with the specified ID was not found.";
            getOperation.responses.Add("404", response404);

            OASDocument.Response response500 = new OASDocument.Response();
            response500.description = "Internal Server Error";
            getOperation.responses.Add("500", response500);

            OASDocument.Response response200 = new OASDocument.Response();
            response200.description = $"A '{interfaceLabel}' object.";
            getOperation.responses.Add("200", response200);

            response200.content = new Dictionary<string, OASDocument.Content>();
            OASDocument.Content content200 = new OASDocument.Content();
            response200.content.Add("application/ld+json", content200);

            // Response is per previously defined schema
            content200.schema = MergeInterfaceSchemaWithContext(schemaName);

            return getOperation;
        }

        internal static OASDocument.Operation GeneratePostEntityOperation(string endpointName, string schemaName, string interfaceLabel)
        {
            OASDocument.Operation postOperation = new OASDocument.Operation();
            postOperation.summary = $"Create a new '{interfaceLabel}' object.";
            postOperation.tags.Add(endpointName);

            // Create request body
            OASDocument.RequestBody body = new OASDocument.RequestBody
            {
                description = $"New '{interfaceLabel}' entity that is to be added.",
                required = true,
                content = new Dictionary<string, OASDocument.Content>
                {
                    {
                        "application/ld+json", new OASDocument.Content
                        {
                            schema = MergeInterfaceSchemaWithContext(schemaName)
                        }
                    }
                }
            };
            postOperation.requestBody = body;

            // Create each of the HTTP response types
            OASDocument.Response response500 = new OASDocument.Response();
            response500.description = "Internal Server Error";
            postOperation.responses.Add("500", response500);

            OASDocument.Response response400 = new OASDocument.Response();
            response400.description = "Bad Request";
            postOperation.responses.Add("400", response400);

            OASDocument.Response response201 = new OASDocument.Response();
            response201.description = "Entity was successfully created (new representation returned).";
            postOperation.responses.Add("201", response201);

            response201.content = new Dictionary<string, OASDocument.Content>();
            OASDocument.Content content201 = new OASDocument.Content();
            response201.content.Add("application/ld+json", content201);

            // Response is per previously defined schema
            content201.schema = MergeInterfaceSchemaWithContext(schemaName);

            return postOperation;
        }

        internal static OASDocument.Operation GenerateGetEntitiesOperation(string endpointName, DTInterfaceInfo dtInterface, string schemaName, string interfaceLabel)
        {

            // Create Get
            OASDocument.Operation getOperation = new OASDocument.Operation();
            getOperation.summary = "Get '" + interfaceLabel + "' entities.";
            getOperation.tags.Add(endpointName);

            // Add pagination parameters
            getOperation.parameters.Add(new OASDocument.Parameter { ReferenceTo = "pageParam" });
            getOperation.parameters.Add(new OASDocument.Parameter { ReferenceTo = "sizeParam" });

            // Add sort param
            getOperation.parameters.Add(new OASDocument.Parameter { ReferenceTo = "sortParam" });

            // Add parameters for each property field that can be expressed on this class
            foreach (DTRelationshipInfo relationship in dtInterface.AllRelationships())
            {
                string RelationshipName = Program.GetApiName(relationship);
                OASDocument.Parameter parameter = new OASDocument.Parameter
                {
                    name = RelationshipName,
                    description = $"Filter value on relationship '{RelationshipName}'.",
                    required = false,
                    schema = new OASDocument.ReferenceSchema("StringFilter"),
                    InField = OASDocument.Parameter.InFieldValues.query
                };
                getOperation.parameters.Add(parameter);
            }
            foreach (DTPropertyInfo property in dtInterface.AllProperties())
            {
                // Fall back to string representation for complex schemas
                string propertyType = "string";
                string propertyFormat = "";

                // Check the schema type against predefined mapping
                if (property.Schema is DTPrimitiveSchemaInfo)
                {
                    Type schemaType = property.Schema.GetType();
                    if (Program.dtdlOsaMappings.ContainsKey(schemaType))
                    {
                        propertyType = Program.dtdlOsaMappings[schemaType].Item1;
                        string format = Program.dtdlOsaMappings[schemaType].Item2;
                        if (format.Length > 0)
                        {
                            propertyFormat = format;
                        }
                    }
                }

                // Select a filter schema to use for parameter formats where it is applicable
                string filterSchema = "";
                switch (propertyType)
                {
                    case "string":
                        filterSchema = propertyFormat switch
                        {
                            "date-time" => "DateTimeFilter",
                            _ => "StringFilter",
                        };
                        break;

                    case "integer":
                        filterSchema = "IntegerFilter";
                        break;

                    case "number":
                        filterSchema = "NumberFilter";
                        break;
                }

                // Base the property schema on the filter, if one was selected above
                // Otherwise, just do a simple type-based schema, possibly with format if one was found
                OASDocument.Schema propertySchema;
                if (filterSchema.Length > 0)
                {
                    propertySchema = new OASDocument.ReferenceSchema(filterSchema);
                }
                else
                {
                    if (propertyFormat.Length > 0)
                    {
                        propertySchema = new OASDocument.PrimitiveSchema
                        {
                            type = propertyType,
                            format = propertyFormat
                        };
                    }
                    else
                    {
                        propertySchema = new OASDocument.PrimitiveSchema
                        {
                            type = propertyType
                        };
                    }
                }

                OASDocument.Parameter parameter = new OASDocument.Parameter
                {
                    name = property.Name,
                    description = $"Filter value on property '{property.Name}'.",
                    required = false,
                    schema = propertySchema,
                    InField = OASDocument.Parameter.InFieldValues.query
                };

                if (filterSchema.Length > 0)
                {
                    parameter.style = "deepObject";
                }

                getOperation.parameters.Add(parameter);
            }
            /*
             * TODO: FIXME
            foreach (OntologyProperty property in oClass.IsExhaustiveDomainOfUniques()
            .Where(property => property.IsDataProperty() || property.IsObjectProperty())
            .Where(property => property.Ranges.Count() == 1)
            .Where(property => IsIncluded(property)))
            {
                string propertyLabel = GetKeyNameForResource(property);

                // Fall back to string representation and no format for object properties
                // abd data properties w/ unknown types
                string propertyType = "string";
                string propertyFormat = "";

                // Check that range is an XSD type that can be parsed into 
                // an OAS type and format (note: not all XSD types are covered)
                OntologyClass range = property.Ranges.First();
                if (range.IsNamed())
                {
                    if (range.IsXsdDatatype() || range.IsSimpleXsdWrapper())
                    {
                        string rangeXsdType = "";
                        if (range.IsXsdDatatype())
                        {
                            rangeXsdType = ((UriNode)range.Resource).GetLocalName();
                        }
                        else
                        {
                            rangeXsdType = range.EquivalentClasses.First().GetUriNode().GetLocalName();
                        }
                        if (xsdOsaMappings.ContainsKey(rangeXsdType))
                        {
                            propertyType = xsdOsaMappings[rangeXsdType].Item1;
                            string format = xsdOsaMappings[rangeXsdType].Item2;
                            if (format.Length > 0)
                            {
                                propertyFormat = format;
                            }
                        }
                    }
                }

                // Select a filter schema to use for parameter formats where it is applicable
                string filterSchema = "";
                switch (propertyType)
                {
                    case "string":
                        filterSchema = propertyFormat switch
                        {
                            "date-time" => "DateTimeFilter",
                            _ => "StringFilter",
                        };
                        break;

                    case "integer":
                        filterSchema = "IntegerFilter";
                        break;

                    case "number":
                        filterSchema = "NumberFilter";
                        break;
                }

                // Base the property schema on the filter, if one was selected above
                // Otherwise, just do a simple type-based schema, possibly with format if one was found
                OASDocument.Schema propertySchema;
                if (filterSchema.Length > 0)
                {
                    propertySchema = new OASDocument.ReferenceSchema(filterSchema);
                }
                else
                {
                    if (propertyFormat.Length > 0)
                    {
                        propertySchema = new OASDocument.PrimitiveSchema
                        {
                            type = propertyType,
                            format = propertyFormat
                        };
                    }
                    else
                    {
                        propertySchema = new OASDocument.PrimitiveSchema
                        {
                            type = propertyType
                        };
                    }
                }

                OASDocument.Parameter parameter = new OASDocument.Parameter
                {
                    name = propertyLabel,
                    description = $"Filter value on property '{propertyLabel}'.",
                    required = false,
                    schema = propertySchema,
                    InField = OASDocument.Parameter.InFieldValues.query
                };

                if (filterSchema.Length > 0)
                {
                    parameter.style = "deepObject";
                }

                getOperation.parameters.Add(parameter);
            }
            */

            // Create each of the HTTP response types
            OASDocument.Response response400 = new OASDocument.Response();
            response400.description = "Bad Request";
            getOperation.responses.Add("400", response400);

            OASDocument.Response response500 = new OASDocument.Response();
            response500.description = "Internal Server Error";
            getOperation.responses.Add("500", response500);

            OASDocument.Response response200 = new OASDocument.Response();
            response200.description = "An array of '" + interfaceLabel + "' objects.";
            getOperation.responses.Add("200", response200);

            response200.content = new Dictionary<string, OASDocument.Content>();
            OASDocument.Content content200 = new OASDocument.Content();
            response200.content.Add("application/ld+json", content200);

            // Generate schema with required fields propped on via allOf (if any required fields exist)
            OASDocument.Schema interfaceSchema = MergeInterfaceSchemaWithContext(schemaName);

            // Generate wrapper Hydra schema (https://www.hydra-cg.com/spec/latest/core/)
            OASDocument.Schema hydraSchema = new OASDocument.AllOfSchema
            {
                allOf = new OASDocument.Schema[]
                {
                    new OASDocument.ReferenceSchema("HydraCollectionWrapper"),
                    new OASDocument.ComplexSchema
                    {
                        properties = new Dictionary<string, OASDocument.Schema>
                        {
                            {"hydra:member", new OASDocument.ArraySchema  {
                                items = interfaceSchema
                            } }
                        }
                    }
                }
            };

            // Wrap responses in array
            content200.schema = hydraSchema;

            // Return
            return getOperation;
        }

        internal static OASDocument.Operation GeneratePatchToIdOperation(string endpointName, string schemaName, string interfaceLabel)
        {
            OASDocument.Operation patchOperation = new OASDocument.Operation();
            patchOperation.summary = $"Update a single property on a specific '{interfaceLabel}' object.";
            patchOperation.tags.Add(endpointName);

            // Add the ID parameter
            OASDocument.Parameter idParameter = new OASDocument.Parameter
            {
                name = "id",
                description = $"Id of '{interfaceLabel}' to update.",
                InField = OASDocument.Parameter.InFieldValues.path,
                required = true,
                schema = new OASDocument.PrimitiveSchema
                {
                    type = "string"
                }
            };
            patchOperation.parameters.Add(idParameter);

            // Create patch schema
            OASDocument.ReferenceSchema contextReferenceSchema = new OASDocument.ReferenceSchema("Context");
            OASDocument.ComplexSchema contextPropertySchema = new OASDocument.ComplexSchema
            {
                required = new List<string> { "@context" },
                properties = new Dictionary<string, OASDocument.Schema>() { { "@context", contextReferenceSchema } }
            };

            OASDocument.Schema patchSchema = new OASDocument.AllOfSchema
            {
                allOf = new OASDocument.Schema[] {
                        contextPropertySchema,
                        new OASDocument.ReferenceSchema(schemaName),
                        new OASDocument.ComplexSchema {
                            minProperties = 2,
                            maxProperties = 2
                        }
                    }
            };

            // Add request body
            OASDocument.RequestBody body = new OASDocument.RequestBody
            {
                description = "A single JSON key-value pair (plus @context), indicating the property to update and its new value. Note that the Swagger UI does not properly show the size constraint on this parameter; but the underlying OpenAPI Specification document does.",
                required = true,
                content = new Dictionary<string, OASDocument.Content>
                {
                    {
                        "application/ld+json", new OASDocument.Content
                        {
                            schema = patchSchema
                        }
                    }
                }
            };
            patchOperation.requestBody = body;

            // Create each of the HTTP response types
            OASDocument.Response response400 = new OASDocument.Response();
            response400.description = "Bad Request";
            patchOperation.responses.Add("400", response400);

            OASDocument.Response response404 = new OASDocument.Response();
            response404.description = $"An object of type '{interfaceLabel}' with the specified ID was not found.";
            patchOperation.responses.Add("404", response404);

            OASDocument.Response response500 = new OASDocument.Response();
            response500.description = "Internal Server Error";
            patchOperation.responses.Add("500", response500);

            OASDocument.Response response200 = new OASDocument.Response();
            response200.description = "Entity was updated successfully (new representation returned).";
            patchOperation.responses.Add("200", response200);

            response200.content = new Dictionary<string, OASDocument.Content>();
            OASDocument.Content content200 = new OASDocument.Content();
            response200.content.Add("application/ld+json", content200);

            // Response is per previously defined schema
            content200.schema = MergeInterfaceSchemaWithContext(schemaName);

            return patchOperation;
        }

        internal static OASDocument.Operation GeneratePutToIdOperation(string endpointName, string schemaName, string interfaceLabel)
        {
            OASDocument.Operation putOperation = new OASDocument.Operation();
            putOperation.summary = $"Update an existing '{interfaceLabel}' entity.";
            putOperation.tags.Add(endpointName);

            // Add the ID parameter
            OASDocument.Parameter idParameter = new OASDocument.Parameter
            {
                name = "id",
                description = $"Id of '{interfaceLabel}' to update.",
                InField = OASDocument.Parameter.InFieldValues.path,
                required = true,
                schema = new OASDocument.PrimitiveSchema
                {
                    type = "string"
                }
            };
            putOperation.parameters.Add(idParameter);

            // Add request body
            OASDocument.RequestBody body = new OASDocument.RequestBody
            {
                description = $"Updated data for '{interfaceLabel}' entity.",
                required = true,
                content = new Dictionary<string, OASDocument.Content>
                {
                    {
                        "application/ld+json", new OASDocument.Content
                        {
                            schema = MergeInterfaceSchemaWithContext(schemaName)
                        }
                    }
                }
            };
            putOperation.requestBody = body;

            // Create each of the HTTP response types
            OASDocument.Response response400 = new OASDocument.Response();
            response400.description = "Bad Request";
            putOperation.responses.Add("400", response400);

            OASDocument.Response response404 = new OASDocument.Response();
            response404.description = $"An object of type '{interfaceLabel}' with the specified ID was not found.";
            putOperation.responses.Add("404", response404);

            OASDocument.Response response500 = new OASDocument.Response();
            response500.description = "Internal Server Error";
            putOperation.responses.Add("500", response500);

            OASDocument.Response response200 = new OASDocument.Response();
            response200.description = "Entity was updated successfully (new representation returned).";
            putOperation.responses.Add("200", response200);

            response200.content = new Dictionary<string, OASDocument.Content>();
            OASDocument.Content content200 = new OASDocument.Content();
            response200.content.Add("application/ld+json", content200);

            // Response is per previously defined schema
            content200.schema = MergeInterfaceSchemaWithContext(schemaName);

            return putOperation;
        }

        internal static OASDocument.Operation GenerateDeleteByIdOperation(string endpointName, string interfaceLabel)
        {
            OASDocument.Operation deleteOperation = new OASDocument.Operation();
            deleteOperation.summary = $"Delete a '{interfaceLabel}' object.";
            deleteOperation.tags.Add(endpointName);

            // Add the ID parameter
            OASDocument.Parameter idParameter = new OASDocument.Parameter
            {
                name = "id",
                description = $"Id of '{interfaceLabel}' to delete.",
                InField = OASDocument.Parameter.InFieldValues.path,
                required = true,
                schema = new OASDocument.PrimitiveSchema
                {
                    type = "string"
                }
            };
            deleteOperation.parameters.Add(idParameter);

            // Create each of the HTTP response types
            OASDocument.Response response404 = new OASDocument.Response();
            response404.description = $"An object of type '{interfaceLabel}' with the specified ID was not found.";
            deleteOperation.responses.Add("404", response404);

            OASDocument.Response response500 = new OASDocument.Response();
            response500.description = "Internal Server Error";
            deleteOperation.responses.Add("500", response500);

            OASDocument.Response response200 = new OASDocument.Response();
            response200.description = $"'{interfaceLabel}' entity was successfully deleted.";
            deleteOperation.responses.Add("200", response200);

            return deleteOperation;
        }

        private static OASDocument.Schema MergeInterfaceSchemaWithContext(string interfaceLabel)
        {
            OASDocument.AllOfSchema itemSchema = new OASDocument.AllOfSchema();
            OASDocument.ReferenceSchema classSchema = new OASDocument.ReferenceSchema(interfaceLabel);
            OASDocument.ReferenceSchema contextReferenceSchema = new OASDocument.ReferenceSchema("Context");
            OASDocument.ComplexSchema contextPropertySchema = new OASDocument.ComplexSchema
            {
                required = new List<string> { "@context" },
                properties = new Dictionary<string, OASDocument.Schema>() { { "@context", contextReferenceSchema } }
            };

            // Otherwise merge only with context
            itemSchema.allOf = new OASDocument.Schema[]
            {
                contextPropertySchema,
                classSchema
            };
            return itemSchema;
        }
    }
}
