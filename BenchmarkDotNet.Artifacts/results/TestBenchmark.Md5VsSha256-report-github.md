``` ini

BenchmarkDotNet=v0.11.1, OS=macOS High Sierra 10.13.5 (17F77) [Darwin 17.6.0]
Intel Core i5-4308U CPU 2.80GHz (Haswell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.1.400
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


```
| Method |     Mean |     Error |    StdDev |   Median |
|------- |---------:|----------:|----------:|---------:|
| Sha256 | 46.96 us | 3.6894 us | 10.586 us | 42.45 us |
|    Md5 | 29.24 us | 0.7312 us |  2.014 us | 28.80 us |
