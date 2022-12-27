using ReverseArchitecture.C4.Core.Abstractions;

namespace ReverseArchitecture.C4.Core.Diagrams
{
    public record Scope<TAbstraction>(IAbstraction Abstraction)
        where TAbstraction : IAbstraction;
}