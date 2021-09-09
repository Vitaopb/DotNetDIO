using System;

namespace Aula_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[10]; "Já detertermino a length do meu array, mas não os dados"
            int[] array = {1, 2, 3, 4, 5};
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = i * i;
                Console.WriteLine($"array[{i}] = {array[i]}");
            }
        }
    }
}
