using DotNetRdfExtensions;
using DotNetRdfExtensions.SHACL;
using VDS.RDF.Shacl;
using Microsoft.Azure.DigitalTwins.Parser;
using Microsoft.Azure.DigitalTwins.Parser.Models;

namespace DTDL2SHACL
{
    public static class TemporaryExtensions
    {
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

        public static IEnumerable<DTPropertyInfo> GetProperties(this DTInterfaceInfo iFace) {
            return iFace.Contents.Where(content => content.Value is DTPropertyInfo && content.Value.DefinedIn == iFace.Id).Select(content => (DTPropertyInfo)content.Value);
        }

        public static IEnumerable<DTRelationshipInfo> GetRelationships(this DTInterfaceInfo iFace) {
            return iFace.Contents.Where(content => content.Value is DTRelationshipInfo && content.Value.DefinedIn == iFace.Id).Select(content => (DTRelationshipInfo)content.Value);
        }

        public static IEnumerable<DTComponentInfo> GetComponents(this DTInterfaceInfo iFace) {
            return iFace.Contents.Where(content => content.Value is DTComponentInfo && content.Value.DefinedIn == iFace.Id).Select(content => (DTComponentInfo)content.Value);
        }
    }
}
