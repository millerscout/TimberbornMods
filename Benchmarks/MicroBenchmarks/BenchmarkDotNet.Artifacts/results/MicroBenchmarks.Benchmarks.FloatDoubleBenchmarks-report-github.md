```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22621.4317/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11700K 3.60GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 10.0.201
  [Host]     : .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                 | Mean     | Error   | StdDev  | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------------- |---------:|--------:|--------:|------:|--------:|----------:|------------:|
| FloatOnlyCompare       | 464.7 μs | 3.60 μs | 3.19 μs |  1.00 |    0.01 |         - |          NA |
| FloatToDoublePromotion | 599.0 μs | 4.01 μs | 3.75 μs |  1.29 |    0.01 |         - |          NA |
| PureDoubleCompare      | 592.5 μs | 8.57 μs | 8.02 μs |  1.27 |    0.02 |         - |          NA |
