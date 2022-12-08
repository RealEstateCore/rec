/// <summary>
/// A set of often-used URIs, for easy reference.
/// </summary>
namespace DotNetRdfExtensions
{
    public static class DC
    {
        public static readonly Uri title = new Uri("http://purl.org/dc/elements/1.1/title");
        public static readonly Uri description = new Uri("http://purl.org/dc/elements/1.1/description");
    }

    public static class CC
    {
        public static readonly Uri license = new Uri("http://creativecommons.org/ns#license");
    }

    public static class SH
    {
        public static readonly Uri NodeShape = new Uri("http://www.w3.org/ns/shacl#NodeShape");
        public static readonly Uri PropertyShape = new Uri("http://www.w3.org/ns/shacl#PropertyShape");
        public static readonly Uri property = new Uri("http://www.w3.org/ns/shacl#property");
        public static readonly Uri path = new Uri("http://www.w3.org/ns/shacl#path");
        public static readonly Uri cls = new Uri("http://www.w3.org/ns/shacl#class");
        public static readonly Uri targetClass = new Uri("http://www.w3.org/ns/shacl#targetClass");
        public static readonly Uri In = new Uri("http://www.w3.org/ns/shacl#in");
        public static readonly Uri datatype = new Uri("http://www.w3.org/ns/shacl#datatype");
        public static readonly Uri minCount = new Uri("http://www.w3.org/ns/shacl#minCount");
        public static readonly Uri maxCount = new Uri("http://www.w3.org/ns/shacl#maxCount");
        public static readonly Uri nodeKind = new Uri("http://www.w3.org/ns/shacl#nodeKind");
        public static readonly Uri node = new Uri("http://www.w3.org/ns/shacl#node");
        public static readonly Uri name = new Uri("http://www.w3.org/ns/shacl#name");
        public static readonly Uri description = new Uri("http://www.w3.org/ns/shacl#description");
        public static readonly Uri IRI = new Uri("http://www.w3.org/ns/shacl#IRI");
    }

    public static class RDF
    {
            public static readonly Uri type = new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#type");
            public static readonly Uri first = new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#first");
            public static readonly Uri rest = new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#rest");
            public static readonly Uri nil = new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#nil");
    }

    public static class SKOS 
    {
        public static readonly Uri definition = new Uri("http://www.w3.org/2004/02/skos/core#definition");
    }
    public static class RDFS
    {
        public static readonly Uri label = new Uri("http://www.w3.org/2000/01/rdf-schema#label");
        public static readonly Uri domain = new Uri("http://www.w3.org/2000/01/rdf-schema#domain");
        public static readonly Uri range = new Uri("http://www.w3.org/2000/01/rdf-schema#range");
        public static readonly Uri comment = new Uri("http://www.w3.org/2000/01/rdf-schema#comment");
        public static readonly Uri subClassOf = new Uri("http://www.w3.org/2000/01/rdf-schema#subClassOf");
        public static readonly Uri Datatype = new Uri("http://www.w3.org/2000/01/rdf-schema#Datatype");
        public static readonly Uri Literal = new Uri("http://www.w3.org/2000/01/rdf-schema#Literal");
        public static readonly Uri Resource = new Uri("http://www.w3.org/2000/01/rdf-schema#Resource");
        public static readonly Uri Class = new Uri("http://www.w3.org/2000/01/rdf-schema#Class");
    }

    public static class OWL
    {
        public static readonly Uri Class = new Uri("http://www.w3.org/2002/07/owl#Class");
        public static readonly Uri ObjectProperty = new Uri("http://www.w3.org/2002/07/owl#ObjectProperty");
        public static readonly Uri DatatypeProperty = new Uri("http://www.w3.org/2002/07/owl#DatatypeProperty");
        public static readonly Uri Thing = new Uri("http://www.w3.org/2002/07/owl#Thing");
        public static readonly Uri Restriction = new Uri("http://www.w3.org/2002/07/owl#Restriction");
        public static readonly Uri FunctionalProperty = new Uri("http://www.w3.org/2002/07/owl#FunctionalProperty");
        public static readonly Uri versionIRI = new Uri("http://www.w3.org/2002/07/owl#versionIRI");
        public static readonly Uri versionInfo = new Uri("http://www.w3.org/2002/07/owl#versionInfo");
        public static readonly Uri deprecated = new Uri("http://www.w3.org/2002/07/owl#deprecated");
        public static readonly Uri oneOf = new Uri("http://www.w3.org/2002/07/owl#oneOf");

        public static readonly Uri annotatedSource = new Uri("http://www.w3.org/2002/07/owl#annotatedSource");
        public static readonly Uri annotatedProperty = new Uri("http://www.w3.org/2002/07/owl#annotatedProperty");
        public static readonly Uri annotatedTarget = new Uri("http://www.w3.org/2002/07/owl#annotatedTarget");

        #region Restrictions
        public static readonly Uri onProperty = new Uri("http://www.w3.org/2002/07/owl#onProperty");
        public static readonly Uri onClass = new Uri("http://www.w3.org/2002/07/owl#onClass");
        public static readonly Uri cardinality = new Uri("http://www.w3.org/2002/07/owl#cardinality");
        public static readonly Uri qualifiedCardinality = new Uri("http://www.w3.org/2002/07/owl#qualifiedCardinality");
        public static readonly Uri allValuesFrom = new Uri("http://www.w3.org/2002/07/owl#allValuesFrom");
        public static readonly Uri someValuesFrom = new Uri("http://www.w3.org/2002/07/owl#someValuesFrom");
        public static readonly Uri minCardinality = new Uri("http://www.w3.org/2002/07/owl#minCardinality");
        public static readonly Uri minQualifiedCardinality = new Uri("http://www.w3.org/2002/07/owl#minQualifiedCardinality");
        public static readonly Uri maxCardinality = new Uri("http://www.w3.org/2002/07/owl#maxCardinality");
        public static readonly Uri maxQualifiedCardinality = new Uri("http://www.w3.org/2002/07/owl#maxQualifiedCardinality");
        #endregion
    }
}
