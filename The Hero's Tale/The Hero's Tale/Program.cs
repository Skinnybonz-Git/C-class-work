using System;

class Program
{
    static void Main()
    {
        string choice1 = "";

        Console.WriteLine("You are a young hunter, traveling through the woods.\n You suddenly spot a sword within a stone!" +
            "do you try to draw it out?");

        // First choice loop
        while (true)
        {
            try
            {
                Console.WriteLine("Type 'yes' or 'no':");
                choice1 = Console.ReadLine().ToLower();

                if (choice1 == "yes" || choice1 == "no")
                {
                    break; // valid input → exit loop
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.\n");
                }
            }
            catch
            {
                Console.WriteLine("Error reading input. Try again.\n");
            }
        }

        if (choice1 == "no")
        {
            Console.WriteLine("Hmm, no. Suspicious swords in the middle of the woods should be left well alone.\n" +
                "You go on your way, time passes and you become a good hunter until one day the Demon King attacks\n" +
                "then you die.");
        }
        else if (choice1 == "yes")
        {
            Console.WriteLine("You draw out the sword and incredible power fills you!\n" +
                "a radiant voice in your head tasks you with defeating the Demon King!\n" +
                "You embark on a long quest, making many friends and allies until eventually...\n" +
                "You face the Demon King!\n" +
                "You fight a long and arduous battle, your friends giving their lives, until the Demon King is cast down before you.\n" +
                "\"Mercy!\n he pleads, begging before you. Shall you grant mercy, or will you strike him down?");

            string choice2 = "";

            // Second choice loop
            while (true)
            {
                try
                {
                    Console.WriteLine("Type 'mercy' or 'slay':");
                    choice2 = Console.ReadLine().ToLower();

                    if (choice2 == "mercy" || choice2 == "slay")
                    {
                        break; // valid input
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please try again.\n");
                    }
                }
                catch
                {
                    Console.WriteLine("Error reading input. Try again.\n");
                }
            }

            if (choice2 == "mercy")
            {
                Console.WriteLine("You relax your sword arm, offering your other hand out in friendship.\n" +
                    "The Demon King slowly reaches out and takes it, before giving you a wide grin.\n" +
                    "\nIn an instant you are yanked forward,\na flash of silver glimpsed the moment before a terrible pain strikes your chest followed by weakness.\n" +
                    "\"Pitiable Hero, do you so long for friendship?\"\n" +
                    "The Demon King gives a low chuckle\n \"I shall grant my own mercy and send you to all you have failed.\"\n" +
                    "Everything is starting to fade, the last thing you see is a grin marked by cruelty.");
            }
            else if (choice2 == "slay")
            {
                Console.WriteLine("You grit your teeth and glare down at your foe \"Mercy? Mercy is wasted on Evil such as you Monster!\"\n" +
                    "\"On behalf of Elincia of the Cardinal Order, Eiji Of the Blade Clans, and Marbrook of the Hidden Shadow!\"\n" +
                    "You ready your sword high\n \"I will have your head!\"\n you shout as you swing the holy sword, freeing his head from his body.\n" +
                    "You pant heavily for awhile before standing up." +
                    "You pick up your proof and tie it by your belt.\nYou spend the rest of the day burying your companions.\n" +
                    "You stand before their graves and reminisce, closing your eyes and taking in a deep breath, before exhaling\n" +
                    "\"It is done.\" you say, opening your eyes.\n" +
                    "You turn around and begin the long march home.");
            }
        }

        Console.WriteLine("\n--- End of Story ---");
    }
}