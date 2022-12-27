# Product Release Roadmap

## Release 1

Objective: Build an application for designing and documenting the architecture using C4 diagram model.

Features:

- C4 model diagram sandbox (system context, container, component, deployment)
    - Create a new diagram  (system context, container, component, deployment)
    + Add new C4 element to the diagram (person, software system, container, component, deployment node)
    + Delete existing  abstractions from the diagram
    + Drang and drop basic abstractions
    + Connect diagram abstractions with relationships
    - Delete existing relationships from the diagram
    - Edit the abstraction info (title, desription, technologies, etc.)
- Export/Import the diagram
    - Export diagram metadata
    - Export diagram as an image
    - Import the diagram from metadata file

Pages is Scope:

- Home Page
- Sandbox Page

## Release 2

Objective: Allow to create, save and share diagrams for collaboration,

Features:

- Profile page
- Manage diagrams
    - Undo/Redo changes
    - Save diagram version
    - Edit diagram details
    - Revert back to previous diagram versions
    - See verion history (username and datetime of version changes) 
- Automatically build a reference collection of project abstractions (people, software systems, containers, components)

Pages is Scope:

- Diagram Page
- Profile Page

## Release 3

Objective: Allow to model multiple projects per account.

Feature:

- Manage projects
    - Create new project with details
    - Edit project details (name for starters)
    - Delete project with all diagrams

Pages in Scope:

- Project List Page
- Project Page

## Release 4

Objective: Automate the scanning of .NET solutions and projects and creation of respective architecture diagrams.

Features:

- Automatic scanning of .NET projects and solutions metadata
- Initial diagram generation based on metadata

List of .NET versions supported:

- .NET 5/6/7
- .NET Core 1.0/2.0/2.1/3.0/3.1

## Release 4.1

Objective: Improve the general usability of the system in terms of managing diagrams.

Features:

- Switch between "files" and "c4 exploration" view
    - Files view shows a list of diagrams and allows to open any straight away.
    - C4 exploration view shows the context diagram stright away and allows you to "zoom into" and "zoom out of" the system by clicking on diagram elements (systems, containers, components)

Pages in Scope:

- Explore Project Page

## Release 5

Objective: Connect to GitHub account to commit generated C4 documentation artifacts.

Features:

- Connect to any GitHub account to automate publishing of artifacts
- Pre-generated GitHub Book for additional documentation details