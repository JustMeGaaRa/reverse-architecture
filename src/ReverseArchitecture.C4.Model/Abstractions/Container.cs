namespace ReverseArchitecture.C4.Core.Abstractions
{
    public sealed class Container : AbstractionWithTechnologies
    {
        public Container(string title, string description, IReadOnlyCollection<Technology> technologies) :
            base(Guid.NewGuid(), AbstractionType.Container, title, description, technologies)
        {
        }

        public Guid ContainerId { get; } = Guid.NewGuid();
    }
}