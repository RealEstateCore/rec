using Microsoft.Azure.DigitalTwins.Parser.Models;

namespace DTDL2SHACL
{
    public static class DtdlParserExtensions
    {
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
