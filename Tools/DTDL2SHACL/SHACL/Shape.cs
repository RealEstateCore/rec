using VDS.RDF;
using VDS.RDF.Shacl;
using VDS.RDF.Nodes;
using VDS.RDF.Writing.Formatting;

namespace DotNetRdfExtensions.SHACL
{
    public class Shape: IEquatable<Shape>  {
        /// <summary>
        /// The Node which this Shape is a wrapper around.
        /// </summary>
        protected INode _node;
        /// <summary>
        /// The Graph from which this Shape originates.
        /// </summary>
        protected ShapesGraph _graph;
        protected INodeFormatter _formatter;


        // Implementation of IEquatable<T> interface
        public bool Equals(Shape? shape)
        {
            return this.Node == shape?.Node;
        }

        public IUriNode? NodeKind {
            get {
                IUriNode shNodeKind = _graph.CreateUriNode(SH.nodeKind);
                return _graph.GetTriplesWithSubjectPredicate(_node, shNodeKind).Select(trip => trip.Object).UriNodes().FirstOrDefault();
            }
            set {
                IUriNode shNodeKind = _graph.CreateUriNode(SH.nodeKind);
                 IUriNode? currentNodeKind = _graph.GetTriplesWithSubjectPredicate(_node, shNodeKind).Select(trip => trip.Object).UriNodes().FirstOrDefault();
                 if (currentNodeKind != null) {
                    _graph.Retract(_node, shNodeKind, currentNodeKind);
                 }
                _graph.Assert(_node, shNodeKind, value);
            }
        }

        protected internal Shape(INode node, ShapesGraph graph) {
            _node = node;
            _graph = graph;
            _formatter = new TurtleFormatter(_graph);
        }

        public INode Node
        {
            get
            {
                return _node;
            }
        }

        public ShapesGraph Graph
        {
            get
            {
                return _graph;
            }
        }

        public bool IsDeprecated 
        {
            get 
            {
                IUriNode owlDeprecated = _graph.CreateUriNode(OWL.deprecated);
                return _graph.GetTriplesWithSubjectPredicate(_node, owlDeprecated).Objects().LiteralNodes().Any(deprecationNode => deprecationNode.AsValuedNode().AsBoolean() == true);
            }
        }

        public void AddLabel(string language, string value) {
            IUriNode rdfsLabel = _graph.CreateUriNode(RDFS.label);
            ILiteralNode labelNode = _graph.CreateLiteralNode(value, language);
            _graph.Assert(_node, rdfsLabel, labelNode);
        }

        public void AddComment(string language, string value) {
            IUriNode rdfsComment = _graph.CreateUriNode(RDFS.comment);
            ILiteralNode commentNode = _graph.CreateLiteralNode(value, language);
            _graph.Assert(_node, rdfsComment, commentNode);
        }
    }
}