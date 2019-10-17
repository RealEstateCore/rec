# Instance alignment across systems

Many of the types of instances that can be expressed using the REC vocabulary will
typically have representations in multiple systems. Examples include sensors or
actuators, rooms, agents, etc.

For aligning instances expressed per the REC vocabulary with identifiers in other
systems, the REC consortium advocates the use of the `owl:sameAs` predicate, against
either URL:s (in the case that the target system provides dereferencable RDF
representations) or against URN:s (in the case of legacy systems that do not provide
such representations). This feature of the OWL language is intended specifically to
denote identity equivalence, and it is therefore particularly suitable to this
application. See the relevant passage in the [OWL 2 specification](https://www.w3.org/TR/2012/REC-owl2-syntax-20121211/#Individual_Equality), and the corresponding passage in the [OWL 2 RDF mapping specification](https://www.w3.org/TR/2012/REC-owl2-mapping-to-rdf-20121211/#Translation_of_Axioms_without_Annotations).

Note that `owl:sameAs` can only be used to align instance level data. For schema
alignment (e.g., class- and property alignment), other predicates exist that
may be useful, including the semantically weak `rdfs:seeAlso` and the stronger
`owl:equivalentClass` and `owl:equivalentProperty`. For the vocabulary alignments
distributed with REC (see the *alignments* folder), `rdfs:seeAlso` is used.

See below for concrete examples on how to apply owl:sameAs.

## Instance alignment against RDF representations

In the case that the system that you are aligning against can already provide RDF
data (either natively or through some mapping mechanism), mapping becomes very simple:

`<https://mysystem.com/IdStructure/MyId> <owl:sameAs> <https://othersystem.com/SomeIdStructure/OtherId>`

Depending on how RDF query and reasoning engines are configured and how the data is
stored, these `owl:sameAs` links might be traversed at runtime automatically.

## Instance alignment against legacy representations

In (probably more common) case that you are integrating against data that is stored
in some legacy system that cannot provide RDF representations, the calling system will
need to implement some own lookup and retrieval components. In this case, we advocate
the use of URN:s with system-specific prefixes (the minting and management of which
are up to the system implementors). For instance:

`<https://mysystem.com/IdStructure/MyId> <owl:sameAs> <urn:mappings:LegacySystemX:SomeIdStructure:OtherId>`

It is important that each such URN that is minted is unique; therefore, we recommend
reusing unique identifiers from the legacy system in question, and prefixing as needed
to ensure no identifier collisions.

The lookup and retrieval component would then be responsible for, at query or analysis
time, to match the portion of the URN that indicates the remote system to some internal
lookup feature; to send a request out to that system using a system-appropriate method
(SQL queries, web service calls, message-passing, etc.) for the data bearing that remote
identifier, to retrieve said data, and to transform it as needed to suit the query or
analysis task in question.
