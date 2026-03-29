```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22621.4317/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11700K 3.60GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 10.0.201
  [Host]     : .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method            | Mean       | Error    | StdDev   | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|------------------ |-----------:|---------:|---------:|------:|--------:|----------:|----------:|------------:|
| MathCeilingDouble | 1,098.5 μs | 15.42 μs | 13.67 μs |  1.00 |    0.02 |      70 B |         - |          NA |
| MathFCeilingFloat |   778.6 μs |  9.89 μs |  8.77 μs |  0.71 |    0.01 |      66 B |         - |          NA |
| FastCeilPositive  |   323.3 μs |  6.29 μs | 10.69 μs |  0.29 |    0.01 |      72 B |         - |          NA |
