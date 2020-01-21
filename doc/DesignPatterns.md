# Ontology Design Patterns employed in RealEstateCore

In developing RealEstateCore we have tried to reuse established good 
modelling practices whenever possible. Many such good practices have been 
formalised and documented as [Ontology Design Patterns](http://ontologydesignpatterns.org/wiki/Odp:WhatIsAPattern) 
(ODPs). This document describes RealEstateCore ODP usage principles, and the 
ODPs that have been implemented.

## ODP Usage Principles

We apply [template-based ODP instantiation](https://karlhammar.com/downloads/hammar2017template.pdf); 
i.e., we copy the logical design of the pattern, but we do not copy the 
identifiers given in the canonical representation provided online. Instad, 
we mint new IRIs for pattern constructs, based on the target ontology 
namespace. This is for two reasons:

1. We need to maintain REC stability over time and therefore cannot depend 
on remote references that might not remain resolvable over longer time 
frames. 

2. Not all design patterns have working resolvable IRIs; in order to maintain 
design consistency across the ontology as a whole, we cannot use structures 
based on real IRIs for some parts and cloned structures in other places.

A downside to this design is that it is not immediately obvious from the 
ontology itself which parts that originate in ODPS; this document aims to 
remedy that problem. Also, in the future we may employ [OPLa vocabulary](http://ceur-ws.org/Vol-2043/paper-09.pdf) 
annotations on our ontology constructs to document pattern provenance.

## ODP: Explicit Typing

**Source:** [MODL](https://archive.org/services/purl/purl/modular_ontology_design_library)  
**Instantiations:** Room -> RoomType, Premises -> PremisesType, 
Collection -> CollectionType  
**Comment:** This design pattern suggests that typing can be expressed per 
an object property, rather than using the subsumption hierarchy. The value 
of this design lies in that we enable deployers to create their own types 
by creating new named individuls, without modifying the ontology itself. 
The downside to this design is that a) types cannot be nested (without the 
addition of a new subType property, which is however rather simple) and b) 
that documentation and visualization don't always display named individuals 
as prominently or clearly as OWL classes.

## ODP: Collection/List

**Source:**  http://ontologydesignpatterns.org/wiki/Submissions:List
**Instantiations:**  Collection, List
**Comment:**  The Collection class is included in REC Core; the List class is 
implemented in the Collections module (new since REC 3.2). The design in REC 
is influenced by but not a direct clone of the design pattern in question; 
the intermediate Bag class as suggested in the source pattern is not 
implemented, and `ListItem` from the pattern has been renamed to 
`ListPosition`, to clarify the intended semantics; the actual item itself is 
linked via the `positionOf` property. Additionally, this implementation 
includes a property chain that can be used to infer item membership on a 
`List` via its `ListPosition`.

Note that OWL semantics does not allow us to verify the validity of assertions 
using these list constructs; e.g., there is no easy way to verify that a 
`ListPosition` that has `numericPosition` 3 is in fact the third `ListPosition` 
on a given list; nor to verify that the asserted first or last `ListPosition` 
is in fact first or last.

## ODP: Punning

See the *Punning.md* document in this folder for specifics regarding the 
use of punning in REC.

## ODP: Agents

**Source:** [FOAF](http://xmlns.com/foaf/spec/)  
**Instantiations:** The REC Agents module  
**Comment:** The FOAF (Friend-of-a-Friend) vocabulary is a light-weight RDF 
ontology for representing persons, groups, corporations, and their relations. 
FOAF is very widely applied in practice, so while the semantics are rather 
shallow and in some cases under-defined, we have aligned our Agents module 
with its design. Per this basic design, the top level `Agent` class is 
subdivided into `Person`, `Group`, and `Organizations`; memberships in Groups 
is indicated via the `member` property which has `Agent` as range, allowing 
the construction of groups that have subgroups, etc.