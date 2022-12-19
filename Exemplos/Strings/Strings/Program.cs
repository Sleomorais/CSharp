namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG    ";

            string s1 = original.ToUpper();//Maiusculo
            string s2 = original.ToLower();//Minusculo

            string s3 = original.Trim();//Apagar espaços em branco antes e depois

            int n1 = original.IndexOf("bc");// Primeira Ocorrência dos caracteres
            int n2 = original.LastIndexOf("bc");//Ultima Ocorrência dos caracteres

            string s4 = original.Substring(3); //cortar string apartir de um index especifico
            string s5 = original.Substring(3,5); //cortar string apartir de um index especifico com um total de caracteres especifico

            string s6 = original.Replace("a", "x");// Substituir uma string por outra
            string s7 = original.Replace("abc", "xy");//Substituir uma ocorrencia por outra

            bool b1 = String.IsNullOrEmpty(original);//Testa se a variavel é nula ou vazia
            bool b2 = String.IsNullOrWhiteSpace(original);//Testa se a variavel é nula ou são varios espaços em branco

            Console.WriteLine("Original: -"+ original+"-");
            Console.WriteLine("Maiusculo(ToUpper): -"+s1+"-");
            Console.WriteLine("Minusculo(ToLower): -"+s2+"-");
            Console.WriteLine("Sem Espaços a/d(Trim): -"+s3+"-");
            Console.WriteLine("Primeira ocorrencia(IndexOf(x)): -"+n1+"-");
            Console.WriteLine("Ultima ocorrencia(LastIndexOf(x)): -"+n2+"-");
            Console.WriteLine("Cortar a partir do index(Substring(x)): -"+s4+"-");
            Console.WriteLine("Cortar a partir do index, tantas posições(Substring(x,x)): -"+s5+"-");
            Console.WriteLine("Substituir uma string por outra(Replace(x,x)): -"+s6+"-");
            Console.WriteLine("Substituir uma string por outra(Replace(x,x)): -"+s7+"-");
            Console.WriteLine("Verificar se é nula ou vazia(IsNullOrEmpty(x)): -"+b1+"-");
            Console.WriteLine("Verificar se é nula ou varios espaços em branco(IsNullOrWhiteSpace(x)): -"+b2+"-");

        }
    }
}