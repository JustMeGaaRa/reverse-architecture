using ReverseArchitecture.C4.Core.Abstractions;

namespace ReverseArchitecture.C4.Core.Diagrams
{
    public record Relationship(
        string Title,
        IReadOnlyCollection<Technology> Technologies,
        Guid SourceElementId,
        Guid TargetElementId);
}
