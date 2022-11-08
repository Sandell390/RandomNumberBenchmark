``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.1098/21H2)
11th Gen Intel Core i5-11300H 3.10GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.401
  [Host]     : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2  [AttachedDebugger]
  DefaultJob : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2


```
|       Method |      Mean |     Error |    StdDev |
|------------- |----------:|----------:|----------:|
|       Random |  1.852 μs | 0.0136 μs | 0.0121 μs |
| CryptoRandom | 56.794 μs | 1.1037 μs | 1.5108 μs |
