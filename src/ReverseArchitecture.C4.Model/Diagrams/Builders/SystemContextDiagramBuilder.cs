using ReverseArchitecture.C4.Core.Abstractions;
using ReverseArchitecture.C4.Core.Diagrams.Abstractions;

namespace ReverseArchitecture.C4.Core.Diagrams.Builders
{
    public class SystemContextDiagramBuilder :
        IDiagramBuilder<SoftwareSystem, ISystemContextDiagramScopeBuilder>,
        ISystemContextDiagramScopeBuilder
    {
        private readonly SystemContextDiagram _systemContextDiagram;

        public SystemContextDiagramBuilder()
        {
            _systemContextDiagram = new SystemContextDiagram();
        }

        public SystemContextDiagramBuilder(SystemContextDiagram systemContextDiagram)
        {
            _systemContextDiagram = systemContextDiagram ?? throw new ArgumentNullException(nameof(systemContextDiagram));
        }

        public SystemContextDiagram Build()
        {
            return _systemContextDiagram;
        }

        public ISystemContextDiagramScopeBuilder WithScope(SoftwareSystem softwareSystem)
        {
            _systemContextDiagram.Scope = new(softwareSystem);
            return this;
        }

        public ISystemContextDiagramScopeBuilder AddPrimaryElement(SoftwareSystem abstraction)
        {
            _systemContextDiagram.PrimaryElements.Add(abstraction);
            return this;
        }

        public ISystemContextDiagramScopeBuilder AddSupportingElement(SoftwareSystem softwareSystem)
        {
            _systemContextDiagram.SupportingElements.Add(new(softwareSystem));
            return this;
        }

        public ISystemContextDiagramScopeBuilder AddSupportingElement(Person person)
        {
            _systemContextDiagram.SupportingElements.Add(new(person));
            return this;
        }

        public ISystemContextDiagramScopeBuilder AddRelationship(Relationship relationship)
        {
            _systemContextDiagram.Relationships.Add(relationship);
            return this;
        }
    }
}