using System;

namespace _07_OutrasFuncoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            string original = "abcde FGHIJ ABC abc DEFG   ";

            string s1 = original.ToUpper();      //letra maiúscula
            string s2 = original.ToLower();      //letra minúscula
            string s3 = original.Trim();         //remover espaço em branco no final
            
            int n1 = original.IndexOf("bc");     //mostrar a posição da primeira ocorrência
            int n2 = original.LastIndexOf("bc");  //mostrar a posição da ultima ocorrência

            string s4 = original.Substring(3);    //mostra a partir da posição selecionada (3)
            string s5 = original.Substring(3,5);  //mostra 5 caracteres a partir da posição selecionada (3)

            string s6 = original.Replace('a', 'x');  //substitui todos os a por x
            string s7 = original.Replace("abc", "xy");  //substitui todos os abc por xy

            bool b1 = String.IsNullOrEmpty(original);     //mostra true se a string está vazia
            bool b2 = String.IsNullOrWhiteSpace(original); //mostra true se a string está vazia ou contém apenas espaços em branco

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): -" + n1 + "-");
            Console.WriteLine("LastIndexOf('bc'): -" + n2 + "-");
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: -" + b1 + "-");
            Console.WriteLine("IsNullOrWhiteSpace: -" + b2 + "-");
        }
    }
}
