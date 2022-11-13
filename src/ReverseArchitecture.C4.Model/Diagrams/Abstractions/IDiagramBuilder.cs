using ReverseArchitecture.C4.Core.Abstractions;

namespace ReverseArchitecture.C4.Core.Diagrams.Abstractions
{
    public interface IDiagramBuilder<TPrimary, TScope> :
        ISupportScope<TPrimary, TScope>
        where TPrimary : IAbstraction
        where TScope : IScopeBuilder
    {
    }
}