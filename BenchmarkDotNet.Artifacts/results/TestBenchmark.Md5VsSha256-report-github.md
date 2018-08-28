``` ini

BenchmarkDotNet=v0.11.1, OS=macOS High Sierra 10.13.5 (17F77) [Darwin 17.6.0]
Intel Core i5-4308U CPU 2.80GHz (Haswell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.1.400
  [Host] : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  Dry    : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT

Job=Dry  MinIterationTime=100.0000 us  Jit=RyuJit  
Platform=X64  Runtime=Core  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=1  

```
| Method |    N |     Mean | Error | Allocated |
|------- |----- |---------:|------:|----------:|
| **Sha256** |   **10** | **2.245 ms** |    **NA** |    **1120 B** |
|    Md5 |   10 | 2.937 ms |    NA |     800 B |
| **Sha256** |  **100** | **1.912 ms** |    **NA** |   **11200 B** |
|    Md5 |  100 | 2.230 ms |    NA |    8000 B |
| **Sha256** | **1000** | **2.334 ms** |    **NA** |  **112000 B** |
|    Md5 | 1000 | 2.600 ms |    NA |   80000 B |
