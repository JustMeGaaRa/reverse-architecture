namespace ReverseArchitecture.C4.Core.Diagrams.Abstractions
{
    public interface ISupportRelationship<TScopeBuilder>
        where TScopeBuilder : IScopeBuilder
    {
        TScopeBuilder AddRelationship(Relationship relationship);
    }
}