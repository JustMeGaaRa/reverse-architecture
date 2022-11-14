using ReverseArchitecture.C4.Core.Diagrams;

namespace ReverseArchitecture.C4.Export.Abstractions
{
    public interface ISupportExport<TDiagram>
        where TDiagram : IDiagram
    {
        Task ExportAsync(TDiagram diagram);
    }
}