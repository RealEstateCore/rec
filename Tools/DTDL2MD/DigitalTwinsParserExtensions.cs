﻿using Microsoft.Azure.DigitalTwins.Parser;
using Microsoft.Azure.DigitalTwins.Parser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTDL2MD
{
    public static class DigitalTwinsParserExtensions
    {
        public static IEnumerable<DTInterfaceInfo> ChildrenOf(this IReadOnlyDictionary<Dtmi, DTEntityInfo> ontology, DTInterfaceInfo iface)
        {
            IEnumerable<DTInterfaceInfo> allInterfaces = ontology.Values.Where(entity => entity is DTInterfaceInfo).Select(entity => (DTInterfaceInfo)entity);
            return allInterfaces.Where(childInterface => childInterface.Extends.Contains(iface)).OrderBy(childInterface => childInterface.Id);
        }

        public static IEnumerable<DTRelationshipInfo> UntargetedRelationships(this IReadOnlyDictionary<Dtmi, DTEntityInfo> ontology)
        {
            IEnumerable<DTRelationshipInfo> allRelationships = ontology.Values.Where(entity => entity is DTRelationshipInfo).Select(entity => (DTRelationshipInfo)entity);
            return allRelationships.Where(relationship => relationship.Target == null);
        }

        public static IEnumerable<DTRelationshipInfo> RelationshipsTargeting(this IReadOnlyDictionary<Dtmi, DTEntityInfo> ontology, Dtmi target)
        {
            IEnumerable<DTRelationshipInfo> allRelationships = ontology.Values.Where(entity => entity is DTRelationshipInfo).Select(entity => (DTRelationshipInfo)entity);
            return allRelationships.Where(relationship => relationship.Target == target).OrderBy(relationship => relationship.DefinedIn).ThenBy(relationship => relationship.Name);
        }

        public static IEnumerable<DTRelationshipInfo> RelationshipsTargeting(this IReadOnlyDictionary<Dtmi, DTEntityInfo> ontology, IEnumerable<Dtmi> targets)
        {
            IEnumerable<DTRelationshipInfo> allRelationships = ontology.Values.Where(entity => entity is DTRelationshipInfo).Select(entity => (DTRelationshipInfo)entity);
            return allRelationships.Where(relationship => targets.Contains(relationship.Target)).OrderBy(relationship => relationship.DefinedIn).ThenBy(relationship => relationship.Name);
        }

        public static IEnumerable<DTRelationshipInfo> InheritedRelationships(this DTInterfaceInfo iface)
        {
            return iface.Contents.Values
                .Where(content => content is DTRelationshipInfo && content.DefinedIn != iface.Id)
                .Select(content => (DTRelationshipInfo)content)
                .OrderBy(relationship => relationship.DefinedIn)
                .ThenBy(relationship => relationship.Name);
        }
        public static IEnumerable<DTRelationshipInfo> DirectRelationships(this DTInterfaceInfo iface)
        {
            return iface.Contents.Values
                .Where(content => content is DTRelationshipInfo && content.DefinedIn == iface.Id)
                .Select(content => (DTRelationshipInfo)content)
                .OrderBy(relationship => relationship.Name);
        }

        public static IEnumerable<DTRelationshipInfo> AllRelationships(this DTInterfaceInfo iface)  
        {
            return iface.Contents.Values
                .Where(content => content is DTRelationshipInfo)
                .Select(content => (DTRelationshipInfo)content)
                .OrderBy(relationship => relationship.Name);
        }

        public static IEnumerable<DTPropertyInfo> InheritedProperties(this DTInterfaceInfo iface)
        {
            return iface.Contents.Values
                .Where(content => content is DTPropertyInfo && content.DefinedIn != iface.Id)
                .Select(content => (DTPropertyInfo)content)
                .OrderBy(property => property.DefinedIn)
                .ThenBy(property => property.Name);
        }

        public static IEnumerable<DTPropertyInfo> DirectProperties(this DTInterfaceInfo iface)
        {
            return iface.Contents.Values
                .Where(content => content is DTPropertyInfo && content.DefinedIn == iface.Id)
                .Select(content => (DTPropertyInfo)content)
                .OrderBy(property => property.Name);
        }

        public static IEnumerable<DTPropertyInfo> AllProperties(this DTInterfaceInfo iface)
        {
            return iface.Contents.Values
                .Where(content => content is DTPropertyInfo)
                .Select(content => (DTPropertyInfo)content)
                .OrderBy(property => property.Name);
        }

        public static IEnumerable<DTTelemetryInfo> InheritedTelemetries(this DTInterfaceInfo iface)
        {
            return iface.Contents.Values
                .Where(content => content is DTTelemetryInfo && content.DefinedIn != iface.Id)
                .Select(content => (DTTelemetryInfo)content)
                .OrderBy(telemetry => telemetry.DefinedIn)
                .ThenBy(telemetry => telemetry.Name);
        }
        public static IEnumerable<DTTelemetryInfo> DirectTelemetries(this DTInterfaceInfo iface)
        {
            return iface.Contents.Values
                .Where(content => content is DTTelemetryInfo && content.DefinedIn == iface.Id)
                .Select(content => (DTTelemetryInfo)content)
                .OrderBy(telemetry => telemetry.Name);
        }

        public static IEnumerable<DTTelemetryInfo> AllTelemetries(this DTInterfaceInfo iface)
        {
            return iface.Contents.Values
                .Where(content => content is DTTelemetryInfo)
                .Select(content => (DTTelemetryInfo)content)
                .OrderBy(telemetry => telemetry.Name);
        }

        public static IEnumerable<DTCommandInfo> InheritedCommands(this DTInterfaceInfo iface)
        {
            return iface.Contents.Values
                .Where(content => content is DTCommandInfo && content.DefinedIn != iface.Id)
                .Select(content => (DTCommandInfo)content)
                .OrderBy(command => command.DefinedIn)
                .ThenBy(command => command.Name);
        }
        public static IEnumerable<DTCommandInfo> DirectCommands(this DTInterfaceInfo iface)
        {
            return iface.Contents.Values
                .Where(content => content is DTCommandInfo && content.DefinedIn == iface.Id)
                .Select(content => (DTCommandInfo)content)
                .OrderBy(command => command.Name);
        }

        public static IEnumerable<DTCommandInfo> AllCommands(this DTInterfaceInfo iface)
        {
            return iface.Contents.Values
                .Where(content => content is DTCommandInfo)
                .Select(content => (DTCommandInfo)content)
                .OrderBy(command => command.Name);
        }

        public static IEnumerable<DTComponentInfo> InheritedComponents(this DTInterfaceInfo iface)
        {
            return iface.Contents.Values
                .Where(content => content is DTComponentInfo && content.DefinedIn != iface.Id)
                .Select(content => (DTComponentInfo)content)
                .OrderBy(component => component.DefinedIn)
                .ThenBy(component => component.Name);
        }
        public static IEnumerable<DTComponentInfo> DirectComponents(this DTInterfaceInfo iface)
        {
            return iface.Contents.Values
                .Where(content => content is DTComponentInfo && content.DefinedIn == iface.Id)
                .Select(content => (DTComponentInfo)content)
                .OrderBy(component => component.Name);
        }

        public static IEnumerable<DTComponentInfo> AllComponents(this DTInterfaceInfo iface)
        {
            return iface.Contents.Values
                .Where(content => content is DTComponentInfo)
                .Select(content => (DTComponentInfo)content)
                .OrderBy(component => component.Name);
        }

        public static IEnumerable<DTInterfaceInfo> AllParents(this DTInterfaceInfo iface)
        {
            foreach (DTInterfaceInfo parent in iface.Extends.OrderBy(parent => parent.Id))
            {
                yield return parent;
                foreach (DTInterfaceInfo ancestor in parent.AllParents())
                {
                    yield return ancestor;
                }
            }
        }
    }
}
