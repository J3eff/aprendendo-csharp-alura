using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5 -  caracteres e textos");

            // character
            char primeiraLetra = ' '; // Devemos sempre usar aspas simples
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            //primeiraLetra += (char)1; mais imples
            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de tecnologia " + 2022;           
            Console.WriteLine(titulo);

            string cursosProgramacao = @" - .NET
 - Java
 - JavaScript";
            Console.WriteLine(cursosProgramacao);
            
            


            Console.ReadLine();
        }
    }
}
