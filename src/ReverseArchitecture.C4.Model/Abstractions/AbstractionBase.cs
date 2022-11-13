namespace ReverseArchitecture.C4.Core.Abstractions
{
    public abstract class AbstractionBase : IAbstraction
    {
        protected AbstractionBase(Guid id, AbstractionType type, string title, string description)
        {
            Id = id;
            Type = type;
            Title = title;
            Description = description;
        }

        public Guid Id { get; }

        public AbstractionType Type { get; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}