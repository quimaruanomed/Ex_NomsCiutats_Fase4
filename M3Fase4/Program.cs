using System;

namespace M3Fase4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Creamos un array de caracteres para cada ciudad 

            char[] barcelona = new char []{'B','a','r','c','e','l','o','n','a'};
            char[] madrid = new char[] {'M', 'a', 'd', 'r', 'i', 'd'};
            char[] valencia = new char[] {'V', 'a', 'l', 'e', 'n', 'c', 'i', 'a'};
            char[] malaga = new char[] {'M', 'a', 'l', 'a', 'g','a'};
            char[] cadis = new char[] {'C', 'a', 'd', 'i', 's'};
            char[] santander = new char[] {'S', 'a', 'n', 't', 'a', 'n', 'd', 'e', 'r'};
            
            System.Array.Reverse(barcelona); // Método que invierte el nombre de la ciudad 
            string bcnRev = new string(barcelona);
            System.Array.Reverse(madrid);
            string madRev = new string(madrid);
            System.Array.Reverse(valencia);
            string valRev = new string(valencia);
            System.Array.Reverse(malaga);
            string malRev = new string(malaga);
            System.Array.Reverse(cadis);
            string cadRev = new string(cadis);
            System.Array.Reverse(santander);
            string santRev = new string(santander);

            Console.WriteLine(bcnRev);
            Console.WriteLine(madRev);
            Console.WriteLine(valRev);
            Console.WriteLine(malRev);
            Console.WriteLine(cadRev);
            Console.WriteLine(santRev);

        }
    }
}
