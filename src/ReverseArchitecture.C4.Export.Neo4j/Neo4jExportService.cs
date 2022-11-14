using Microsoft.Extensions.Options;
using Neo4j.Driver;
using ReverseArchitecture.C4.Core.Abstractions;
using ReverseArchitecture.C4.Core.Diagrams;
using ReverseArchitecture.C4.Export.Abstractions;
using ReverseArchitecture.C4.Export.Neo4j.Extensions;

namespace ReverseArchitecture.C4.Export.Neo4j
{
    public class Neo4jExportService :
        IExportSystemContextDiagram,
        IExportContainerDiagram,
        IExportComponentDiagram
    {
        private readonly IOptions<Neo4jConnection> _options;

        public Neo4jExportService(IOptions<Neo4jConnection> options)
        {
            _options = options ?? throw new ArgumentNullException(nameof(options));
        }

        public async Task ExportAsync(SystemContextDiagram diagram)
        {
            var queries = SelectQueries(diagram);
            await ExecuteWriteAsync(queries);
        }

        public async Task ExportAsync(ContainerDiagram diagram)
        {
            var queries = SelectQueries(diagram);
            await ExecuteWriteAsync(queries);
        }

        public async Task ExportAsync(ComponentDiagram diagram)
        {
            var queries = SelectQueries(diagram);
            await ExecuteWriteAsync(queries);
        }

        private async Task ExecuteWriteAsync(IEnumerable<Query> queries)
        {
            var authToken = AuthTokens.Basic(_options.Value.Username, _options.Value.Password);
            using var driver = GraphDatabase.Driver(_options.Value.BoltUrl, authToken);
            using var session = driver.AsyncSession(x => x.WithDatabase(_options.Value.Database));

            await session.ExecuteWriteAsync(async transaction =>
            {
                foreach (var query in queries)
                {
                    await transaction.RunAsync(query);
                }
            });
        }

        private IEnumerable<Query> SelectQueries<TAbstraction, TPrimary>(DiagramBase<TAbstraction, TPrimary> diagram)
            where TAbstraction : IAbstraction
            where TPrimary : IAbstraction
        {
            return new[] { diagram.Scope.Abstraction.ToMergeQuery() }
                .Concat(diagram.Scope.PrimaryElements.Select(x => x.ToMergeQuery()))
                .Concat(diagram.SupportingElements.Select(x => x.Abstraction.ToMergeQuery()))
                .Concat(diagram.Relationships.Select(x => x.MapToMergeQuery()));
        }
    }
}