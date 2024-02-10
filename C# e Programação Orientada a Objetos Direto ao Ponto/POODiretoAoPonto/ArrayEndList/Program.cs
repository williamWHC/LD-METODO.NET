
using System.Net.Http.Headers;

namespace ArrayEndList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array

            var Numbers = new int[] { 0, 2, 3, 4, 5 };
            var numbersTwo = new int[5];

            for (int i = 0; i < Numbers.Length; i++)
            {
                numbersTwo[i] = Numbers[i];
            }

            //With Split
            string paragrafo = "10-9-8-7-6-3-1";
            string[] newParagrafo = new string[7];

            for (int i = 0; i < newParagrafo.Length; i++)
            {
                string texto = paragrafo.Split('-')[i];

                newParagrafo[i] = texto;
            }

            //Array method ConvertAll()
            string stringTexto = "5-6-8-2-1";
            var stringArray = stringTexto.Split('-');
            int[] convertStrigFromNumbers = Array.ConvertAll(stringArray, Convert.ToInt32); 



            {

            }

            #endregion

            #region List

            //---------- Adicionar a lista.---------- >

            List<int> numeros = new List<int>() { 0, 1, 2, 3, 4 };
            var listNumeros = new List<int>() { 9, 10};
            List<int> ints = new List<int>();

            numeros.Add(5);

            int[] intArray = new int[] { 6, 7, 8 };
            numeros.AddRange(intArray);

            numeros.AddRange(listNumeros);

            //---------- Desordenação ---------- >
            Console.WriteLine("Lista reversa.");
            numeros.Reverse();
            numeros.ForEach(w =>  Console.WriteLine(w));

            //---------- Ordenação ---------- >
            Console.WriteLine("Lista ordenada");
            numeros.Sort();
            numeros.ForEach(w => Console.WriteLine(w));
            var resultFind = numeros.Find(w => w == 0);

            //---------- validação ---------- >
            var quantidadeElementos = numeros.Count;
            var bYesContains = numeros.Contains(14); //false
            var bNoContains = numeros.Contains(2); //True

            numeros.ForEach(i => i.CompareTo(3));
            var teste = numeros[0].CompareTo(3);

            //---------- Remoção de item ---------- >
            numeros.Remove(4);
            numeros.RemoveAll(w => w == 0);
            numeros.RemoveRange(1, 2); //primeiro parametro é o index do array e o segundo e quantos posições do array ira ser removido.
            numeros.Clear();

            Console.WriteLine(numeros);

            //[] - Adicionar list a lista.
            //[] - Desordenar lista
            //[] - Ordenar lista
            //[] - Valida se contem valor na lista.
            //[] - Remover item da lista
            //[] - Limpar toda a lista.


            #endregion

            #region Linq

            #endregion
        }
    }
}
