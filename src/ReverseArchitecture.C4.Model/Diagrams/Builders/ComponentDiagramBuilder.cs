using ReverseArchitecture.C4.Core.Abstractions;
using ReverseArchitecture.C4.Core.Diagrams.Abstractions;

namespace ReverseArchitecture.C4.Core.Diagrams.Builders
{
    public class ComponentDiagramBuilder :
        IDiagramBuilder<Container, IComponentDiagramScopeBuilder>,
        IComponentDiagramScopeBuilder
    {
        private readonly ComponentDiagram _componentDiagram;

        public ComponentDiagramBuilder()
        {
            _componentDiagram = new ComponentDiagram();
        }

        public ComponentDiagramBuilder(ComponentDiagram componentDiagram)
        {
            _componentDiagram = componentDiagram ?? throw new ArgumentNullException(nameof(componentDiagram));
        }

        public ComponentDiagram Build()
        {
            return _componentDiagram;
        }

        public IComponentDiagramScopeBuilder WithScope(Container container)
        {
            _componentDiagram.Scope = new(container, new());
            return this;
        }

        public IComponentDiagramScopeBuilder AddPrimaryElement(Component abstraction)
        {
            _componentDiagram.Scope.PrimaryElements.Add(abstraction);
            return this;
        }

        public IComponentDiagramScopeBuilder AddSupportingElement(SoftwareSystem softwareSystem)
        {
            _componentDiagram.SupportingElements.Add(new(softwareSystem));
            return this;
        }

        public IComponentDiagramScopeBuilder AddSupportingElement(Container container)
        {
            _componentDiagram.SupportingElements.Add(new(container));
            return this;
        }

        public IComponentDiagramScopeBuilder AddSupportingElement(Person person)
        {
            _componentDiagram.SupportingElements.Add(new(person));
            return this;
        }

        public IComponentDiagramScopeBuilder AddRelationship(Relationship relationship)
        {
            _componentDiagram.Relationships.Add(relationship);
            return this;
        }
    }
}