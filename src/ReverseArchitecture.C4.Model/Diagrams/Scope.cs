using ReverseArchitecture.C4.Core.Abstractions;

namespace ReverseArchitecture.C4.Core.Diagrams
{
    public record Scope<TAbstraction, TPrimary>(
            IAbstraction Abstraction,
            List<TPrimary> PrimaryElements)
        where TAbstraction : IAbstraction
        where TPrimary : IAbstraction;
}