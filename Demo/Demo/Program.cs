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
                affichage +=
                    string.Format("{0:00} x {1,-4} = {2:C}",
                    i,               // Element 0
                    multiple,        // Element 1
                    i*multiple       // Element 2
                    );

                affichage += "\n";
            }
            
            Console.WriteLine(affichage);
        }
    }
}
