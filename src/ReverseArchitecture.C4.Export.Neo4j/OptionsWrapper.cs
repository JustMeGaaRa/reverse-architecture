using Microsoft.Extensions.Options;

namespace ReverseArchitecture.C4.Export.Neo4j
{
    public record OptionsWrapper<T>(T Value) :
        IOptions<T>
        where T : class;
}