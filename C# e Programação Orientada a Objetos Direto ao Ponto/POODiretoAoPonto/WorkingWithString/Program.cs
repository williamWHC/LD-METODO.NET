namespace WorkingWithString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Rua Piacatu n° 9000";

            //Length
            int comprimento = nome.Length;
            Console.WriteLine($"Lenght: {comprimento}");
            //---------------

            //Empty
            string emptyString = string.Empty;
            object emptyObject = string.Empty;

            Console.WriteLine($"Empty String: \"{emptyString}\"");
            Console.WriteLine($"Empty Object: \"{emptyObject}\"");
            //---------------

            //toLower
            string textoToLowerCase = nome.ToLower();
            Console.WriteLine($"toLower: {textoToLowerCase}");
            //---------------
            
            //toUpper
            string textoToUpperCase = nome.ToUpper();
            Console.WriteLine($"toUpper: {textoToUpperCase} ");

            //Split com string, char, array
            char[] separador = { ' ' };
            string[] partes = nome.Split(separador);
            Console.WriteLine($"Split: {String.Join(',', partes)}");
            //---------------

            //Trim - 
            string textoComEspaco = " William Lorenzo Bernardo ";
            char[] charParaRemover = { ' ', 'W' };
            string textoTrim = textoComEspaco.Trim(charParaRemover);
            Console.WriteLine($"Trim: {textoTrim}");
            
            //TrimEnd
            string textoTrimEnd = "Stephane anjos";
            char[] charParaRemoverTrimEnd = { ' ', 's' };
            string texto = textoTrimEnd.TrimEnd(charParaRemoverTrimEnd);
            Console.WriteLine($"TrimEnd: {texto}");

            //TrimStart
            string sTrimStart = nome.TrimStart();
            //---------------

            //IsNullOrWhileSpace
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

            //Replace
            string newTexto = "William";
            string novoTexto = newTexto.Replace('m', 'n');
            Console.WriteLine($" Replace: {novoTexto}");

        }
    }
}
