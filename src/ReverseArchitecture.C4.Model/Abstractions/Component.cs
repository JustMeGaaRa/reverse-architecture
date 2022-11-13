namespace ReverseArchitecture.C4.Core.Abstractions
{
    public class Component : AbstractionWithTechnologies
    {
        public Component(string title, string description, IReadOnlyCollection<Technology> technologies) :
            base(Guid.NewGuid(), AbstractionType.Component, title, description, technologies)
        {
        }

        public Guid ComponentId { get; } = Guid.NewGuid();
    }
}