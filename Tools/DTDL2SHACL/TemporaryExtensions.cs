using DotNetRdfExtensions;
using DotNetRdfExtensions.SHACL;
using VDS.RDF.Shacl;
using Microsoft.Azure.DigitalTwins.Parser;
using Microsoft.Azure.DigitalTwins.Parser.Models;

namespace DTDL2SHACL
{
    public static class TemporaryExtensions
    {

        public static string ToPrettyString(this NodeShape nodeShape)
        {
            // TODO IMplement me and rename
            return nodeShape.Uri().ToString();
        }

        public static Uri Uri(this NodeShape nodeShape)
        {
            return nodeShape.Node.Uri;
        }

        public static List<NodeShape> subClassOf(this NodeShape nodeShape)
        {
            // TODO: This should be a Property that gets/sets triplies in the underlying graph.
            return nodeShape.DirectSuperShapes.ToList();
        }

        // Recursively get greatest depth of interface in Extends hierarchy
        public static int GetDepth(this DTInterfaceInfo iFace)
        {
            if (iFace.Extends.Count == 0)
            {
                return 0;
            }

            int greatestParentDepth = 0;
            foreach (DTInterfaceInfo parent in iFace.Extends)
            {
                int parentDepth = GetDepth(parent);
                if (parentDepth > greatestParentDepth)
                {
                    greatestParentDepth = parentDepth;
                }
            }

            return greatestParentDepth + 1;
        }

        public static NodeShape CreateNodeShape(this ShapesGraph graph, Uri uri)
        {
            // TODO: This should create all the necessary axioms in the underlying graph
            return new NodeShape(graph.CreateUriNode(uri), graph);
        }
    }
}
