# RealEstateCore REST API Specification

_This specification defines the first version of the RealEstateCore REST API.  
It comprises a non-normative section where principles for the REST API is described. And a normative section where requirements for being and API to be "RealEstateCore Compliant" are stated._

_Formally, the API is specified via an Open API Specification (formerly Swagger API) generated from the OWL ontology. See [\*\*insert link to OAS .../api/REST/rec-full-v3.1.1.yaml\*\* ]_

_Throughout this specification RealEstateCore may be abbreviated to REC._

_The REC Consortium invites comments and suggestions regarding the specification through GitHub Issues or Gitter._

# Principles

## General

**Principle.** The RealEstateCore Consortium have decided to keep the initial specification quite narrow in its required scope while giving guidance to how the specification may evolve.

**Principle.** The REC Consortium strives to the largest possible extent to adapt to REST API best practices.

Logically an API comprises an information model and a format describing how the API and an application exchanges information.

**Principle.** REC is an ontology and hence it’s the information model for the API. Consequently all service endpoints, filters etc. referring to REC must be named in accordance with REC, that is with REC terms.

**Principle.** REC stems from the semantic web and the format for the API will to the largest possible extent embrace linked data concepts, such as JSON-LD.

**Principle.** The specification will at any given version stipulate the minimum set of requirements an API implementation must support to be deemed “RealEstateCore Compliant” (designated _"must"_).
Additional functionality may be implemented and a mechanism to understanding such addendums are recommended (preferably through discoverability, see also below).

**Principle.** In addition to the minimum set of requirements, the specification comprises optional requirements which must be followed _if chosen to be included_ in an API implementation (designated _"should"_).

