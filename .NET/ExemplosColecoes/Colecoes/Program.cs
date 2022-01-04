using System;
using Colecoes.Helper;

namespace Colecoes 
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesArray op = new OperacoesArray();

            int[] array = new int[5] {6, 3, 8, 1, 9 };
            int[] arrayCopia = new int[10];

            //System.Console.WriteLine("Array original: ");
            //op.ImprimirArray(array);

            //op.OrdenarBubbleSort(ref array);
            //op.Ordenar(ref array);

           // System.Console.WriteLine("Array ordenado: ");
           //op.ImprimirArray(array);

            System.Console.WriteLine("Array antes da cópia:");
            op.ImprimirArray(arrayCopia);

            op.Copiar(ref array, ref arrayCopia);
            System.Console.WriteLine("Array após a cópia:");
            op.ImprimirArray(arrayCopia);

            // int[] arrayinteiros = new int[3];

            // arrayinteiros[0] = 10;
            // arrayinteiros[1] = 20;
            // arrayinteiros[2] = int.Parse("30");
            
            // arrayinteiros[3] = 30;

            // System.Console.WriteLine("Percorrendo o array pelo For");
            // for (int i = 0; i < arrayinteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayinteiros[i]);
            // }

            // System.Console.WriteLine("Percorrendo o array pelo ForEach");
            // foreach (int item in arrayinteiros)
            // {
            //     System.Console.WriteLine(item);
            // }
        }
    }
}
