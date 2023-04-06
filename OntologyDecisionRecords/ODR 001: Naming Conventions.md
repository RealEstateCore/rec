# ODR 001: Naming Conventions

## Context

With RealEstateCore (REC) 4.0, BrickSchema and REC have merged into a consolidated ontology. This has resulted in a merging of conflicting naming conventions. This document aims to document the preferred naming conventions.

## Decisions

1. We will use the following conventions for REC for all models under the RealEstateCore DTMI `dtmi:org:w3id:rec:*;1`
   - We will use **P**ascal**C**ase for Model names
   - We will use **c**amel**C**ase for property and relationship names

1. We will inherit the naming conventions for BrickSchema for all models under the BrickSchema DTMI `dtmi:org:brickschema:schema:Brick:*;1`
   - BrickSchema uses **S**nake_**C**ase for Model names
   - BrickSchema uses **c**amel**C**ase for property and relationship names

1. We will use "programmer friendly" relationship names. 
   - e.g. Use `(Space)-[geometry]->(Geometry)` instead of `(Space)-[hasGeometry]->(Geometry)`

## Consequences

1. We accept that there are a collision of naming conventions that may cause confusion.
1. We won't introduce major breaking changes by renaming existing models or relationships.