namespace ReverseArchitecture.C4.Core.Diagrams
{
    public interface IDiagram
    {
        /// <summary>
        /// The unique identifier of the diagram instance.
        /// </summary>
        Guid DiagramId { get; }

        /// <summary>
        /// Relationships between elements in the diagram.
        /// </summary>
        List<Relationship> Relationships { get; }
    }
}