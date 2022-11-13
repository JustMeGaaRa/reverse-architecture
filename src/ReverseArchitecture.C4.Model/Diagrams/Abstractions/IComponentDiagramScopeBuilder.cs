using ReverseArchitecture.C4.Core.Abstractions;
using ReverseArchitecture.C4.Core.Diagrams.Abstractions;

namespace ReverseArchitecture.C4.Core.Diagrams.Builders
{
    public interface IComponentDiagramScopeBuilder :
        IScopeBuilder,
        ISupportPrimaryAbstraction<Component, IComponentDiagramScopeBuilder>,
        ISupportSecondaryAbstraction<SoftwareSystem, IComponentDiagramScopeBuilder>,
        ISupportSecondaryAbstraction<Container, IComponentDiagramScopeBuilder>,
        ISupportSecondaryAbstraction<Person, IComponentDiagramScopeBuilder>,
        ISupportRelationship<IComponentDiagramScopeBuilder>,
        ISupportBuild<ComponentDiagram>
    {
    }
}