namespace ReverseArchitecture.C4.Core.Abstractions
{
    public sealed class SoftwareSystem : AbstractionWithTechnologies
    {
        public SoftwareSystem(string title, string description, IReadOnlyCollection<Technology> technologies, bool isExternal) :
            base(Guid.NewGuid(), AbstractionType.SoftwareSystem, title, description, technologies)
        {
            IsExternal = isExternal;
        }

        public Guid SoftwareSystemId { get; } = Guid.NewGuid();

        public bool IsExternal { get; set; }
    }
}