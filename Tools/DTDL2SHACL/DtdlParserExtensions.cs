// <copyright file="DtdlParserExtensions.cs" company="RealEstateCore Consortium">
// Copyright (c) RealEstateCore Consortium. All rights reserved.
// </copyright>

namespace DTDL2SHACL
{
    using Microsoft.Azure.DigitalTwins.Parser.Models;

    /// <summary>
    /// Useful extensions for the Microsoft.Azure.DigitalTwins.Parser package.
    /// </summary>
    public static class DtdlParserExtensions
    {
        /// <summary>
        /// Gets all DTDL properties defined on this interface.
        /// </summary>
        /// <param name="iFace">Input interface.</param>
        /// <returns>Set of DTDL properties in the <c>contents</c> block of this interface.</returns>
        public static IEnumerable<DTPropertyInfo> GetProperties(this DTInterfaceInfo iFace)
        {
            return iFace.Contents.Where(content => content.Value is DTPropertyInfo && content.Value.DefinedIn == iFace.Id).Select(content => (DTPropertyInfo)content.Value);
        }

        /// <summary>
        /// Gets all DTDL relationships defined on this interface.
        /// </summary>
        /// <param name="iFace">Input interface.</param>
        /// <returns>Set of DTDL relationships in the <c>contents</c> block of this interface.</returns>
        public static IEnumerable<DTRelationshipInfo> GetRelationships(this DTInterfaceInfo iFace)
        {
            return iFace.Contents.Where(content => content.Value is DTRelationshipInfo && content.Value.DefinedIn == iFace.Id).Select(content => (DTRelationshipInfo)content.Value);
        }

        /// <summary>
        /// Gets all DTDL components defined on this interface.
        /// </summary>
        /// <param name="iFace">Input interface.</param>
        /// <returns>Set of DTDL components in the <c>contents</c> block of this interface.</returns>
        public static IEnumerable<DTComponentInfo> GetComponents(this DTInterfaceInfo iFace)
        {
            return iFace.Contents.Where(content => content.Value is DTComponentInfo && content.Value.DefinedIn == iFace.Id).Select(content => (DTComponentInfo)content.Value);
        }
    }
}
