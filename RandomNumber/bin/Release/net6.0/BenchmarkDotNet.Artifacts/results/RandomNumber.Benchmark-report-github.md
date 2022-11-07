``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.1098/21H2)
11th Gen Intel Core i5-11300H 3.10GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.401
  [Host]     : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2


```
|       Method |        Mean |     Error |    StdDev |
|------------- |------------:|----------:|----------:|
|       Random |    768.4 ns |  13.01 ns |  12.17 ns |
| CryptoRandom | 21,746.3 ns | 240.71 ns | 187.93 ns |