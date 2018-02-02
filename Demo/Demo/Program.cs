using System;

namespace Demo
{
    class Program // Demo.Program
    {
        static void Main(string[] args)
        {
            // Afficher la table des 8 (multiplication)
            // Concaténation : +
            // Saut de ligne : \n

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            const int multiple = 8;
            const int valMax = 10;

            string affichage = "";

            for (int i=0; i <= valMax; i++)
            {
                // Interpolated string (C# >= v6)
                int resultat = i * multiple;
                affichage +=
                    $"{i:00} x {multiple,-4} = {resultat:C}";

                affichage += "\n";
            }
            
            Console.WriteLine(affichage);
        }
    }
}
