using ReverseArchitecture.C4.Core.Abstractions;

namespace ReverseArchitecture.C4.Core.Diagrams
{
    public abstract class DiagramBase<TAbstraction, TPrimary> : IDiagram
        where TAbstraction : IAbstraction
        where TPrimary : IAbstraction
    {
        public DiagramBase()
        {
            Scope = new(default, new());
        }

        public DiagramBase(Scope<TAbstraction, TPrimary> scope)
        {
            Scope = scope ?? throw new ArgumentNullException(nameof(scope));
        }

        public Guid DiagramId { get; } = Guid.NewGuid();

        public Scope<TAbstraction, TPrimary> Scope { get; set; }

        public List<Element> SupportingElements { get; } = new();

        public List<Relationship> Relationships { get; } = new();
    }
}