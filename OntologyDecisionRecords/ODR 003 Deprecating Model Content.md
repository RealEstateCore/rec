# ODR 003 Deprecating Model Content

## Context

As the ontology evolves, there is an ongoing need to align the ontology to other standards, reduce collisions, and reduce ambiguity. Simply renaming or removing a property or relationship would result in a breaking change, resulting in a major version update. Instead, deprecation is preferred as a way to signal to the community that a change will be made in the next major update, and allow time for the community to align to the changes.

DTDL does not provide a consistent way to annotate that a model's contents have been deprecated. As a result, we need a consist way to flag that a model's properties or relationships have been deprecated.

## Decisions

1. We will append ` (DEPRECATED)` to the content's display name.
   
1. We will append ` (DEPRECATED: <recommendation going forward>.)` to the content's description. This should include a recommendation on how to migrate going forward.

## Consequences

1. Minor version updates could accumulate several deprecations, that could result in confusion in the community on which properties/relationships to use.

1. Major version updates should include the removal of the deprecated content.