using VDS.RDF;
using VDS.RDF.Parsing;
using VDS.RDF.Ontology;
using VDS.RDF.Nodes;

namespace DotNetRdfExtensions
{
    public static class DotNetRdfExtensions
    {
        // TODO: Structure all of this rather messy code.
        public static bool ContainsTriple(this IGraph graph, INode subj, INode pred, INode obj) {
            return graph.ContainsTriple(new Triple(subj, pred, obj));
        }

        public static bool IsOwlClass(this INode node) {
            IGraph graph = node.Graph;
            IUriNode rdfType = graph.CreateUriNode(RDF.type);
            IUriNode owlClass = graph.CreateUriNode(OWL.Class);
            return graph.ContainsTriple(node, rdfType, owlClass);
        }

        public static bool IsRdfsClass(this INode node) {
            IGraph graph = node.Graph;
            IUriNode rdfType = graph.CreateUriNode(RDF.type);
            IUriNode rdfsClass = graph.CreateUriNode(RDFS.Class);
            return graph.ContainsTriple(node, rdfType, rdfsClass);
        }

        public static bool IsOwlDeprecated(this INode node) {
            IGraph graph = node.Graph;
            IUriNode owlDeprecated = graph.CreateUriNode(OWL.deprecated);
            return graph.GetTriplesWithSubjectPredicate(node, owlDeprecated).Objects().LiteralNodes().Any(deprecationNode => deprecationNode.AsValuedNode().AsBoolean() == true);
        }

        // TODO: This should probably be fixed to handle URN namespaces properly.
        public static Uri GetNamespace(this IUriNode node)
        {
            if (node.Uri.Fragment.Length > 0)
            {
                return new Uri(node.Uri.GetLeftPart(UriPartial.Path) + "#");
            }
            string nodeUriPath = node.Uri.GetLeftPart(UriPartial.Path);
            if (nodeUriPath.Count(x => x == '/') >= 3)
            {
                string nodeUriBase = nodeUriPath.Substring(0, nodeUriPath.LastIndexOf("/", StringComparison.Ordinal) + 1);
                return new Uri(nodeUriBase);
            }
            throw new UriFormatException($"The Uri {node.Uri} doesn't contain a namespace/local name separator.");
        }

        public static bool IsClass(this INode node) {
            return node.IsRdfsClass() || node.IsOwlClass();
        }

        public static string LocalName(this IUriNode node)
        {
            if (node.Uri.Fragment.Length > 0)
            {
                return node.Uri.Fragment.Trim('#');
            }
            return System.IO.Path.GetFileName(node.Uri.AbsolutePath);
        }

        public static bool IsXsdType(this IUriNode node) {
            return node.Uri.AbsoluteUri.StartsWith(XmlSpecsHelper.NamespaceXmlSchema);
        }

        public static IEnumerable<ILiteralNode> RdfsLabels(this INode node) {
            IUriNode rdfsLabel = node.Graph.CreateUriNode(RDFS.label);
            foreach (Triple t in node.Graph.GetTriplesWithSubjectPredicate(node, rdfsLabel))
            {
                if (t.Object.NodeType == NodeType.Literal) {
                    yield return (ILiteralNode)t.Object;
                }
            }
        }

         public static IEnumerable<ILiteralNode> RdfsComments(this INode node) {
            IUriNode rdfsComment = node.Graph.CreateUriNode(RDFS.comment);
            foreach (Triple t in node.Graph.GetTriplesWithSubjectPredicate(node, rdfsComment))
            {
                if (t.Object.NodeType == NodeType.Literal) {
                    yield return (ILiteralNode)t.Object;
                }
            }
        }

        public static IEnumerable<ILiteralNode> SkosDefinitions(this INode node) {
            IUriNode skosDefinition = node.Graph.CreateUriNode(SKOS.definition);
            foreach (Triple t in node.Graph.GetTriplesWithSubjectPredicate(node, skosDefinition))
            {
                if (t.Object.NodeType == NodeType.Literal) {
                    yield return (ILiteralNode)t.Object;
                }
            }
        }

        public static IEnumerable<IUriNode> PropertiesThroughRdfsDomain(this IUriNode node) {
            IUriNode rdfsDomain = node.Graph.CreateUriNode(RDFS.domain);
            foreach (Triple t in node.Graph.GetTriplesWithPredicateObject(rdfsDomain, node))
            {
                if (t.Subject.NodeType == NodeType.Uri) {
                    yield return (IUriNode)t.Subject;
                }
            }
        }

        public static IEnumerable<IUriNode> TransitiveRdfTypes(this IUriNode node) {
            IEnumerable<IUriNode> directRdfTypes = node.DirectRdfTypes();
            IEnumerable<IUriNode> superClassesOfDirectRdfTypes = directRdfTypes.SelectMany(rdfType => rdfType.SuperClasses());
            return directRdfTypes.Union(superClassesOfDirectRdfTypes);
        }

