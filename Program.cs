//Brandon Le
//10-20-22
//Mini Challenge 3 - Asking Questions
//Project will ask user 4 different questions and store the answers into 4 different
//strings and it will print it back out to them in various sentences in the terminal.
//Errors will pop up if they enter numbers. 
//Peer Review: Isaiah Ferguson - The program works smoothly might want to change the loop to prevent double erros 
//such as intering two ints back to back. The Prompt questions are really funny! 
//I like the use of 'name' at the end of the program it felt intimate. I enjoyed the program overall!!

bool playAgain = true;
string userInput = "";
string userInput2 = "";
string userInput3 = "";
string userInput4 = "";
bool canParse = true;
int validNum = 0;


while (playAgain == true)
{
    Console.Clear();
    Console.WriteLine("Hi there I haven't seen you before. What's your name?");
    userInput = Console.ReadLine();
    canParse = Int32.TryParse(userInput, out validNum);
    while(canParse == true)
    {
        Console.WriteLine("INVALID ENTRY. Please enter your name:");
        userInput = Console.ReadLine();
        canParse = Int32.TryParse(userInput, out validNum);
    }        


    Console.WriteLine($"Oh nice to meet you {userInput}!");
    Console.WriteLine("Okay I gotta know, where are you from?");
    userInput2 = Console.ReadLine();
    canParse = Int32.TryParse(userInput2, out validNum);
    while(canParse == true)
    {
        Console.WriteLine("INVALID ENTRY. Please tell me where you're from:");
        userInput2 = Console.ReadLine();
        canParse = Int32.TryParse(userInput2, out validNum);
    }

    Console.WriteLine($"Wow you're from {userInput2}?! That's so cool!");
    Console.WriteLine("Okay okay okay last question...");
    Console.WriteLine("What is your number 1 favorite food in the world?");
    userInput3 = Console.ReadLine();
    canParse = Int32.TryParse(userInput3, out validNum);
    while(canParse == true)
    {
        Console.WriteLine("INVALID ENTRY. Please enter favorite food:");
        userInput3 = Console.ReadLine();
        canParse = Int32.TryParse(userInput3, out validNum);
    }

    Console.WriteLine("\n----------------------------------------------------------");
    Console.WriteLine($"Wow how funny {userInput3} is also one of my favorites too!");
    Console.WriteLine($"Okay {userInput} so far I've learned that you're from {userInput2}, you love to eat {userInput3}, hmmm what else should I know about you so I can guess your passwo- I mean so I can get to know you better :)");
    Console.WriteLine($"Do you want to play again {userInput}? (YES/NO)");
    userInput4 = Console.ReadLine().ToUpper();

    while(userInput4 != "YES" && userInput4 != "NO")
    {
        Console.WriteLine("INVALID ENTRY. Please enter YES or NO:");
        userInput4 = Console.ReadLine().ToUpper();
    }
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
