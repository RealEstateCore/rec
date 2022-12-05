using VDS.RDF;
using VDS.RDF.Shacl;

namespace DotNetRdfExtensions.SHACL {
    public static class DotNetRdfExtensions {
        public static IEnumerable<NodeShape> NodeShapes(this ShapesGraph graph) {
            IUriNode rdfType = graph.CreateUriNode(RDF.type);
            IUriNode shNodeShape = graph.CreateUriNode(SH.NodeShape);
            foreach (Triple t in graph.GetTriplesWithPredicateObject(rdfType, shNodeShape)) {
                if (t.Subject.NodeType == NodeType.Uri) {
                    yield return new NodeShape((IUriNode)t.Subject, graph);
                }
            }
        }

        public static NodeShape CreateNodeShape(this ShapesGraph graph, Uri uri)
        {
            IUriNode node = graph.CreateUriNode(uri);
            IUriNode rdfType = graph.CreateUriNode(RDF.type);
            IUriNode rdfsClass = graph.CreateUriNode(RDFS.Class);
            IUriNode shNodeShape = graph.CreateUriNode(SH.NodeShape);
            graph.Assert(node, rdfType, rdfsClass);
            graph.Assert(node, rdfType, shNodeShape);
            return new NodeShape(node, graph);
        }

        public static bool IsNodeShape(this INode node) {
            IGraph graph = node.Graph;
            IUriNode rdfType = graph.CreateUriNode(RDF.type);
            IUriNode shNodeShape = graph.CreateUriNode(SH.NodeShape);
            return graph.ContainsTriple(node, rdfType, shNodeShape);
        }
    }
}