```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22621.4317/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11700K 3.60GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 10.0.201
  [Host]     : .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method            | Mean       | Error    | StdDev   | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|------------------ |-----------:|---------:|---------:|------:|--------:|----------:|----------:|------------:|
| MathCeilingDouble | 1,113.4 μs | 14.21 μs | 13.30 μs |  1.00 |    0.02 |      70 B |         - |          NA |
| MathFCeilingFloat |   788.1 μs |  5.41 μs |  4.52 μs |  0.71 |    0.01 |      66 B |         - |          NA |
| FastCeilPositive  |   328.5 μs |  6.43 μs |  9.43 μs |  0.30 |    0.01 |      72 B |         - |          NA |
