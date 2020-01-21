# OWL 2 Punning in RealEstateCore

OWL 2 supports a new modelling feature, *punning*, that the RealEstateCore 
ontology uses as a work-around in cases where evolution of the ontology 
requires that individuals be re-designed as classes, or vice versa.

Punning relaxes the separation between individuals and classes, or between 
individuals and properties. This means that one IRI can be used for two 
different types of constructs simultaneously. However, and crucially, 
under OWL reasoning, the different definitions will be treated as entirely 
different entities, regardless of the fact that they share IRI identifier. 
For a more extensive read on this feature, see the [OWL 2 new features 
documentation](https://www.w3.org/TR/owl2-new-features/#F12:_Punning). 

In RealEstateCore 3.1, this feature was used to deprecate the Room subtype 
hierarchy, in favor of using instances of the new RoomType class instead. 
The subclasses of Room (e.g., https://w3id.org/rec/building/ConferenceRoom), 
were marked as deprecated and new instances of RoomType were defined 
*using those same IRI:s*. This allows the use of as new design, while 
keeping the old definitions around until the next compatibility-breaking 
change (4.0), in line with good semantic versioning practices.

In other words, in REC 3.1 and later, there are two possible ways of 
modelling room types; using the (deprecated but not yet removed) subclasses 
of `core:Room`, or in line with the new design, using instances of `core:Room` 
having the `building:roomType` property set to an instance of 
`building:RoomType`.

**Note** that not all tools handle OWL 2 punning well. Protégé displays 
the annotations on two different definitions separately, e.g., `rdfs:label` 
on a class definition for a given IRI will be different from the `rdfs:label` 
on an individual with that same IRI. However, using the deprecation 
annotation will cause both definitions to appear striked out in the GUI.