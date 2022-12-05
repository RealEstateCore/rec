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
    }
}
