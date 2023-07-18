using System;

namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /* Scrieti un program care va numara toate aparitiile unui caracter intr-un sir de caractere. Atat caracterul cautat cat si sirul de caracter vor fi citite de la tastatura.*/


            Console.WriteLine("Introduceti sirul de caractere: ");
            string text = Console.ReadLine();


            Console.WriteLine("Introduceti caracterul de cautat: ");
            char textDeCautat = char.Parse(Console.ReadLine());
             
            Console.WriteLine("\n"+ $"Caracterul '{textDeCautat}' este contorizat de" + " " + (ContorCaractere(text, textDeCautat)) + " "+ "ori.");
        }

            static int ContorCaractere(string text, char textCautat)
            {
                int contorCaractere = 0;
                foreach (char c in text)
                {
                    if (textCautat==c)
                    {
                        contorCaractere ++;
                    }
                }

                return contorCaractere; 
            }

            
    }

}