using FluentAssertions;

namespace ReverseArchitecture.C4.Core.Tests.Diagrams.Builders
{
    public class ComponentDiagramBuilderTests
    {
        [Fact]
        public void Build_WithScopeAndElements_ShouldReturnDiagram()
        {
            // Arrange
            var builder = new ComponentDiagramBuilder();

            // Act
            var diagram = builder
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

            // Assert
            diagram.Should().NotBeNull();
            diagram.Scope.Should().NotBeNull();
            diagram.Scope.Abstraction.Should().NotBeNull();
            diagram.Scope.PrimaryElements.Should().NotBeNull();
            diagram.Scope.PrimaryElements.Should().HaveCount(8);
            diagram.SupportingElements.Should().NotBeNull();
            diagram.SupportingElements.Should().HaveCount(2);
            diagram.Relationships.Should().NotBeNull();
            diagram.Relationships.Should().HaveCount(10);
        }
    }
}
