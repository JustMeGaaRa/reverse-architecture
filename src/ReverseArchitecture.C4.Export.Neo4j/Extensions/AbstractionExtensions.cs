using Neo4j.Driver;
using ReverseArchitecture.C4.Core.Abstractions;

namespace ReverseArchitecture.C4.Export.Neo4j.Extensions
{
    public static class AbstractionExtensions
    {
        public static Query ToMergeQuery(this IAbstraction abstraction)
        {
            return abstraction switch
            {
                Person person => person.ToMergeQuery(),
                SoftwareSystem softwareSystem => softwareSystem.ToMergeQuery(),
                Container container => container.ToMergeQuery(),
                Component component => component.ToMergeQuery(),
                _ => throw new NotImplementedException()
            };
        }

        public static Query ToMergeQuery(this Person abstraction)
        {
            var query = @"MERGE (n: PERSON { id: $id, title: $title, description: $description });";
            var parameters = new
            {
                id = abstraction.Id.ToString(),
                title = abstraction.Title,
                description = abstraction.Description
            };
            return new Query(query, parameters);
        }

        public static Query ToMergeQuery(this SoftwareSystem abstraction)
        {
            var query = @"MERGE (n: SOFTWARE_SYSTEM { id: $id, title: $title, description: $description, technologies: $technologies });";
            var parameters = new
            {
                id = abstraction.Id.ToString(),
                title = abstraction.Title,
                description = abstraction.Description,
                technologies = abstraction.Technologies.Select(x => x.Name).ToArray()
            };
            return new Query(query, parameters);
        }

        public static Query ToMergeQuery(this Container abstraction)
        {
            var query = @"MERGE (n: CONTAINER { id: $id, title: $title, description: $description, technologies: $technologies });";
            var parameters = new
            {
                id = abstraction.Id.ToString(),
                title = abstraction.Title,
                description = abstraction.Description,
                technologies = abstraction.Technologies.Select(x => x.Name).ToArray()
            };
            return new Query(query, parameters);
        }

        public static Query ToMergeQuery(this Component abstraction)
        {
            var query = @"MERGE (n: COMPONENT { id: $id, title: $title, description: $description, technologies: $technologies });";
            var parameters = new
            {
                id = abstraction.Id.ToString(),
                title = abstraction.Title,
                description = abstraction.Description,
                technologies = abstraction.Technologies.Select(x => x.Name).ToArray()
            };
            return new Query(query, parameters);
        }
    }
}