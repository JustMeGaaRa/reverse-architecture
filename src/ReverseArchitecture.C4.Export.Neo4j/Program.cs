namespace ReverseArchitecture.C4.Export.Neo4j
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var connection = new Neo4jConnection("neo4j://localhost:8687", "neo4j", "", "");
            var exportService = new Neo4jExportService(new OptionsWrapper<Neo4jConnection>(connection));
        }
    }
}