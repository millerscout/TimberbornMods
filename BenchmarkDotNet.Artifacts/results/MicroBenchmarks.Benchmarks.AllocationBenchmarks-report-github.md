```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22621.4317/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11700K 3.60GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 10.0.201
  [Host]     : .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                | Mean       | Error     | StdDev    | Median     | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|---------------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|----------:|------------:|
| NewListEachRow        | 3,095.3 ns | 131.67 ns | 382.00 ns | 2,984.5 ns |  1.01 |    0.17 | 1.3466 |   11264 B |        1.00 |
| ThreadLocalPooledList | 1,134.8 ns |  21.53 ns |  44.46 ns | 1,126.0 ns |  0.37 |    0.04 |      - |         - |        0.00 |
| StackAllocSpan        |   547.8 ns |  10.95 ns |  26.22 ns |   543.4 ns |  0.18 |    0.02 |      - |         - |        0.00 |
