using ReverseArchitecture.C4.Core.Diagrams.Builders;

namespace ReverseArchitecture.C4.Export.Neo4j.Tests
{
    public class Neo4jExportServiceTests
    {
        [Fact]
        public async void Export_SystemContextDiagram_ShouldNotThrowException()
        {
            var builder1 = new SystemContextDiagramBuilder();
            var diagram1 = builder1
                .WithScope(Elements.SoftwareSystems.ReverseArchitecture)
                .AddSupportingElement(Elements.SoftwareSystems.FileSystem)
                .AddSupportingElement(Elements.SoftwareSystems.GitHub)
                .AddSupportingElement(Elements.SoftwareSystems.Neo4j)
                .AddSupportingElement(Elements.People.Architect)
                .AddSupportingElement(Elements.People.Developer)
                .AddRelationship(new(
                    "Sets up automcatic scanning",
                    Elements.EmptyTechnologyList,
                    Elements.People.Architect.Id,
                    Elements.SoftwareSystems.ReverseArchitecture.Id))
                .AddRelationship(new(
                    "Views the documentation",
                    Elements.EmptyTechnologyList,
                    Elements.People.Developer.Id,
                    Elements.SoftwareSystems.ReverseArchitecture.Id))
                .AddRelationship(new(
                    "Scans the project source code",
                    Elements.EmptyTechnologyList,
                    Elements.SoftwareSystems.ReverseArchitecture.Id,
                    Elements.SoftwareSystems.FileSystem.Id))
                .AddRelationship(new(
                    "Connects and commits diagram documentation artifacts",
                    Elements.EmptyTechnologyList,
                    Elements.SoftwareSystems.ReverseArchitecture.Id,
                    Elements.SoftwareSystems.GitHub.Id))
                .AddRelationship(new(
                    "Exports to",
                    Elements.EmptyTechnologyList,
                    Elements.Containers.Api.Id,
                    Elements.SoftwareSystems.Neo4j.Id))
                .Build();

            var connection = new Neo4jConnection("neo4j://localhost:8687", "neo4j", "", "");
            var exportService = new Neo4jExportService(new OptionsWrapper<Neo4jConnection>(connection));
            await exportService.ExportAsync(diagram1);
        }

        [Fact]
        public async void Export_ContainerDiagram_ShouldNotThrowException()
        {
            var builder2 = new ContainerDiagramBuilder();
            var diagram2 = builder2
                .WithScope(Elements.SoftwareSystems.ReverseArchitecture)
                .AddPrimaryElement(Elements.Containers.Api)
                .AddPrimaryElement(Elements.Containers.Application)
                .AddSupportingElement(Elements.SoftwareSystems.FileSystem)
                .AddSupportingElement(Elements.SoftwareSystems.GitHub)
                .AddSupportingElement(Elements.SoftwareSystems.Neo4j)
                .AddSupportingElement(Elements.People.Architect)
                .AddSupportingElement(Elements.People.Developer)
                .AddRelationship(new(
                    "Sets up automcatic scanning",
                    Elements.EmptyTechnologyList,
                    Elements.People.Architect.Id,
                    Elements.Containers.Application.Id))
                .AddRelationship(new(
                    "Views the documentation",
                    Elements.EmptyTechnologyList,
                    Elements.People.Developer.Id,
                    Elements.Containers.Application.Id))
                .AddRelationship(new(
                    "Sends Requests to",
                    Elements.EmptyTechnologyList,
                    Elements.Containers.Application.Id,
                    Elements.Containers.Api.Id))
                .AddRelationship(new(
                    "Scans the project source code",
                    Elements.EmptyTechnologyList,
                    Elements.Containers.Api.Id,
                    Elements.SoftwareSystems.FileSystem.Id))
                .AddRelationship(new(
                    "Connects and commits diagram documentation artifacts",
                    Elements.EmptyTechnologyList,
                    Elements.Containers.Api.Id,
                    Elements.SoftwareSystems.GitHub.Id))
                .AddRelationship(new(
                    "Exports to",
                    Elements.EmptyTechnologyList,
                    Elements.Containers.Api.Id,
                    Elements.SoftwareSystems.Neo4j.Id))
                .Build();

            var connection = new Neo4jConnection("neo4j://localhost:8687", "neo4j", "", "");
            var exportService = new Neo4jExportService(new OptionsWrapper<Neo4jConnection>(connection));
            await exportService.ExportAsync(diagram2);
        }

        [Fact]
        public async void Export_ComponentDiagram_ShouldNotThrowException()
        {
            var builder3 = new ComponentDiagramBuilder();
            var diagram3 = builder3
                .WithScope(Elements.Containers.Api)
                .AddPrimaryElement(Elements.Components.Core)
                .AddPrimaryElement(Elements.Components.AnalyzerAbstractions)
                .AddPrimaryElement(Elements.Components.AnalyzerNET)
                .AddPrimaryElement(Elements.Components.AnalyzerServices)
                .AddPrimaryElement(Elements.Components.AnalyzerApi)
                .AddPrimaryElement(Elements.Components.ExportNeo4j)
                .AddPrimaryElement(Elements.Components.ExportServices)
                .AddPrimaryElement(Elements.Components.ExportApi)
                .AddSupportingElement(Elements.Containers.Application)
                .AddSupportingElement(Elements.SoftwareSystems.Neo4j)
                .AddRelationship(new(
                    "Sends Requests to",
                    Elements.EmptyTechnologyList,
                    Elements.Containers.Application.Id,
                    Elements.Components.AnalyzerApi.Id))
                .AddRelationship(new(
                    "References",
                    Elements.EmptyTechnologyList,
                    Elements.Components.AnalyzerApi.Id,
                    Elements.Components.AnalyzerServices.Id))
                .AddRelationship(new(
                    "References",
                    Elements.EmptyTechnologyList,
                    Elements.Components.AnalyzerServices.Id,
                    Elements.Components.AnalyzerNET.Id))
                .AddRelationship(new(
                    "References",
                    Elements.EmptyTechnologyList,
                    Elements.Components.AnalyzerNET.Id,
                    Elements.Components.AnalyzerAbstractions.Id))
                .AddRelationship(new(
                    "References",
                    Elements.EmptyTechnologyList,
                    Elements.Components.AnalyzerAbstractions.Id,
                    Elements.Components.Core.Id))
                .AddRelationship(new(
                    "Sends Requests to",
                    Elements.EmptyTechnologyList,
                    Elements.Containers.Application.Id,
                    Elements.Components.ExportApi.Id))
                .AddRelationship(new(
                    "References",
                    Elements.EmptyTechnologyList,
                    Elements.Components.ExportApi.Id,
                    Elements.Components.ExportServices.Id))
                .AddRelationship(new(
                    "References",
                    Elements.EmptyTechnologyList,
                    Elements.Components.ExportServices.Id,
                    Elements.Components.ExportNeo4j.Id))
                .AddRelationship(new(
                    "References",
                    Elements.EmptyTechnologyList,
                    Elements.Components.ExportNeo4j.Id,
                    Elements.Components.Core.Id))
                .AddRelationship(new(
                    "Exports to",
                    Elements.EmptyTechnologyList,
                    Elements.Components.ExportNeo4j.Id,
                    Elements.SoftwareSystems.Neo4j.Id))
                .Build();

            var connection = new Neo4jConnection("neo4j://localhost:8687", "neo4j", "", "");
            var exportService = new Neo4jExportService(new OptionsWrapper<Neo4jConnection>(connection));
            await exportService.ExportAsync(diagram3);
        }
    }
}