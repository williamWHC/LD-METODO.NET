namespace WorkingWithString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Principais métodos e propriedades String

            string nome = "Rua Piacatu n° 9000";

            //Length - comprimento da string
            int comprimento = nome.Length;
            Console.WriteLine($"Lenght: {comprimento}");
            //---------------

            //Empty - string vazia
            string emptyString = string.Empty;

            object emptyObject = string.Empty;

            Console.WriteLine($"Empty String: \"{emptyString}\"");
            Console.WriteLine($"Empty Object: \"{emptyObject}\"");
            //---------------

            //toLower - transforma todo o texto em minusculo
            string textoToLowerCase = nome.ToLower();
            Console.WriteLine($"toLower: {textoToLowerCase}");
            //---------------
            
            //toUpper - transforma todo o texto em maiusculo
            string textoToUpperCase = nome.ToUpper();
            Console.WriteLine($"toUpper: {textoToUpperCase} ");

            //Split com string, char, array
            char[] separador = { ' ' };
            string[] partes = nome.Split(separador);
            Console.WriteLine($"Split: {String.Join(',', partes)}");
                

            //---------------

            //Trim - retira o espaço em branco no inicio e final da string
            string textoComEspaco = " William Lorenzo Bernardo ";
            char[] charParaRemover = { ' ', 'W' };
            string textoTrim = textoComEspaco.Trim(charParaRemover);
            Console.WriteLine($"Trim: {textoTrim}");
            
            //TrimEnd - retira o espaço em branco do final da string
            string textoTrimEnd = "Stephane anjos";
            char[] charParaRemoverTrimEnd = { ' ', 's' };
            string texto = textoTrimEnd.TrimEnd(charParaRemoverTrimEnd);
            Console.WriteLine($"TrimEnd: {texto}");

            //TrimStart - retira o espaço no inicio da string.
            string sTrimStart = nome.TrimStart();
            //---------------

            //IsNullOrWhileSpace - retorna um bool se a string for Null ou vazia.
            string stringNull = null;
            string stringVazia = ""; 
            string stringComEspaco = "  ";

            bool strinNullWhileSpace = string.IsNullOrWhiteSpace(stringNull);
            bool strinVaziaWhileSpace = string.IsNullOrWhiteSpace(stringVazia);
            bool stringComEspacoWhileSpace = string.IsNullOrWhiteSpace(stringComEspaco);

            Console.WriteLine($" IsNullOrWhiteSpace: (null) {strinNullWhileSpace}");
            Console.WriteLine($" IsNullOrWhiteSpace: (Vazio) {strinNullWhileSpace}");
            Console.WriteLine($" IsNullOrWhiteSpace: (Com Espaco) {strinNullWhileSpace}");

            //---------------

            //Replace - substitui um chat expecifico de um conjunto de string.
            string newTexto = "William";
            string novoTexto = newTexto.Replace('m', 'n');
            Console.WriteLine($" Replace: {novoTexto}");

            #endregion

            #region Principais métodos e propriedades para Buscas

            string paragrafo = "C# é uma linguagem de progração fortimente tipada, podemos trabalhar com desenvolvimento Web, Desktop, Mobile, IoT. Sua versão mais recente é a C# 10 e o conjunto de bibliotécas .NET 8.";

            var indexOF = paragrafo.IndexOf("C#"); 

            var lastIndexOf = paragrafo.LastIndexOf("Web");

            var startWith = paragrafo.StartsWith("C#");

            var endWith = paragrafo.EndsWith("8.");

            var substring1 = paragrafo.Substring(indexOF);
            var substring2 = paragrafo.Substring(indexOF, lastIndexOf);

            var contains = paragrafo.Contains("Mobile");
            var containsTwo = paragrafo.Contains("mobile", StringComparison.OrdinalIgnoreCase);

            Console.WriteLine(indexOF);

            #endregion
        }
    }
}
