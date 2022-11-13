using ReverseArchitecture.C4.Core.Abstractions;
using ReverseArchitecture.C4.Core.Diagrams.Abstractions;

namespace ReverseArchitecture.C4.Core.Diagrams.Builders
{
    public interface IContainerDiagramScopeBuilder :
        IScopeBuilder,
        ISupportPrimaryAbstraction<Container, IContainerDiagramScopeBuilder>,
        ISupportSecondaryAbstraction<SoftwareSystem, IContainerDiagramScopeBuilder>,
        ISupportSecondaryAbstraction<Person, IContainerDiagramScopeBuilder>,
        ISupportRelationship<IContainerDiagramScopeBuilder>,
        ISupportBuild<ContainerDiagram>
    {
    }
}