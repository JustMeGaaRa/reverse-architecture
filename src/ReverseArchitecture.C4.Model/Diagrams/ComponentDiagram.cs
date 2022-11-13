using ReverseArchitecture.C4.Core.Abstractions;

namespace ReverseArchitecture.C4.Core.Diagrams
{
    /// <summary>
    /// Level 3: Component diagram.
    /// The Component diagram shows how a container is made up of a number of "components", 
    /// what each of those components are, their responsibilities and the technology/implementation details. 
    /// Supporting elements: Containers (within the software system in scope) 
    /// plus people and software systems directly connected to the components. 
    /// <see cref="https://c4model.com/#ComponentDiagram"/>
    /// </summary>
    public class ComponentDiagram : DiagramBase<Container, Component>
    {
    }
}