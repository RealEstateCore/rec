using VDS.RDF;
using VDS.RDF.Parsing;
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

        public void AddDatatype(Uri dt) {
            IUriNode shDatatype = _graph.CreateUriNode(SH.datatype);
            IUriNode dtNode = _graph.CreateUriNode(dt);
            _graph.Assert(_node, shDatatype, dtNode);
        }

        public IEnumerable<IUriNode> Class {
            get {
                IUriNode shClass = _graph.CreateUriNode(SH.cls);
                return _graph.GetTriplesWithSubjectPredicate(_node, shClass).Select(trip => trip.Object).UriNodes();
            }
        }

        public void AddClass(Uri cls) {
            IUriNode shClass = _graph.CreateUriNode(SH.cls);
            IUriNode clsNode = _graph.CreateUriNode(cls);
            _graph.Assert(_node, shClass, clsNode);
        }

        public void AddName(string language, string value) {
            IUriNode shName = _graph.CreateUriNode(SH.name);
            ILiteralNode nameNode = _graph.CreateLiteralNode(value, language);
            _graph.Assert(_node, shName, nameNode);
        }

        public void AddNode(Uri node) {
            IUriNode nodeTarget = _graph.CreateUriNode(node);
            IUriNode shNode = _graph.CreateUriNode(SH.node);
            _graph.Assert(_node, shNode, nodeTarget);
        }

        public void AddDescription(string language, string value) {
            IUriNode shDescription = _graph.CreateUriNode(SH.description);
            ILiteralNode descriptionNode = _graph.CreateLiteralNode(value, language);
            _graph.Assert(_node, shDescription, descriptionNode);
        }

        public IEnumerable<INode> In {
            get {
                IUriNode shIn = _graph.CreateUriNode(SH.In);
                IEnumerable<INode> inListRoots = _graph.GetTriplesWithSubjectPredicate(_node, shIn).Objects();
                return inListRoots.SelectMany(listItem => _graph.GetListItems(listItem));
            }
        }

        public void AddIn(INode inNode) {
            IUriNode shIn = _graph.CreateUriNode(SH.In);
            List<INode> newInList = new(){inNode};
            INode? existingInListRoot = _graph.GetTriplesWithSubjectPredicate(_node, shIn).Objects().FirstOrDefault();
            if (existingInListRoot != null) {
                _graph.AddToList(existingInListRoot, newInList);
            }
            else {
                INode newInListRoot = _graph.AssertList(newInList);
                _graph.Assert(_node, shIn, newInListRoot);
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
            set {
                IUriNode shMinCount = _graph.CreateUriNode(SH.minCount);
                var currentMinCountTriples = _graph.GetTriplesWithSubjectPredicate(_node, shMinCount).ToList();
                _graph.Retract(currentMinCountTriples);
                if (value != null) {
                    ILiteralNode minCountNode = _graph.CreateLiteralNode(value.ToString(), UriFactory.Create(XmlSpecsHelper.XmlSchemaDataTypeInteger));
                    _graph.Assert(_node, shMinCount, minCountNode);
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
            set {
                IUriNode shMaxCount = _graph.CreateUriNode(SH.maxCount);
                var currentMaxCountTriples = _graph.GetTriplesWithSubjectPredicate(_node, shMaxCount).ToList();
                _graph.Retract(currentMaxCountTriples);
                if (value != null) {
                    ILiteralNode maxCountNode = _graph.CreateLiteralNode(value.ToString(), UriFactory.Create(XmlSpecsHelper.XmlSchemaDataTypeInteger));
                    _graph.Assert(_node, shMaxCount, maxCountNode);
                }
            }
        }
    }
}