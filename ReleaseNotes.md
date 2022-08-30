# RealEstateCore Release Notes

## v4.0 Public Preview -- Brick Schema integration, native DTDL

REC4 is a major rewrite touching many aspects of our definitions, toolchains, formats, etc. This is a preview version for which we are now requesting comments and feedback. General availability of REC4 will be later in the fall 2022.

### RealEstateCore 4 New Features

* We now release RealEstateCore as both SHACL (RDF Shapes Constraint Language) and DTDL (Digital Twin Definition Language) models. 
* We've collaborated with the Brick Schema project to incorporate brick:Point and brick:Equipment, replacing previous REC-specific Capability and Equipment types.
* For better compliance with Brick Schema, we are moving to using the BSD license.
* We include generated documentation for all types directly in the GitHub repo and download.
* There is a new developer site at [https://dev.realestatecore.io](https://dev.realestatecore.io)

### Deprecated features

* The OWL version of REC is deprecated.

### Known issues

The public preview release of REC4 has some known issues that will be addressed by the general availability release of REC4 later this fall. 

* REC4 contains some files whose paths are long enough to cause issues on Windows. If you are using Windows, we recommend checking REC4 out as high up in your folder hierarchy as possible, to avoid this issue (e.g., C:\REC\). We are working on a mitigation strategy involving shortening some longer names.
* The preview version of the REC4 REST API is not JSON-LD compliant. We are working to reconcile a conceptual difference between DTDL and SHACL models, specifically on global or local field declarations, which affect how field names and contexts are generated in the API.
* The edge message schema has not yet been updated for REC4. A REC4-compliant edge message schema will be shipped with the GA release.


## V3.3 -- Assets, Spatial Model, Capability Model, QUDT

Version 3.3 is a major feature release that contains a wealth of new features, some of which are:

* A new Asset module, covering systems and equipment mounted within buildings, at depth. This is based on an interpretation and extension of the Brick Schema ontology, carried out in conjunction with Willow and Microsoft. See also the [DTDL](https://aka.ms/dtdl) version of RealEstateCore in the [Azure Open Digital Twins Buildings repository](https://github.com/Azure/opendigitaltwins-building)&lt;/a&gt;.
* An updated spatial model that clearly differentiates between Building Components and Spaces; where the former make up the building&apos;s structural elements, and the latter make up physical spaces inside (rooms, levels, etc) or outside (regions, land, etc) of a building. This is in line with the W3C LBD BOT ontology.
* A simplified set of topological relations to connect sub- and super-entities within the top-level REC class tree. &quot;isPartOf&quot; and &quot;hasPart&quot; are now defined to operate on entities of the same type, i.e., Spaces have only Spaces as parts, Assets have only Assets as parts, etc. 
* A Capability model based on the BMS notion of Points (as represented in, e.g., Brick Schema) or Affordances (as represented in Web of Things). Subclasses of Capability denote specific sensorsing or actuation capabilities that can be assigned to Spaces, Assets, etc.
* LogicalDevice -- represents a connected entity that pushes data to the cloud, which is typically an instance of a piece of software (e.g., an IoTEdge module, a HomeAssistant install, some proprietary BMS system, etc).
* A partial integration of Quantity Kinds and Units from the established QUDT ontology. We have punned a subset of these units to datatypes in REC, allowing them to be used as ranges of data properties, providing fine-grained semantics for such properties. These units are held in the new Units module.

As a consequence of the above changes, REC 3.3 deprecates many existing core functionalities. In keeping with our semantic versioning policy, entities or axioms from REC 3.2 that are deprecated remain usable and with unchanged semantics until the next compatibility-breaking REC release (4.0).

## V3.2 -- Analytics, Data Schemas, and Sensor Interfaces

Version 3.2 is a feature release that contains:

* The new Analytics module, providing a vocabulary for describing prognoses and aggregates, and the processes used to generate these. This vocabulary is rather generic; we would like to get feedback on it and in particular solicit recommendations on how to model/document anlysis procedures/workflows.
* The new DataSchema module, allowing for much richer description of data schemas on sensor and actuator interfaces, including primitive schemas, object schemas, and array schemas.
* A new SensorInterface class, mirroring the design of the ActuatorInterface class from REC 3.1. This allows you to represent shared aspects of a set of identical sensors (e.g., their data schemas) in a single place, reducing duplication across the knowledge graph. It also simplifies translation of REC graphs into, e.g., MS DTDL or WoT TD.
* The new LFR module, representing the Swedish Real Property Register (Lantmäteriets Fastighetsregister). This module, intended for the Swedish market, is optional and thus not loaded in REC Full by default.
* A new Collections class, intended to represent generic administrative collections of things.
* A new o2o:listProperty annotation, intended to indicate that an OWL object or data property shall be treated as an rdf:List in implementing systems.
* Additional Quantity Kind and Measurement Unit individuals supporting waste management and presence detection use cases.
* New core:timeInterval data property, indicating an ISO 8601 time interval relevant to some entity or event.
* New device:hasSerialNumber and device:hasMACAddress data properties.
* Documentation on our use of OWL punning and ontology design patterns used.
* An official alignment to BOT (Building Topology Ontology).

## V3.1.3 -- Emergency inconcistency hotfix

Version 3.1.3 is a hotfix release that addresses bugs arising from version management in release 3.1.1 and 3.1.2. Several classes and properties from the 3.2 development branch were mistakenly implemented prematurely in 3.1.1 and 3.1.2, causing subtle inconsistencies in the model. Version 3.1.3 reverts all ontology entities to those from version 3.1, while maintaining the REST API specification and edge message examples that were updated since then.

We apologize for providing an inconsistent ontology, and are implementing testing and version management procedures to ensure this does not occur again.

## V3.1.2 -- REST API hotfix

Version 3.1.2 is a bug fix release that addresses two issues in the REST API specification, and one in the edge message format:

* The REC REST API specification now specifies that the payload for POST, PUT, and PATCH operations should be carried in the HTTP request body.
* The REC REST API specification now uses the updated MIME type for JSON-LD: application/ld+json
* The Edge message examples mistakenly carried REC 2 semantics due to previous Git mishap; that is now addressed and the examples are up-to-date

Note that this hotfix does not affect the ontology semantics; aside from version and release node annotations, REC 3.1.2 is identical to REC 3.1.2.

## V3.1.1 -- REST API

Version 3.1.1 is a minor release of REC that contains:

* The official REC REST API (see the api/REST subdirectory)
* O2O annotations used by the OWL2OAS generator when building that API.
* Spelling fixes.

## V3.1 -- Actuation Model

Version 3.1 is a feature release of REC that contains:

* The new Actuation module, with north- and southbound message semantics for enacting actuations on systems.
* Deprecation of the Room (Building module) and Premises (Lease module) type hierarchies, in favour of the RoomType and PremisesType classes, respectively. Named individuals of these classes are punned to the same IRIs as the now-deprecated classes, the latter of which will be removed in an upcoming 4.0 release.
* Documentation on REC recommendations for alignments with owl:sameAs and owl:equivalentClass (outside of ontology, see GitHub repo).
* Initial OWL2OAS annotations (work in progress, see https://github.com/hammar/owl2oas) governing how an OAS API will be generated from the REC OWL files. Will be fully functional by release 3.2.

## V3.0 -- Usability and maintainability refactoring

Version 3.0 is a major and compatibility-breaking refactoring of RealEstateCore. Emphasis in this release is not on development of new features, but rather on improved usability and maintainability in the long run. Changes include:

* All IRI:s are now HTTPS
* Properties have been defined as being (at-most) single-domain and single-range, supporting usability and visualization.
* Meronomy properties have been refactored to allow transitive traversal of the parthood hierarchy from RealEstate all the way down to individual devices using the isPartOf and hasPart superproperties.
  * This has required refactoring of the relations Building <-> BuildingComponent and Device <-> DeviceComponent (the latter is removed).
* Class naming has been simplified (BuildingStructure -> Building, BuildingStructureComponent -> BuildingComponent, etc).
* A (minimal) representation of GeoSPARQL has been integrated, to allow for standardized geospatial representations and querying. REC home-made geospatial/location vocabulary is phased out as a consequence.
* Alignments against other ontologies or standards (BIP, Belok, IPSO, Haystack, fi2xml, IFC) have been broken out into separate alignment files, and now use rdfs:seeAlso annotations.
* Module boundaries have been clarified and three new modules (Lease, Metadata, Agents) have been added, in preparation of anticipated modelling work.
* All entities have been assigned rdfs:labels and the large majority rdfs:comments.
* The modules have been documented with metadata using DC, CC, VANN, cpannotationschema, etc.
* Files have been renamed from .owl to .rdf, to simplify use in tools that expect this ending (e.g., TopBraid).

## 2.3 Actuation model

* Adds Actuation model (classes and properties)
* Extends room types (BuildingStructureComponent)
* Extends comparableCoClass mapping
* Adds example JSON-message
* Adds metrological QuantityKind:s
* Rename class DeviceFunction to DeviceFunctionType
* Extends range for object property serves
* Fixes varios typos

## 2.2 Initial public release

* The initial public release 2018-05-31. Contain the modules: Core, Building and Device.
