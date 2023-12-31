﻿using BenchmarkDotNet.Attributes;
using EncontrarFrequenciaArrayOrdenado.App.Algoritmos;

namespace EncontrarFrequenciaArrayOrdenado.App.Performance
{
    [MemoryDiagnoser]
    [RankColumn]
    public class TestePerformanceAlgoritmoFrequenciaArrayOrdenado
    {
        [Params(
            new int[] { 1, 1, 1, 1, 4, 5, 5, 5, 7, 7, 7, 9, 10, 10, 10, 10, 11, 15 },
            new int[] { 1, 1, 1, 1, 4, 5, 5, 5, 7, 7, 7, 9, 10, 10, 10, 10, 11, 15, 15, 16, 16, 17, 17, 17, 17, 20, 20, 20, 20, 24, 25, 25, 26, 26, 26, 26, 26, 27, 27, 27, 30, 30, 32, 35, 35, 35, 35, 36, 36, 36, 36 },
            new int[] { 1, 1, 1, 1, 4, 5, 5, 5, 7, 7, 7, 9, 10, 10, 10, 10, 11, 15, 15, 16, 16, 17, 17, 17, 17, 20, 20, 20, 20, 24, 25, 25, 26, 26, 26, 26, 26, 27, 27, 27, 30, 30, 32, 35, 35, 35, 35, 36, 36, 36, 36, 37, 37, 39, 40, 40, 40, 40, 40, 41, 41, 42, 42, 42, 44, 44, 44, 44, 44, 44, 44, 46, 47, 47, 49, 49, 49, 49, 49, 49, 49, 49, 49, 50, 50, 50, 51, 52, 52, 52, 52, 52, 52, 52, 52, 54, 54, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 56, 56, 57, 57, 57, 57, 57, 58, 58, 58, 58, 58, 59, 59, 59, 59, 59, 59, 59 },
            new int[] { 1, 1, 1, 1, 4, 5, 5, 5, 7, 7, 7, 9, 10, 10, 10, 10, 11, 15, 15, 16, 16, 17, 17, 17, 17, 20, 20, 20, 20, 24, 25, 25, 26, 26, 26, 26, 26, 27, 27, 27, 30, 30, 32, 35, 35, 35, 35, 36, 36, 36, 36, 37, 37, 39, 40, 40, 40, 40, 40, 41, 41, 42, 42, 42, 44, 44, 44, 44, 44, 44, 44, 46, 47, 47, 49, 49, 49, 49, 49, 49, 49, 49, 49, 50, 50, 50, 51, 52, 52, 52, 52, 52, 52, 52, 52, 54, 54, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 56, 56, 57, 57, 57, 57, 57, 58, 58, 58, 58, 58, 59, 59, 59, 59, 59, 59, 59, 60, 60, 60, 60, 60, 60, 60, 60, 60, 61, 62, 62, 62, 67, 67, 67, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 71, 71, 71, 73, 73, 76, 76, 76, 77, 79, 79, 79, 79, 79, 79, 79, 79, 79, 79, 79, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 82, 82, 85, 85, 85 })]
        public int[] Array { get; set; }

        [Benchmark]
        public void MedirPerformanceEncontrarFrequenciaEmComplexidadeLinearDeMemoria()
        {
            AlgoritmoFrequenciaArrayOrdenado.EncontrarFrequenciaEmComplexidadeLinearDeMemoria(Array, Array.Length);
        }

        [Benchmark]
        public void MedirPerformanceEncontrarFrequenciaEmComplexidadeConstanteDeMemoria()
        {
            AlgoritmoFrequenciaArrayOrdenado.EncontrarFrequenciaEmComplexidadeConstanteDeMemoria(Array, Array.Length);
        }
    }
}