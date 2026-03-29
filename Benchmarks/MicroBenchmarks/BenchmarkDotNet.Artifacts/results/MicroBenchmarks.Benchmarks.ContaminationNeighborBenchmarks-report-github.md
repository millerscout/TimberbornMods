```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22621.4317/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11700K 3.60GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 10.0.201
  [Host]     : .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method        | ContaminationLevel | Mean     | Error    | StdDev   | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|-------------- |------------------- |---------:|---------:|---------:|------:|--------:|----------:|----------:|------------:|
| **NoEarlyExit**   | **AllZero**            | **296.8 μs** | **10.10 μs** | **29.63 μs** |  **1.01** |    **0.14** |     **231 B** |         **-** |          **NA** |
| WithEarlyExit | AllZero            | 165.9 μs |  3.32 μs |  6.70 μs |  0.56 |    0.06 |     275 B |         - |          NA |
|               |                    |          |          |          |       |         |           |           |             |
| **NoEarlyExit**   | **Random**             | **287.1 μs** |  **9.03 μs** | **25.92 μs** |  **1.01** |    **0.12** |     **231 B** |         **-** |          **NA** |
| WithEarlyExit | Random             | 188.7 μs |  4.23 μs | 12.46 μs |  0.66 |    0.07 |     275 B |         - |          NA |
|               |                    |          |          |          |       |         |           |           |             |
| **NoEarlyExit**   | **AllMax**             | **343.9 μs** | **15.43 μs** | **45.02 μs** |  **1.02** |    **0.18** |     **231 B** |         **-** |          **NA** |
| WithEarlyExit | AllMax             | 174.0 μs |  3.45 μs |  8.07 μs |  0.51 |    0.07 |     275 B |         - |          NA |
