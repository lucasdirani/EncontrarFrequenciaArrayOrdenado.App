namespace EncontrarFrequenciaArrayOrdenado.App.Algoritmos
{
    public static class AlgoritmoFrequenciaArrayOrdenado
    {
        public static void EncontrarFrequenciaEmComplexidadeLinearDeMemoria(int[] arr, int n)
        {
            Dictionary<int, int> dict = new();
            for (int i = 0; i < n; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]]++;
                }
                else
                {
                    dict.Add(arr[i], 1);
                }
            }
            foreach (KeyValuePair<int, int> entrada in dict)
            {
                Console.WriteLine($"Elemento {entrada.Key} aparece {entrada.Value} vezes");
            }
        }

        public static void EncontrarFrequenciaEmComplexidadeConstanteDeMemoria(int[] arr, int n)
        {
            int frequencia = 1;
            for (int i = 1; i < n; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    frequencia++;
                } 
                else
                {
                    Console.WriteLine($"Elemento {arr[i - 1]} aparece {frequencia} vezes");
                    frequencia = 1;
                }
            }
            Console.WriteLine($"Elemento {arr[n - 1]} aparece {frequencia} vezes");
        }
    }
}