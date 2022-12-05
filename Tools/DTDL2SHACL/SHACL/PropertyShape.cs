using VDS.RDF;
using VDS.RDF.Shacl;

namespace DotNetRdfExtensions.SHACL
{
    public class PropertyShape: Shape {

        public PropertyShape(INode node, ShapesGraph graph): base(node, graph) {
        }

        public INode Path {
            get {
                IUriNode shPath = _graph.CreateUriNode(SH.path);
                return _graph.GetTriplesWithSubjectPredicate(_node, shPath).First().Object;
            }
        }

        public IUriNode? Datatype {
            get {
                IUriNode shDatatype = _graph.CreateUriNode(SH.datatype);
                return _graph.GetTriplesWithSubjectPredicate(_node, shDatatype).Select(trip => trip.Object).UriNodes().FirstOrDefault();
            }
        }

        public IEnumerable<IUriNode> Class {
            get {
                IUriNode shClass = _graph.CreateUriNode(SH.cls);
                return _graph.GetTriplesWithSubjectPredicate(_node, shClass).Select(trip => trip.Object).UriNodes();
            }
        }

        public IEnumerable<INode> In {
            get {
                IUriNode shIn = _graph.CreateUriNode(SH.In);
                IEnumerable<INode> inListRoots = _graph.GetTriplesWithSubjectPredicate(_node, shIn).Objects();
                return inListRoots.SelectMany(listItem => _graph.GetListItems(listItem));
            }
        }

        public IEnumerable<ILiteralNode> Names {
            get {
                IUriNode shName = _graph.CreateUriNode(SH.name);
                return _graph.GetTriplesWithSubjectPredicate(_node, shName).Objects().LiteralNodes();
            }
        }

        public IEnumerable<ILiteralNode> Descriptions {
            get {
                IUriNode shDescription = _graph.CreateUriNode(SH.description);
                return _graph.GetTriplesWithSubjectPredicate(_node, shDescription).Objects().LiteralNodes();
            }
        }

        public int? MinCount {
            get {
                IUriNode shMinCount = _graph.CreateUriNode(SH.minCount);
                IEnumerable<int> minCounts = _graph.GetTriplesWithSubjectPredicate(_node, shMinCount)
                    .Objects()
                    .LiteralNodes()
                    .Select(node => int.Parse(node.Value));
                if (minCounts.Count() == 1) {
                    return minCounts.First();
                }
                else {
                    return null;
                }
            }
        }

        public int? MaxCount {
            get {
                IUriNode shMaxCount = _graph.CreateUriNode(SH.maxCount);
                IEnumerable<int> maxCounts = _graph.GetTriplesWithSubjectPredicate(_node, shMaxCount)
                    .Objects()
                    .LiteralNodes()
                    .Select(node => int.Parse(node.Value));
                if (maxCounts.Count() == 1) {
                    return maxCounts.First();
                }
                else {
                    return null;
                }
            }
        }
    }
}