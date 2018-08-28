using System;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Horology;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

namespace TestBenchmark
{

    public class Config : ManualConfig
    {
        public Config()
        {
            Add(
                Job.Dry
                .With(Platform.X64)
                .With(Jit.RyuJit)
                .With(Runtime.Core)
                .WithMinIterationTime(TimeInterval.FromMicroseconds(100))
                .WithLaunchCount(1));
        }
    }

    [Config(typeof(Config))]
    [MemoryDiagnoser]
    public class Md5VsSha256
    {
        [Params(10, 100, 1000)]
        public int N { get; set; }
        private readonly byte[] data;

        private readonly SHA256 sha256 = SHA256.Create();
        private readonly MD5 md5 = MD5.Create();

        public Md5VsSha256()
        {
            data = new byte[N];
        }

        [Benchmark]
        public void Sha256()
        {
            for(var i = 0; i < N; i++)
            {
                sha256.ComputeHash(data);
            }
        }

        [Benchmark]
        public void Md5()
        {
            for(var i = 0; i < N; i++)
            {
                md5.ComputeHash(data);
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Md5VsSha256>();
        }
    }
}