        public static IEnumerable<IUriNode> DirectRdfTypes(this IUriNode node) {
            IUriNode rdfType = node.Graph.CreateUriNode(RDF.type);
            return node.Graph.GetTriplesWithSubjectPredicate(node, rdfType).Select(trip => trip.Object).UriNodes();
        }

        public static IEnumerable<IUriNode> SuperClasses(this IUriNode node) {
            IEnumerable<IUriNode> directSuperClasses = node.DirectSuperClasses();
                HashSet<IUriNode> allSuperClasses = new HashSet<IUriNode>();
                allSuperClasses.UnionWith(directSuperClasses);
                foreach (IUriNode superClass in directSuperClasses) {
                    allSuperClasses.UnionWith(superClass.SuperClasses());
                }
                return allSuperClasses;
        }

        public static IEnumerable<IUriNode> DirectSuperClasses(this IUriNode node) {
            IUriNode rdfsSubClassOf = node.Graph.CreateUriNode(RDFS.subClassOf);
            foreach (Triple t in node.Graph.GetTriplesWithSubjectPredicate(node, rdfsSubClassOf))
            {
                if (t.Object.NodeType == NodeType.Uri) {
                    yield return (IUriNode)t.Object;
                }
            }
        }

        public static IEnumerable<IUriNode> SubClasses(this IUriNode node) {
            IEnumerable<IUriNode> directSubClasses = node.DirectSubClasses();
                HashSet<IUriNode> allSubClasses = new HashSet<IUriNode>();
                allSubClasses.UnionWith(directSubClasses);
                foreach (IUriNode subClass in directSubClasses) {
                    allSubClasses.UnionWith(subClass.SubClasses());
                }
                return allSubClasses;
        }
        
        public static IEnumerable<INode> RdfTypedMembers(this IUriNode node) {
            IUriNode rdfType = node.Graph.CreateUriNode(RDF.type);
            return node.Graph.GetTriplesWithPredicateObject(rdfType, node).Subjects();
        }

        public static IEnumerable<IUriNode> DirectSubClasses(this IUriNode node) {
            IUriNode rdfsSubClassOf = node.Graph.CreateUriNode(RDFS.subClassOf);
            foreach (Triple t in node.Graph.GetTriplesWithPredicateObject(rdfsSubClassOf, node))
            {
                if (t.Object.NodeType == NodeType.Uri) {
                    yield return (IUriNode)t.Subject;
                }
            }
        }

        public static bool IsObjectProperty(this IUriNode node) {
            return node.TransitiveRdfTypes().Any(rdfType => rdfType.Uri.AbsoluteUri.Equals(OWL.ObjectProperty.AbsoluteUri));
        }

        public static bool IsDataProperty(this IUriNode node) {
            return node.TransitiveRdfTypes().Any(rdfType => rdfType.Uri.AbsoluteUri.Equals(OWL.DatatypeProperty.AbsoluteUri));
        }

        public static IEnumerable<IUriNode> RdfsRanges(this IUriNode node) {
            IUriNode rdfsRange = node.Graph.CreateUriNode(RDFS.range);
            return node.Graph.GetTriplesWithSubjectPredicate(node, rdfsRange).Select(triple => triple.Object).UriNodes();
        }

        public static IEnumerable<INode> Subjects(this IEnumerable<Triple> triples) {
            return triples.Select(triple => triple.Subject);
        }

        public static IEnumerable<INode> Predicates(this IEnumerable<Triple> triples) {
            return triples.Select(triple => triple.Predicate);
        }

        public static IEnumerable<INode> Objects(this IEnumerable<Triple> triples) {
            return triples.Select(triple => triple.Object);
        }

        public static bool IsEnumerationDatatype(this OntologyClass oClass)
        {
            INode oneOf = oClass.Graph.CreateUriNode(OWL.oneOf);
            if (oClass.IsRdfsDatatype()) {
                if (oClass.EquivalentClasses.Count() == 1) {
                    return oClass.EquivalentClasses.Single().GetNodesViaPredicate(oneOf).Count() == 1;
                }
                else
                {
                    return oClass.GetNodesViaPredicate(oneOf).Count() == 1;
                }
            }
            return false;
        }

        public static IEnumerable<INode> AsEnumeration(this OntologyClass oClass)
        {
            INode oneOf = oClass.Graph.CreateUriNode(OWL.oneOf);
            INode list = oClass.EquivalentClasses.Append(oClass).SelectMany(equiv => equiv.GetNodesViaPredicate(oneOf)).First();
            return oClass.Graph.GetListItems(list);
        }

        public static IEnumerable<INode> GetNodesViaPredicate(this OntologyResource resource, INode predicate)
        {
            return resource.Graph.GetTriplesWithSubjectPredicate(resource.Resource, predicate).Objects();
        }

        public static bool IsRdfsDatatype(this OntologyClass oClass)
        {
            return oClass.Types.UriNodes().Any(classType => classType.Uri.AbsoluteUri.Equals(RDFS.Datatype.AbsoluteUri));
        }
    }
}