![Requirement Diagram](https://raw.github.com/realestatecore/rec/blob/3.1.1/api/REST/REC_API_Requirement_diagram.png)

Furthermore, recommendations are expressed for areas where the REC Consortium considers to add requirements in the future. 

## Releases

**Principle.** The REST API Specification follows the release cycle of REC.

## Security

Authentication and authorization will not be explicitly specified by REC.

However it's recommended for API implementations to authenticate via Oauth2 or OpenID Connect and to use JWT (JSON Web Tokens) as the basis for authorization.

## Discovery

As an API implementation may have additional features and functionality to that which is required in this specification some mechanism for discovery is desirable. The REC Consortium is considering if and when and how to add programmatic discoverability to this specification.

**Principle.** Discoverability is not required. It is however recommended to implement discoverability on ontology level. The OAS (Swagger) implementation by the REC Consortium exposes an endpoint for supported REC modules.

## Service Endpoints

### CRUD operations and HTTP Verbs

**Principle.** Create, Retrieve, Update and Delete operations must be associated with HTTP verbs as follows

- Create HTTP POST
- Retrieve HTTP GET
- Update
  - HTTP PATCH for specific attributes (REC Object and Data Properties)
  - HTTP PUT for full individual
- Delete HTTP DELETE

### Resource paths

**Principle.** Collections of individuals must be requested on a path similar to their REC class. For example `/realestate`. The specification mandates only a subset of REC classes. 

**Principle.** A specific individual must be requested on a path comprising their REC class and identity (iri),
for example `/realestate/<iri>`.

**Principle.** Queries to a root class endpoint (e.g. RealEstateComponent) must return individuals of that class and individuals of its subclasses (e.g. Building).

**Principle.** Queries to a leaf class endpoint (e.g. Building) must return only individuals of that class.

## Requests

### Simple queries

**Principle.** All REC object and data properties should be searchable with traditional query parameters where `?property=value`

**Principle.** Querying with constraints on the value should be implemented with an JSON:API inspired operator based query with the format `property[operator]=value` where operator can take different values such as
`eq` (equal), `gt` (greater than), `gte` (greater than or equal), `lt`, `lte` for numbers and
`contains` and `regex` for substring queries. This format and the list of operators may be specified in the future.

### Time interval queries

For queries on time intervals (time series data, series of data points) it is important to clarify if the endpoints are inclusive or exclusive. That is, if for instance a day is used as an end time shall data points for that day be returned or not?

**Principle.** Using the same operator based query format as above API implementations should use `starting` and `ending` operators to imply inclusion, and `before` and `after` to imply exclusion, and furthermore `latest` may be used as well with value true. This applies to all Time data properties (e.g. hasObservationTime). For example `?hasObservationTime[starting]=2019-02-14`

**Principle.** Time values are serialized according to ISO 8601.

Note, an implementation must decide what absence of a time interval operator is implying. For example, if no `starting` or `after` is requested, while an `end` time is requested, is it then

- every data point up to, or
- from a specific implementation based start date (either relative, e.g. a year back, or absolute, e.g. 2018-01-01)?

**Principle.** Absence of time interval operators is an implementation detail and the REC Consortium doesn't intend to specify this.

### Pagination

**Principle.** Pagination follows Hydra PartialCollectionView

See the [Hydra Core Vocabulary](https://www.hydra-cg.com/spec/latest/core/) for further information. This [example](https://www.hydra-cg.com/spec/latest/core/#example-16-a-hydra-partialcollectionview-splits-a-collection-into-multiple-views) demonstrates use of the hydra:PartialCollectionView.

Hydra is agnostic to exact pagination method, however to keep RealEstateCore APIs consistent across implementations, they must use pagination parameters `page` (0 indexed) and `size`.  

For example `?page=3&size=10` or `?page=0&size=10` for the first page.


### Sorting

**Principle.** Sorting follows JSON:API

Sorting is using a sort query parameter and should allow sorting on all REC properties that are potentially returned plus type and identity (iri). For example `?sort=type`.

### Advanced queries

Existing API implementations already employs more complex queries where paths in the graph of individuals are queried. For instance queries like “all sensors on a building” or “all buildings near a geo location”, etc. The REC Consortium expects in the future to specify advanced query formats.

**Principle.** For now, advanced queries are not required.

However, implementations are encouraged to include path queries (and other complex queries) and share with the REC community.

## Responses

### JSON-LD

**Principle.** Responses are specified as JSON-LD

Specifically this implies use of Hydra Collections as described below as well as

- identity (iri) is always stated as `@id: <iri>`, and
- classes are always stated as `@type: <type>`

### Response formats

**Principle.** Responses are formatted in accordance with Hydra Collection

For requests that return a resource collection (expected to return many individuals) the format is hydra:Collection while for request that returns an individual only (PUT, PATCH, POST) the format is a to just return the requested object.

See the [Hydra Core Vocabulary](https://www.hydra-cg.com/spec/latest/core/) for further information. This [example](https://www.hydra-cg.com/spec/latest/core/#example-15-referencing-related-resources-using-a-hydra-collection) demonstrates use of the hydra:Collection.

### HTTP status codes

**Principle.** Only a few HTTP status codes shall be required. Others may be used.

The minimum viable set of status codes an implementation must comprise:  
- 200 OK, used for successful GET, PUT, PATCH and DELETE
- 201 Created, used for successful POST
- 400 Bad Request, for malformed (unknown) endpoint or query parameters
- 404 Not Found, requested individual(s) does not exist (note queries that returns empty lists responds with 200)
- 500 Internal Server Error

Implementations are furthermore recommended to make use of:  
- 401 Unauthorized, for unauthenticated clients
- 403 Forbidden, for requests to resources the client is not authorized for
- 503 Service Unavailable, for temporary service interruptions (maintenance, overload)

### Errors

**Principle.** Several practices for error handling is emerging. The REC Consortium is following these but have made no decision as of today on which, if any, to require.

Specifically, the REC Consortium is investigating to use the Hydra Status and Error classes.

# Requirements

This section summarizes the formal requirements on an API implementation to be considered "RealEstateCore Compliant".

In case of discrepancies with the principles section above this section prevails.

Requirements are formalized in the table below. The use of SHOULD implies an optional requirement. That is, if implemented the requirement should be followed.

| Domain                | Id   | Directive | Description                                                                                                                                                                                                                                                                                                                  |
| --------------------- | ---- | --------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Service Endpoints** |      |           |
| HTTP Verbs            | E.1  | MUST      | Use `POST` for create, `GET` for retrieve, `DELETE` for delete, `PUT` for update of full individual and `PATCH` for partial update of individual.                                                                                                                                                                            |
| Resource Paths        | E.2  | MUST      | Use the REC class local identifier for collections of individuals or creation of an individual. The REC class is lowercased in the resource path. For example, `/realestate`.                                                                                                                       |
|                       | E.3  | MUST      | Use the REC class plus identity (iri) for individuals. For example, `/realestate/<iri>`.                                                                                                                                                                                                                                         |
|                       | E.4  | MUST      | Implement the following subset of REC classes as a minimum; `ActuationInterface`, `Actuator`, `BuildingComponent`, `Device`, `RealEstate`, `RealEstateComponent`, `Sensor`, and `Storey`.                                                                                                                                    |
| **Requests**          |
| Simple Queries        | RQ.1 | SHOULD      | Implement a basic query parameter format `?<RecProperty>=<value>`for all REC object and data properties.                                                                                                                                                                                                                     |
|                       | RQ.2 | SHOULD    | Implement operators in queries with an extended query format `?<RecProperty>[<operator>]=<value>` where `<operator>` is one of the following; `eq`,`regex` or `contains`. Note `eq` must return same responses as the basic query format (RQ.1)                                                                              |
| Time Interval Queries | RQ.3 | SHOULD    | Implement extended query format for all REC time data properties `?<RecTimeProperty>[<operator>]=<value>` where `<operator>` is one of the following `starting`, `ending`, `before`, `after` or `latest` and `<value>` is a valid JSON datetime serialization (unless the operator is `latest` in which case `true` is used) |
||RQ.4|SHOULD|Serialize time values accroding to ISO 8601|
| Pagination            | RQ.5 | SHOULD    | Support `hydra:PartialCollectionView` in `hydra:Collection` responses.                                                                                                                                                                                                                                                       |
| Sorting               | RQ.6 | SHOULD    | Use query parameter `?sort=<RecClass>\|<id>\|<type>`                                                                                                                                                                                                                                                                         |
| **Responses**         |
| JSON-LD               | RS.1 | MUST      | Respond with JSON-LD formatted documents.                                                                                                                                                                                                                                                                                    |
| Response Formats      | RS.2 | MUST      | Respond with `hydra:Collection` for resource collections and a plain JSON-LD object for individual resources.                                                                                                                                                                                                                |
| Status Codes          | RS.3 | MUST      | Implement support for `200 OK`, `201 Created`, `400 Bad Request`, `404 Not Found` and `500 Internal Server Error`.                                                                                                                                                                                                           |
