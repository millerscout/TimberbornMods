```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22621.4317/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11700K 3.60GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 10.0.201
  [Host]     : .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method            | Mean     | Error   | StdDev   | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|------------------ |---------:|--------:|---------:|------:|--------:|----------:|----------:|------------:|
| MathCeilingDouble | 734.6 μs | 6.10 μs |  5.70 μs |  1.00 |    0.01 |      70 B |         - |          NA |
| MathFCeilingFloat | 518.5 μs | 2.93 μs |  2.60 μs |  0.71 |    0.01 |      66 B |         - |          NA |
| FastCeilPositive  | 244.6 μs | 4.87 μs | 14.28 μs |  0.33 |    0.02 |      72 B |         - |          NA |
