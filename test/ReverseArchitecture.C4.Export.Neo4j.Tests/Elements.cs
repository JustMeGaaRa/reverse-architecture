using ReverseArchitecture.C4.Core.Abstractions;

namespace ReverseArchitecture.C4.Export.Neo4j.Tests
{
    public static class Elements
    {
        public static class People
        {
            public static Person Architect = new Person("Architect", string.Empty);
            public static Person Developer = new("Developer", string.Empty);
        }

        public static class SoftwareSystems
        {
            public static SoftwareSystem FileSystem = new("Hosting OS File System", string.Empty, EmptyTechnologyList, true);
            public static SoftwareSystem GitHub = new("GitHub", string.Empty, EmptyTechnologyList, true);
            public static SoftwareSystem Neo4j = new("Neo4j Graph Database", string.Empty, EmptyTechnologyList, true);
            public static SoftwareSystem ReverseArchitecture = new("Reverse Architecture in C4", string.Empty, EmptyTechnologyList, false);
        }

        public static class Containers
        {
            public static Container Api = new("ReverseArchitecture C4 Api", string.Empty, EmptyTechnologyList);
            public static Container Application = new("ReverseArchitecture C4 App", string.Empty, EmptyTechnologyList);
        }

        public static class Components
        {
            public static Component Core = new("ReverseArchitecture.C4.Core", string.Empty, EmptyTechnologyList);
            public static Component AnalyzerAbstractions = new("ReverseArchitecture.C4.Analyzer.Absractions", string.Empty, EmptyTechnologyList);
            public static Component AnalyzerNET = new("ReverseArchitecture.C4.Anayzer.CSharpProjects", string.Empty, EmptyTechnologyList);
            public static Component AnalyzerServices = new("ReverseArchitecture.C4.Anayzer.Services", string.Empty, EmptyTechnologyList);
            public static Component AnalyzerApi = new("ReverseArchitecture.C4.Anayzer.Api", string.Empty, EmptyTechnologyList);
            public static Component ExportNeo4j = new("ReverseArchitecture.C4.Export.Neo4j", string.Empty, EmptyTechnologyList);
            public static Component ExportServices = new("ReverseArchitecture.C4.Export.Services", string.Empty, EmptyTechnologyList);
            public static Component ExportApi = new("ReverseArchitecture.C4.Export.Api", string.Empty, EmptyTechnologyList);
        }

        public static IReadOnlyCollection<Technology> EmptyTechnologyList = Enumerable.Empty<Technology>().ToArray();
    }
}
