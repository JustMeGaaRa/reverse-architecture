using ReverseArchitecture.C4.Core.Abstractions;

namespace ReverseArchitecture.C4.Core.Diagrams.Abstractions
{
    public interface ISupportPrimaryAbstraction<TAbstraction, TScopeBuilder>
        where TAbstraction : IAbstraction
        where TScopeBuilder : IScopeBuilder
    {
        TScopeBuilder AddPrimaryElement(TAbstraction abstraction);
    }
}