namespace ReverseArchitecture.C4.Core.Diagrams.Abstractions
{
    public interface ISupportBuild<TResult>
    {
        TResult Build();
    }
}