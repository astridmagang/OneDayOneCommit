using BenchmarkDotNet.Attributes;
using CaseNamingPolicy.Moduls.Json;

namespace Benchmark
{
    [RankColumn, MemoryDiagnoser]
    [SimpleJob(launchCount: 1, warmupCount: 1, iterationCount: 10)]
    public class BenchmarkJsonSnakeCaseNamingPolicy
    {
        private readonly SnakeCaseNamingPolicy _snakeCaseNamingPolicy = new SnakeCaseNamingPolicy();

        [Benchmark(Description = "Set value null")]
        public string BenchmarkConvertNameNull() => _snakeCaseNamingPolicy.ConvertName(null);

        [Benchmark(Description = "Set value A")]
        public string BenchmarkConvertNameA() => _snakeCaseNamingPolicy.ConvertName("A");

        [Benchmark(Description = "Set value Aa")]
        public string BenchmarkConvertNameAa() => _snakeCaseNamingPolicy.ConvertName("Aa");

        [Benchmark(Description = "Set value AA")]
        public string BenchmarkConvertNameAA() => _snakeCaseNamingPolicy.ConvertName("AA");

        [Benchmark(Description = "Set value AAa")]
        public string BenchmarkConvertNameAAa() => _snakeCaseNamingPolicy.ConvertName("AAa");

        [Benchmark(Description = "Set value AaA")]
        public string BenchmarkConvertNameAaA() => _snakeCaseNamingPolicy.ConvertName("AaA");
    }
}