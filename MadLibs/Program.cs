using System;

namespace MadLibs 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                MadLibs is a word game where one player prompts another 
                for a list of words to substitute for blanks in a story.

                Author (of the program): David12307
            */

            Console.WriteLine("MadLibs has started! \n");

            Console.WriteLine("               Title");
            Console.WriteLine("How to cross a piranha-infested river\n");

            // -- Questions --
            Console.WriteLine("Foreign country: ");
            string? foreignCountry = Console.ReadLine();

            Console.WriteLine("Adverb: ");
            string? adverb = Console.ReadLine();

            Console.WriteLine("Adjective: ");
            string? adjective = Console.ReadLine();

            Console.WriteLine("Animal: ");
            string? animal = Console.ReadLine();

            Console.WriteLine("Verb ending in *ing*: ");
            string? verbing = Console.ReadLine();

            Console.WriteLine("Verb: ");
            string? verb = Console.ReadLine();

            Console.WriteLine("Verb ending in *ing*: ");
            string? verbing1 = Console.ReadLine();

            Console.WriteLine("Adverb: ");
            string? adverb1 = Console.ReadLine();

            Console.WriteLine("Adjective: ");
            string? adjective1 = Console.ReadLine();

            Console.WriteLine("A place: ");
            string? place = Console.ReadLine();

            Console.WriteLine("Liquid: ");
            string? liquid = Console.ReadLine();

            Console.WriteLine("Part of the body: ");
            string? bodypart = Console.ReadLine();

            Console.WriteLine("Verb: ");
            string? verb1 = Console.ReadLine();

            // -- The template for the story --
            string story = $"If you are traveling in {foreignCountry} and find yourself having to cross a piranha-filled river, here's to do it {adverb}: \nPiranhas are more {adjective} during the day, so cross the river at night. \nAvoid areas with netted {animal} traps -- piranhas may be {verbing} there looking to {verb} them. When {verbing1} the river, swim {adverb1}. You don't want to wake them up and make them {adjective1}! \nWhatever you do, if you have an open wound, try to find another way to get back to the {place}. Piranhas are attracted to fresh {liquid} and will most likely take a bite out of your {bodypart} if you {verb1} in the water!";
            Console.WriteLine(story);
        }
    }
}