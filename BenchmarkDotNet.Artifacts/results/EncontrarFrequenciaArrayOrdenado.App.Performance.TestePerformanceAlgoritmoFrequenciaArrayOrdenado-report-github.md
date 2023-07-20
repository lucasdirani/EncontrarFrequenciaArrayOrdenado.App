``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.3086/22H2/2022Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.203
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|                                                              Method |      Array |       Mean |    Error |    StdDev |     Median | Rank | Allocated |
|-------------------------------------------------------------------- |----------- |-----------:|---------:|----------:|-----------:|-----:|----------:|
|    **MedirPerformanceEncontrarFrequenciaEmComplexidadeLinearDeMemoria** | **Int32[128]** | **3,876.9 μs** | **88.00 μs** | **246.76 μs** | **3,789.2 μs** |    **3** |    **4530 B** |
| MedirPerformanceEncontrarFrequenciaEmComplexidadeConstanteDeMemoria | Int32[128] | 3,957.9 μs | 78.76 μs | 204.71 μs | 3,879.6 μs |    4 |    2965 B |
|    **MedirPerformanceEncontrarFrequenciaEmComplexidadeLinearDeMemoria** |  **Int32[18]** |   **856.9 μs** | **17.03 μs** |  **32.82 μs** |   **842.9 μs** |    **1** |    **1417 B** |
| MedirPerformanceEncontrarFrequenciaEmComplexidadeConstanteDeMemoria |  Int32[18] |   847.0 μs | 14.84 μs |  12.39 μs |   843.7 μs |    1 |     641 B |
|    **MedirPerformanceEncontrarFrequenciaEmComplexidadeLinearDeMemoria** | **Int32[203]** | **5,322.2 μs** | **57.11 μs** |  **53.42 μs** | **5,321.7 μs** |    **5** |    **7405 B** |
| MedirPerformanceEncontrarFrequenciaEmComplexidadeConstanteDeMemoria | Int32[203] | 5,353.5 μs | 81.14 μs |  71.93 μs | 5,358.7 μs |    5 |    4005 B |
|    **MedirPerformanceEncontrarFrequenciaEmComplexidadeLinearDeMemoria** |  **Int32[51]** | **2,024.1 μs** | **25.27 μs** |  **21.11 μs** | **2,024.4 μs** |    **2** |    **3090 B** |
| MedirPerformanceEncontrarFrequenciaEmComplexidadeConstanteDeMemoria |  Int32[51] | 2,037.8 μs | 36.95 μs |  34.56 μs | 2,032.1 μs |    2 |    1522 B |
