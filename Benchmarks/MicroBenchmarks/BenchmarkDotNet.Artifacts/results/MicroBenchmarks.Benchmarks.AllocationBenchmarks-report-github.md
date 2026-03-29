```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22621.4317/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11700K 3.60GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 10.0.201
  [Host]     : .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                | Mean       | Error     | StdDev    | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|---------------------- |-----------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
| NewListEachRow        | 4,416.9 ns | 117.69 ns | 347.00 ns |  1.01 |    0.11 | 1.3428 |   11264 B |        1.00 |
| ThreadLocalPooledList | 1,322.7 ns |  26.32 ns |  73.81 ns |  0.30 |    0.03 |      - |         - |        0.00 |
| StackAllocSpan        |   600.3 ns |  12.04 ns |  33.75 ns |  0.14 |    0.01 |      - |         - |        0.00 |
