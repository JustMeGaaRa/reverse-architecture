using ReverseArchitecture.C4.Core.Abstractions;
using ReverseArchitecture.C4.Core.Diagrams.Abstractions;

namespace ReverseArchitecture.C4.Core.Diagrams.Builders
{
    public class ContainerDiagramBuilder :
        IDiagramBuilder<SoftwareSystem, IContainerDiagramScopeBuilder>,
        IContainerDiagramScopeBuilder
    {
        private readonly ContainerDiagram _containerDiagram;

        public ContainerDiagramBuilder()
        {
            _containerDiagram = new ContainerDiagram();
        }

        public ContainerDiagramBuilder(ContainerDiagram containerDiagram)
        {
            _containerDiagram = containerDiagram ?? throw new ArgumentNullException(nameof(containerDiagram));
        }

        public ContainerDiagram Build()
        {
            return _containerDiagram;
        }

        public IContainerDiagramScopeBuilder WithScope(SoftwareSystem softwareSystem)
        {
            _containerDiagram.Scope = new(softwareSystem);
            return this;
        }

        public IContainerDiagramScopeBuilder AddPrimaryElement(Container abstraction)
        {
            _containerDiagram.PrimaryElements.Add(abstraction);
            return this;
        }

        public IContainerDiagramScopeBuilder AddSupportingElement(SoftwareSystem softwareSystem)
        {
            _containerDiagram.SupportingElements.Add(new(softwareSystem));
            return this;
        }

        public IContainerDiagramScopeBuilder AddSupportingElement(Person person)
        {
            _containerDiagram.SupportingElements.Add(new(person));
            return this;
        }

        public IContainerDiagramScopeBuilder AddRelationship(Relationship relationship)
        {
            _containerDiagram.Relationships.Add(relationship);
            return this;
        }
    }
}