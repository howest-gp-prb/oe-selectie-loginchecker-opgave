using System;

namespace Selectie.Cons
{
    class Program
    {
        //Static omdat we in een consoleapplicatie zitten ...
        static int questionNumber = 0;
        static string userName = "Admin";
        static string password = "ilovec#";
        static int age = 16;

        static void Main(string[] args)
        {
            //OPDRACHT 1
            MakeNewQuestionLine();

            //Verwijder deze commentaarlijn en schrijf hier opdracht 1.


            //OPDRACHT 2
            MakeNewQuestionLine();

            //Verwijder deze commentaarlijn en schrijf hier opdracht 2.


            // OPDRACHT 3
            MakeNewQuestionLine();

            //Verwijder deze commentaarlijn en schrijf hier opdracht 3.

            //OPDRACHT 4
            MakeNewQuestionLine();

            //Verwijder deze commentaarlijn en schrijf hier opdracht 4.

            //OPDRACHT 5
            MakeNewQuestionLine();

            //Verwijder deze commentaarlijn en schrijf hier opdracht 5.

            //OPDRACHT 6
            MakeNewQuestionLine();

            //Verwijder deze commentaarlijn en schrijf hier opdracht 6.

            //OPDRACHT 7
            MakeNewQuestionLine();

            //Verwijder deze commentaarlijn en schrijf hier opdracht 7.

            //OPDRACHT 8
            MakeNewQuestionLine();

            //Verwijder deze commentaarlijn en schrijf hier opdracht 8.

            //OPDRACHT 9
            MakeNewQuestionLine();

            //Verwijder deze commentaarlijn en schrijf hier opdracht 9.


            //OPDRACHT 10
            MakeNewQuestionLine();

            //Verwijder deze commentaarlijn en schrijf hier opdracht 10.

            Console.ReadKey();
        }

        //static omdat we in een consoleapplicatie zitten ...
        static void MakeNewQuestionLine()
        {
            questionNumber++;
            Console.WriteLine($"\nOpdracht {questionNumber}:");
        }
    }
}
