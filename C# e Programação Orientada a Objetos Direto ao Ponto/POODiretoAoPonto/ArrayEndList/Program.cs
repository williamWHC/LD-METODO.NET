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

            #endregion

            #region Linq

            #endregion
        }
    }
}
