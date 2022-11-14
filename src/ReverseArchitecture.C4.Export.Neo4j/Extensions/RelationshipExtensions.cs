using Neo4j.Driver;
using ReverseArchitecture.C4.Core.Diagrams;

namespace ReverseArchitecture.C4.Export.Neo4j.Extensions
{
    public static class RelationshipExtensions
    {
        public static Query MapToMergeQuery(this Relationship relationship)
        {
            var query = @"MATCH (source { id: $sourceId }), (target { id: $targetId }) MERGE (source)-[:REFERENCE { title: $title, technologies: $technologies }]->(target);";
            var parameters = new
            {
                sourceId = relationship.SourceElementId.ToString(),
                targetId = relationship.TargetElementId.ToString(),
                title = relationship.Title,
                technologies = relationship.Technologies.Select(x => x.Name).ToArray()
            };
            return new Query(query, parameters);
        }
    }
}