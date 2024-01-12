# ODR 003 Ontology Versioning

## Context

As the ontology evolves, there is an ongoing need to align the ontology to other standards, reduce collisions, and reduce ambiguity. [Semantic Versioning](https://semver.org/) is a way to communicate to the community the types of changes that are being made to a project. 

Simply renaming or removing a property or relationship would result in a breaking change, resulting in a major version update. Instead, deprecation is preferred as a way to signal to the community that a change will be made in the next major update, and allow time for the community to align to the changes.

DTDL does not provide a consistent way to annotate that a model's contents have been deprecated. As a result, we need a consist way to flag that a model's properties or relationships have been deprecated.

Graph validity will be a test of if a change is a major or minor change. If any hypothetical graph that can be represented before a change is still valid after the change, the change is considered non-breaking from the ontology's perspective. Consider the 2 following examples:

1. **Major Change Example**: A model's relationship is modified that adds a restriction to a relationship's target.
1. **Minor Change Example**: A model's relationship is modified so that the target restrictions are removed.

## Decisions

### Versioning

1. RealEstateCore will follow a versioning scheme of `MAJOR.MINOR`
   - Breaking changes will require a `MAJOR` version update
   - Minor changes will require a `MINOR` version update

1. RealEstateCore defines breaking changes as:
   - Remove deprecated models
   - Remove deprecated model content
   - Remove models (without deprecation)
   - Remove model content (without deprecation)
   - Restricting the target of relationships

1. RealEstateCore defines minor changes as:
   - Adding new models
   - Adding new model content
   - Modifying content descriptions and comments
   - Deprecate model content
   - Broaden the target of relationships

1. RealEstateCore has not released patches in the past. If there is a need for a `PATCH` in the future, this ODR will be updated to reflect decisions about `PATCH` versioning.

1. RealEstateCore will use deprecation to reduce excessive `MAJOR` version increments

1. RealEstateCore will clean up content deprecation during `MAJOR` version increments

### Annotating Deprecation

1. We will append ` (DEPRECATED)` to the content's display name.
   
1. We will append ` (DEPRECATED: <recommendation going forward>.)` to the content's description. This should include a recommendation on how to migrate going forward.

## Consequences

1. Minor version updates could accumulate several deprecations, that could result in confusion in the community on which properties/relationships to use. Each deprecation should clearly notate recommendations.

1. Major version updates should include the removal of the deprecated content.