namespace ReverseArchitecture.C4.Core.Abstractions
{
    public abstract class AbstractionWithTechnologies : AbstractionBase
    {
        protected AbstractionWithTechnologies(Guid id, AbstractionType blockType, string title, string description, IReadOnlyCollection<Technology> technologies) :
            base(id, blockType, title, description)
        {
            Technologies = technologies;
        }

        public IReadOnlyCollection<Technology> Technologies { get; init; }
    }
}