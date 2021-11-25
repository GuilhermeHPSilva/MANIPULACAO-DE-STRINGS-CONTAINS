using System;

namespace Contains
{
    class Program
    {
        static void Main(string[] args)
        { 
            // o Contains é um método de comparação que serve para checar se existe certa letra ou palavra em uma string  

            string palavra = Convert.ToString(Console.ReadLine());            
            bool Contem = palavra.Contains("a");
            if(Contem == true)
            {
                Console.WriteLine("A palavra contém a letra 'a'");
            }
            else
            {
                Console.WriteLine("A palavra não contém a letra 'a'");
            }
        }
    }
}
