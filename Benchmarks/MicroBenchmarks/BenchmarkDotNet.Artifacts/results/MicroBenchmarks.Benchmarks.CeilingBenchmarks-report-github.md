```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22621.4317/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11700K 3.60GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 10.0.201
  [Host]     : .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method            | Mean     | Error   | StdDev  | Ratio | Code Size | Allocated | Alloc Ratio |
|------------------ |---------:|--------:|--------:|------:|----------:|----------:|------------:|
| MathCeilingDouble | 719.7 μs | 3.58 μs | 3.17 μs |  1.00 |      70 B |         - |          NA |
| MathFCeilingFloat | 508.7 μs | 1.25 μs | 1.04 μs |  0.71 |      66 B |         - |          NA |
| FastCeilPositive  | 203.1 μs | 4.03 μs | 4.48 μs |  0.28 |      72 B |         - |          NA |
