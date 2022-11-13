using ReverseArchitecture.C4.Core.Abstractions;
using ReverseArchitecture.C4.Core.Diagrams.Abstractions;

namespace ReverseArchitecture.C4.Core.Diagrams.Builders
{
    public interface ISystemContextDiagramScopeBuilder :
        IScopeBuilder,
        ISupportSecondaryAbstraction<SoftwareSystem, ISystemContextDiagramScopeBuilder>,
        ISupportSecondaryAbstraction<Person, ISystemContextDiagramScopeBuilder>,
        ISupportRelationship<ISystemContextDiagramScopeBuilder>,
        ISupportBuild<SystemContextDiagram>
    {
    }
}