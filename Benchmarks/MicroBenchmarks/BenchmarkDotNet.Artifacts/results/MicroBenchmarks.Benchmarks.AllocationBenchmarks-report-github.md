```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22621.4317/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11700K 3.60GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 10.0.201
  [Host]     : .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                | Mean       | Error     | StdDev    | Median     | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|---------------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|----------:|------------:|
| NewListEachRow        | 2,314.2 ns | 105.52 ns | 306.13 ns | 2,224.7 ns |  1.02 |    0.18 | 1.3466 |   11264 B |        1.00 |
| ThreadLocalPooledList | 1,081.4 ns |   5.33 ns |   4.45 ns | 1,080.7 ns |  0.47 |    0.06 |      - |         - |        0.00 |
| StackAllocSpan        |   517.6 ns |  10.09 ns |   9.44 ns |   514.2 ns |  0.23 |    0.03 |      - |         - |        0.00 |
