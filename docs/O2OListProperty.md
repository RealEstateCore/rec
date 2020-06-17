# Representing lists in OWL -- The o2o:listProperty annotation

RDF graphs, whether expressed as triples, XML/RDF, or JSON-LD, are unordered -- i.e., there is no way
of expressing that, e.g., two members of a data series (`:series :hasMember :member1; :member2`) have some internal ordering and that one 
comes before the other.

The RDF vocabulary [includes head-tail lists](https://www.w3.org/TR/rdf11-mt/#rdf-collections) ([a possibly more intuitive description](https://ontola.io/blog/ordered-data-in-rdf/)). However, such lists 
cannot be used in OWL, as described in [this Stack Overflow response](https://stackoverflow.com/questions/11681662/difference-between-owl-list-and-rdf-list/17353894#17353894):

 >the RDF list vocabulary (rdf:List, rdf:first, and rdf:rest) can't be used in OWL: since RDF lists are used in the serialization of OWL, situations would arise where it would be unclear whether the triples were appearing as part of the data, or as part of the OWL encoding.

There are situations where REC-using systems need to be able to express and use ordered lists, e.g., in the data series example given above. But we cannot express these structures in the ontology itself, and consequently, cannot generate APIs supporting lists.

The solution is a hack: we have implemented a special annotation property, `o2o:listProperty`, with range `xsd:boolean`. When this annotation is set as `true` on any object or data property in REC,  tools that the REC consortium develops and which handles RDF generation or ingestion (e.g., [OWL2OAS](https://dev.realestatecore.io/OWL2OAS/), [the RealEstateCore Platform](https://github.com/RealEstateCore/RealEstateCorePlatform), etc), will parse data linked using this property (i.e., data in the object position of a triple where that property is the predicate) as an `rdf:list` of whatever range the property is set to have.

We are testing whether this approach works, and would be happy to take comments/suggestions.
