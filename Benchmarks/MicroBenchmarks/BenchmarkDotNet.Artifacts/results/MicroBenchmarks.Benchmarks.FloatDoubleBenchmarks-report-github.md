```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22621.4317/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11700K 3.60GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 10.0.201
  [Host]     : .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                 | Mean     | Error   | StdDev  | Ratio | Allocated | Alloc Ratio |
|----------------------- |---------:|--------:|--------:|------:|----------:|------------:|
| FloatOnlyCompare       | 479.6 μs | 3.24 μs | 2.87 μs |  1.00 |         - |          NA |
| FloatToDoublePromotion | 615.5 μs | 4.17 μs | 3.49 μs |  1.28 |         - |          NA |
| PureDoubleCompare      | 611.3 μs | 5.58 μs | 4.95 μs |  1.27 |         - |          NA |
