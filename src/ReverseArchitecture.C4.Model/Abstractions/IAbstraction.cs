namespace ReverseArchitecture.C4.Core.Abstractions
{
    public interface IAbstraction
    {
        Guid Id { get; }

        AbstractionType Type { get; }

        string Title { get; set; }

        string Description { get; set; }
    }
}