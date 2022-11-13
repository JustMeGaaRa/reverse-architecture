using FluentAssertions;

namespace ReverseArchitecture.C4.Core.Tests.Diagrams.Builders
{
    public class SystemContextDiagramBuilderTests
    {
        [Fact]
        public void Build_WithScopeAndElements_ShouldReturnDiagram()
        {
            // Arrange
            var builder = new SystemContextDiagramBuilder();

            // Act
            var diagram = builder
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

            // Assert
            diagram.Should().NotBeNull();
            diagram.Scope.Should().NotBeNull();
            diagram.Scope.Abstraction.Should().NotBeNull();
            diagram.Scope.PrimaryElements.Should().NotBeNull();
            diagram.Scope.PrimaryElements.Should().BeEmpty();
            diagram.SupportingElements.Should().NotBeNull();
            diagram.SupportingElements.Should().HaveCount(5);
            diagram.Relationships.Should().NotBeNull();
            diagram.Relationships.Should().HaveCount(5);
        }
    }
}
