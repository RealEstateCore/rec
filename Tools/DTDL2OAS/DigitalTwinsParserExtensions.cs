using Microsoft.Azure.DigitalTwins.Parser.Models;
using System.Collections.Generic;
using System.Linq;

namespace DTDL2OAS
{
    public static class DigitalTwinsParserExtensions
    {
        public static IEnumerable<DTRelationshipInfo> InheritedRelationships(this DTInterfaceInfo iface)
        {
            return iface.Contents.Values
                .Where(content => content is DTRelationshipInfo && content.DefinedIn != iface.Id)
                .Select(content => (DTRelationshipInfo)content);
        }

        public static IEnumerable<DTRelationshipInfo> DirectRelationships(this DTInterfaceInfo iface)
        {
            return iface.Contents.Values
                .Where(content => content is DTRelationshipInfo && content.DefinedIn == iface.Id)
                .Select(content => (DTRelationshipInfo)content);
        }

        public static IEnumerable<DTRelationshipInfo> AllRelationships(this DTInterfaceInfo iface)
        {
            return iface.DirectRelationships().Union(iface.InheritedRelationships());
        }

        public static IEnumerable<DTPropertyInfo> InheritedProperties(this DTInterfaceInfo iface)
        {
            return iface.Contents.Values
                .Where(content => content is DTPropertyInfo && content.DefinedIn != iface.Id)
                .Select(content => (DTPropertyInfo)content);
        }

        public static IEnumerable<DTPropertyInfo> DirectProperties(this DTInterfaceInfo iface)
        {
            return iface.Contents.Values
                .Where(content => content is DTPropertyInfo && content.DefinedIn == iface.Id)
                .Select(content => (DTPropertyInfo)content);
        }

        public static IEnumerable<DTPropertyInfo> AllProperties(this DTInterfaceInfo iface)
        {
            return iface.DirectProperties().Union(iface.InheritedProperties());
        }

        public static IEnumerable<DTComponentInfo> InheritedComponents(this DTInterfaceInfo iface)
        {
            return iface.Contents.Values
                .Where(content => content is DTComponentInfo && content.DefinedIn != iface.Id)
                .Select(content => (DTComponentInfo)content);
        }

        public static IEnumerable<DTComponentInfo> DirectComponents(this DTInterfaceInfo iface)
        {
            return iface.Contents.Values
                .Where(content => content is DTComponentInfo && content.DefinedIn == iface.Id)
                .Select(content => (DTComponentInfo)content);
        }

        public static IEnumerable<DTComponentInfo> AllComponents(this DTInterfaceInfo iface)
        {
            return iface.DirectComponents().Union(iface.InheritedComponents());
        }
    }
}
