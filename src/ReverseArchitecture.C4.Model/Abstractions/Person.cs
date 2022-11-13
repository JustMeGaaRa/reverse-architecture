namespace ReverseArchitecture.C4.Core.Abstractions
{
    public class Person : AbstractionBase
    {
        public Person(string title, string description) :
            base(Guid.NewGuid(), AbstractionType.Person, title, description)
        {
        }

        public Person(Guid id, string title, string description) :
            base(id, AbstractionType.Person, title, description)
        {
        }
    }
}