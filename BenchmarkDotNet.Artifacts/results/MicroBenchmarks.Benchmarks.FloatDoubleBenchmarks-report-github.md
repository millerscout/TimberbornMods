```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22621.4317/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11700K 3.60GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 10.0.201
  [Host]     : .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                 | Mean     | Error   | StdDev  | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------------- |---------:|--------:|--------:|------:|--------:|----------:|------------:|
| FloatOnlyCompare       | 471.9 μs | 5.92 μs | 4.94 μs |  1.00 |    0.01 |         - |          NA |
| FloatToDoublePromotion | 605.0 μs | 6.25 μs | 5.54 μs |  1.28 |    0.02 |         - |          NA |
| PureDoubleCompare      | 596.4 μs | 7.46 μs | 6.97 μs |  1.26 |    0.02 |         - |          NA |
