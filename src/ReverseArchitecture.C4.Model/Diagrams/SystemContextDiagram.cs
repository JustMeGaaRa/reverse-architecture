using ReverseArchitecture.C4.Core.Abstractions;

namespace ReverseArchitecture.C4.Core.Diagrams
{
    /// <summary>
    /// Level 1: System Context diagram.
    /// A System Context diagram is a good starting point for diagramming 
    /// and documenting a software system, allowing you to step back and 
    /// see the big picture. Draw a diagram showing your system as a box in the centre, 
    /// surrounded by its users and the other systems that it interacts with. 
    /// Scope: A single software system. 
    /// Primary elements: The software system in scope. 
    /// Supporting elements: People (e.g. users, actors, roles, or personas) 
    /// and software systems (external dependencies) that are directly 
    /// connected to the software system in scope. Typically these other 
    /// software systems sit outside the scope or boundary of your own software system,
    /// and you don’t have responsibility or ownership of them. 
    /// <see cref="https://c4model.com/#SystemContextDiagram"/>
    /// </summary>
    public class SystemContextDiagram : DiagramBase<SoftwareSystem, SoftwareSystem>
    {
    }
}