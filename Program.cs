﻿//Brandon Le
//10-18-22
//Mini Challenge 3 - Asking Questions

//need to add data validation
bool playAgain = true;
string userInput = "";
string userInput2 = "";
string userInput3 = "";
string userInput4 = "";


while (playAgain == true)
{
    Console.WriteLine("Hi there I haven't seen you before. What's your name?");
    userInput = Console.ReadLine();
    Console.WriteLine($"Oh nice to meet you {userInput}!");
    Console.WriteLine("Okay I gotta know, where are you from?");
    userInput2 = Console.ReadLine();
    Console.WriteLine($"Wow you're from {userInput2}?! That's so cool!");
    Console.WriteLine("Okay okay okay last question...");
    Console.WriteLine("What is your number 1 favorite food in the world?");
    userInput3 = Console.ReadLine();
    Console.WriteLine($"Wow how funny {userInput3} is also one of my favorites too!");
    Console.WriteLine($"Okay {userInput} so far I've learned that you're from {userInput2}, you love to eat {userInput3}, hmmm what else should I know about you so I can guess your passwo- I mean so I can get to know you better :)");
    Console.WriteLine($"Do you want to play again {userInput}? (YES/NO)");
    userInput4 = Console.ReadLine().ToUpper();

    if(userInput4 == "YES")
    {
        playAgain = true;
    }
    if(userInput4 == "NO")
    {
        playAgain = false;
        Console.WriteLine($"Hehe okay well it was nice getting to know you {userInput} from {userInput2}!");
    }

}
