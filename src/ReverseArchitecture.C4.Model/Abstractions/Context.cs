namespace ReverseArchitecture.C4.Core.Abstractions
{
    public class Context
    {
        public Context()
        {
        }

        public Context(
            IEnumerable<Person> people,
            IEnumerable<SoftwareSystem> softwareSystems,
            IEnumerable<Container> containers,
            IEnumerable<Component> components)
        {
            People = people.ToList();
            SoftwareSystems = softwareSystems.ToList();
            Containers = containers.ToList();
            Components = components.ToList();
        }

        public List<Person> People { get; } = new();

        public List<SoftwareSystem> SoftwareSystems { get; } = new();

        public List<Container> Containers { get; } = new();

        public List<Component> Components { get; } = new();
    }
}
