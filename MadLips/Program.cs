using System;

namespace MadLips
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string noun1, verb1, adjective1, nationality, verb2, verb3, noun2, verb4, place, noun3, noun4, verb5;
            Console.WriteLine("Give me a noun");
            noun1 = Console.ReadLine();

            Console.WriteLine("Give me a verb");
            verb1 = Console.ReadLine();

            Console.WriteLine("Give me a adjective");
            adjective1 = Console.ReadLine();

			Console.WriteLine("Give me a nationality");
			nationality = Console.ReadLine();

			Console.WriteLine("Give me a verb");
            verb2 = Console.ReadLine();

			Console.WriteLine("Give me a verb");
            verb3= Console.ReadLine();

			Console.WriteLine("Give me a noun");
			noun2 = Console.ReadLine();

			Console.WriteLine("Give me a verb");
			verb4 = Console.ReadLine();

			Console.WriteLine("Give me a place");
			place = Console.ReadLine();

			Console.WriteLine("Give me a noun");
            noun3= Console.ReadLine();

			Console.WriteLine("Give me a noun");
			noun4 = Console.ReadLine();

			Console.WriteLine("Give me a verb");
            verb5 = Console.ReadLine();


            Console.WriteLine("I was walking through the park when I saw a {0} it was very hurt so I{1}. Then I countined my walk and went to a hot dog stand " +
            "where there was a very {2} man. I think he was from {3} the he {4} so in response I {5} him with a {6}. Then I countined my walk." +
            " I was now on my way home when I say a woman gettting robbed being the brave soul I am I {7} the woman and then took her to {8}" +
                              " This place would later be where we have our wedding. We had two kids that grew up to be {9} and a {10}" + "My wife died in 1980 and I took another walk through the park until I was {11} to death", noun1, verb1, adjective1, nationality, verb2, verb3, noun2, verb4, place, noun3, noun4, verb5);
            Console.ReadLine();

        }
    }
}
