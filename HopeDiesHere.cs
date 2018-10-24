using System;

namespace HopeDiesHere 
{
    public class Beginning 
    {
        static void Main(string[] args) 
        {
            String Input = Console.ReadLine();

            Console.WriteLine("You're in a dark room, with a faint flickering light down the hall in front of you. You hear the dragging of chains behind the door to your left.");
            Console.ReadLine();
            {
                if (Input == "Left" )
                {
                    Console.WriteLine("You attempt to open the door, but it doesn't budge. The sounds behind the door are no longer present...");
                    
                }
                else
                {
                    Console.WriteLine("You approach the flickering light at the end of the hallway, though with every step you take forward the sound of chains from before seem to grow louder and louder...");
                }
                Console.ReadLine();
                do
                {
                    Input = Console.ReadLine();
                } while (Input != "Exit");
            }
        }
    }
}