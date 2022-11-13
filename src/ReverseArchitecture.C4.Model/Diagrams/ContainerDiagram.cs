using ReverseArchitecture.C4.Core.Abstractions;

namespace ReverseArchitecture.C4.Core.Diagrams
{
    /// <summary>
    /// Level 2: Container diagram.
    /// The Container diagram shows the high-level shape of the software architecture 
    /// and how responsibilities are distributed across it. It also shows the major 
    /// technology choices and how the containers communicate with one another. 
    /// It's a simple, high-level technology focussed diagram that is useful for software 
    /// developers and support/operations staff alike. 
    /// Supporting elements: People and software systems directly connected to the containers. 
    /// <see cref="https://c4model.com/#ContainerDiagram"/>
    /// </summary>
    public class ContainerDiagram : DiagramBase<SoftwareSystem, Container>
    {
    }
}