using ReverseArchitecture.C4.Core.Abstractions;

namespace ReverseArchitecture.C4.Core.Diagrams.Abstractions
{
    public interface ISupportScope<TAbstraction, TScopeBuilder>
        where TAbstraction : IAbstraction
        where TScopeBuilder : IScopeBuilder
    {
        TScopeBuilder WithScope(TAbstraction abstraction);
    }
}