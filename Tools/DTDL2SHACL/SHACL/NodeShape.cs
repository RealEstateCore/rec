using VDS.RDF;
using VDS.RDF.Shacl;
using VDS.RDF.Query;
using VDS.RDF.Query.Builder;
using VDS.RDF.Query.Datasets;
using VDS.RDF.Writing;

namespace DotNetRdfExtensions.SHACL
{
    public class  NodeShape: Shape {

        public Uri Uri { get { return Node.Uri; } }

        public NodeShape(IUriNode node, ShapesGraph graph): base(node, graph) {
        }

        public void AddSuperClass(NodeShape superShape) {
            IUriNode superShapeNode = _graph.GetUriNode(superShape.Uri);
            IUriNode rdfsSubClassOf = _graph.CreateUriNode(RDFS.subClassOf);
            _graph.Assert(Node, rdfsSubClassOf, superShapeNode);
        }

        public IEnumerable<PropertyShape> PropertyShapes {
            get {
                IUriNode shTargetClass = _graph.CreateUriNode(SH.targetClass);
                IUriNode shProperty = _graph.CreateUriNode(SH.property);
                foreach (Triple t in _graph.GetTriplesWithSubjectPredicate(_node, shProperty))
                {
                    yield return new PropertyShape(t.Object, _graph);
                }
            }
        }

        public IEnumerable<NodeShape> DirectSuperShapes {
            get {
                IUriNode rdfsSubClassOf = _graph.CreateUriNode(RDFS.subClassOf);
                foreach (Triple t in _graph.GetTriplesWithSubjectPredicate(_node, rdfsSubClassOf))
                {
                    if (t.Object is IUriNode superClass && superClass.IsNodeShape()) {
                        yield return new NodeShape(superClass, _graph);
                    }
                }
            }
        }

        public IEnumerable<NodeShape> SuperShapes {
            get {
                IEnumerable<NodeShape> directSuperShapes = this.DirectSuperShapes;
                HashSet<NodeShape> allSuperShapes = new HashSet<NodeShape>();
                allSuperShapes.UnionWith(directSuperShapes);
                foreach (NodeShape superClass in directSuperShapes) {
                    allSuperShapes.UnionWith(superClass.SuperShapes);
                }
                return allSuperShapes;
            }
        }

        public IEnumerable<NodeShape> DirectSubShapes {
            get {
                IUriNode rdfsSubClassOf = _graph.CreateUriNode(RDFS.subClassOf);
                foreach (Triple t in _graph.GetTriplesWithPredicateObject(rdfsSubClassOf,_node))
                {
                    if (t.Subject is IUriNode subClassNode && subClassNode.IsNodeShape()) {
                        yield return new NodeShape(subClassNode, _graph);
                    }
                }
            }
        }

        public IEnumerable<NodeShape> SubShapes {
            get {
                IEnumerable<NodeShape> directSubShapes = this.DirectSubShapes;
                HashSet<NodeShape> allSubShapes = new HashSet<NodeShape>();
                allSubShapes.UnionWith(directSubShapes);
                foreach (NodeShape subClass in directSubShapes) {
                    allSubShapes.UnionWith(subClass.SubShapes);
                }
                return allSubShapes;
            }
        }

        public List<IUriNode> LongestSuperShapesPath {
            get {
                IEnumerable<NodeShape> directSuperShapes = this.DirectSuperShapes.Where(superShape => !superShape.IsDeprecated);
                if (directSuperShapes.Count() < 1 || directSuperShapes.Any(superClass => superClass.IsTopThing)) {
                    return new List<IUriNode>();
                }
                else {
                    // Assume the first parent has the longest path; if not, it will be replaced in subsequent foreach
                    NodeShape longestParent = directSuperShapes.First();
                    List<IUriNode> longestParentPath = longestParent.LongestSuperShapesPath;
                     // Iterate through the other parents to see if any is longer
                    foreach (NodeShape possibleSuperShape in directSuperShapes.Skip(1))
                    {
                        List<IUriNode> possibleSuperShapeParents = possibleSuperShape.LongestSuperShapesPath;
                        if (possibleSuperShapeParents.Count() > longestParentPath.Count())
                        {
                            longestParent = possibleSuperShape;
                            longestParentPath = possibleSuperShapeParents;
                        }
                    }
                    // At this point longestParentPath + longestParent should together contain the longest path to the root; return them
                    longestParentPath.Add(longestParent.Node);
                    return longestParentPath;
                }
            }
        }

        new public IUriNode Node
        {
            get
            {
                return (IUriNode)_node;
            }
        }

        public bool IsTopThing
        {
            get {
                string[] topLevelThings = {
                    OWL.Thing.AbsoluteUri,
                    RDFS.Resource.AbsoluteUri
                };
                return topLevelThings.Contains(Node.Uri.AbsoluteUri);
            }            
        }
    }
}