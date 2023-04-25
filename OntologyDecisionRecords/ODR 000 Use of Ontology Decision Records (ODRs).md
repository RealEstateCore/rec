# ODR 000 Use of Ontology Decision Records (ODRs)

## Context

As RealEstateCore ontology evolves and gains widespread adoption, it is crucial to have a clear and consistent way to capture and communicate the decisions made about it. These decisions affect the structure, relationships, and semantics of the concepts that define RealEstateCore. Therefore, we have decided to adopt Ontology Decision Records (ODRs) as a way to document and share ontology-related decisions.

ODRs are inspired by [Architecture Decision Records (ADRs)](https://github.com/joelparkerhenderson/architecture-decision-record). An ADR is a document that captures important architectural decisions made along with it's context and consequences.

## Decisions

1. We will use ODRs to document all RealEstateCore-related decisions, including the creation, modification, and deprecation of concepts, relationships, and axioms.
1. Each ODR will have a unique identifier that follows the format "ODR NNN title", where NNN is a sequential number.
1. Each ODR will have a clear and concise title that summarizes the decision, e.g., "ODR 001 Naming Conventions".
1. The context section of each ODR will provide a brief description of the problem or opportunity that led to the decision, the stakeholders involved, and any relevant background information.
1. The decisions section of each ODR will describe the options considered, the rationale for the chosen option, and any trade-offs or risks associated with the decision.
1. The consequences section of each ODR will outline the expected impact of the decision on RealEstateCore, the software systems that use it, and any related processes or artifacts.
1. Each ODR will be reviewed and approved by the RealEstateCore community using the pull request (PR) feature.
1. The ODR repository will be maintained in the REC GitHub repository.
1. The ODR repository will be accessible to all RealEstateCore community members
1. We will update ODRs using pull requests to keep the decisions correct with the evolving core ontology. History will be maintained by the repository.
1. We will remove deprecated ODRs using pull requests.

## Consequences

1. The use of ODRs will improve the transparency, traceability, and consistency of RealEstateCore-related decisions.
1. The use of ODRs will facilitate communication and collaboration among RealEstateCore contributors and stakeholders.
1. The use of ODRs will support the evolution and maintenance of RealEstateCore by providing a clear record of past decisions.
1. The use of ODRs will help to avoid duplication of effort and conflicting decisions among RealEstateCore contributors.

In conclusion, we have decided to adopt Ontology Decision Records (ODRs) as a way to capture and communicate RealEstateCore-related decisions. We believe that this approach will improve the transparency, traceability, and consistency of RealEstateCore development and maintenance processes, and will facilitate communication and collaboration among RealEstateCore contributors and stakeholders. We will promote the use of ODRs and provide guidance as needed to ensure their effective adoption by the RealEstateCore community.