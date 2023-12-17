- [Clean Architecture Fundamentals](#clean-architecture-fundamentals)
  - [Architectural Principles](#architectural-principles)
  - [Guiding Design Principles](#guiding-design-principles)
    - [Dependency Inversion](#dependency-inversion)
    - [Clean Architecture Isn't New](#clean-architecture-isnt-new)
    - [Where Should You Use It?](#where-should-you-use-it)
- [Clean Architecture Layers](#clean-architecture-layers)
- [CQRS (Command Query Responsibility Segregation)](#cqrs-command-query-responsibility-segregation)

# Clean Architecture Fundamentals
<img src="/images/Clean_Architecture.png" width='300'>

## Architectural Principles

- Maintaniability
- Testability
- Loose Coupling

## Guiding Design Principles
|Principle|Description|
|---------|-----------|
|Separation of concerns|Clean architecture separates the concerns of the core domain from external dependencies of the system, such as databases and user interfaces.|
|Encapsulation|Focuses on hiding information from the other components in your system and also isolating your components from the influence of the outer components in your system.|
|Dependency inversion|You want to depend on abstractions at compile time and implementations at runtime|
|Explicit dependencies|Your components should be honest about their dependencies that they require to function properly and this in turn improves the stability of your components.|
|Single responsibility|Your components should have one responsibility only and should have one reason to change. This principle promotes granular design of your components and it also improves testability|
|DRY|Focuses on reducing duplication in your code by encapsulating repetitive behaviour|
|Persistence ignorance|This principle is mainly concerned with how you design your domain entities, and you should do it in such a way that it doesn't matter which persistence technology you are using under the hood. So your entities could be persisted in a SQL database, a document database, or a key value store. These decisions should not affect how you are modeling your domain entities|
|Bounded contexts|Coming from DDD, is a conceptual model grouping related entities and behaviors together, and at a bare minimum your application should be a single bounded context, although in some cases you could have more bounded contexts inside of a single application|

### Dependency Inversion
|Description|Image representation|
|:---------:|:------------------:|
|Is an important principle of the clean architecture, and it's important to highlight how the flow of dependencies looks like. So you'll notice from the picture that dependencies flow inwards, meaning that the inner layers define abstractions or interfaces and outer layers implement these interfaces. So what does this mean for the overall architecture? It means that inner layers like the domain layer, do not reference any of the other layers in the clean architecture, while the layer that is one level above it is allowed to reference the layer that is below. So the application layer can reference the domain layer and infrastructure and presentation layers are allowed to reference the application and domain layers, and the layers that are conceptually on the same level of the architecture are allowed to reference each other, such as the infrastructure and representation layers.|<img src="/images/Clean_Architecture_Dependency_Inversion.png"  width="80%">|


### Clean Architecture Isn't New
|Description|Image representation|
|:---------:|:------------------:|
|CA it's an evolution of the domain-centric architecture where you have your core domain encapsulating your main business logic and rules, and then you have the supporting components such as the infrastructure and the presentation layers.|<img src="/images/Domain_Centric.png" width="80%">|

### Where Should You Use It?
- Domain-Driven Design
- Complex business logic
- Highly testable projects
- Want architecture to enforce design policies

# Clean Architecture Layers
|Layer|Description|Image representation|
|:---:|:---------|:------------------:|
|Domain|This layer should encompass your most important enterprise logic and business rules. <ul><li>Entities <li>Value objects</li> <li>Domain events</li> <li>Domain services</li><li>Interfaces</li><li>Exceptions</li><li>Enums</li></ul>|<img src="/images/Clean_Architecture_Domain.png" width="80%">|
|Application|Responsible for orchestrating the domain. Defines the use cases. <ul><li>Business logic</li><li>Application services</li><li>CQRS with MediatR</li></ul>|<img src="/images/Clean_Architecture_Application.png" width="80%">|
|Infrastructure|Responsible for anything that's related to external systems <ul><li>Databases</li><li>Message brokers</li><li>Email providers</li><li>Storage services</li><li>Identity</li><li>System clock</li><li>Implements the interfaces that are defined in the layers below it</li></ul>|<img src="/images/Clean_Architecture_Infrastructure.png" width="80%">|
|Presentation|Acts as the single point of entry into your system <ul><li>Passes along the requests to the layers below</li><li>API endpoints</li><li>Middleware</li><li>DI setup</li></ul>|<img src="/images/Clean_Architecture_Presentation.png" width="80%">|

# CQRS (Command Query Responsibility Segregation)
- Pros:
  - Single responsibility principle
  - Interface segregation principle
  - Decorator pattern
  - Loose coupling
- Cons:
  - Indirection

<img src="/images/CQRS_High_Level.png" alt="CQRS"/>