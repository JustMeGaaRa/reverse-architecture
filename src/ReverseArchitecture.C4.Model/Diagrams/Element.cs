using ReverseArchitecture.C4.Core.Abstractions;

namespace ReverseArchitecture.C4.Core.Diagrams
{
    public record Element(
        IAbstraction Abstraction)
    {
        public Guid ElementId { get; } = Guid.NewGuid();
    }
}