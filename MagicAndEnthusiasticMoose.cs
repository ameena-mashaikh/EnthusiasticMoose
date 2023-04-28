

//?MAGIC MOOSE CHALLENGE
// using System;
// Main();


// void Main()
// {
//     Console.WriteLine("Welcome to the Magic Moose Simulator!");
//     Console.WriteLine("--------------------------------------------");
//     Console.WriteLine();
//     MagicMoose();
//     ResponseAns();
// }

// void ResponseAns()
// {

//     List<string> response = new List<string>(){
//         "As I see it, yes.",
//         "Ask again later.",
//         "Better not tell you now.",
//         "Cannot predict now.",
//         "Concentrate and ask again.",
//         "Don't count on it.",
//         "It is certain.",
//         "It is decidedly so.",
//         "Most likely.",
//         "My reply is no.",
//         "My sources say no.",
//         "Outlook not so good.",
//         "Outlook good.",
//         "Reply hazy, try again.",
//         "Signs point to yes.",
//         "Very doubtful.",
//         "Without a doubt.",
//         "Yes",
//         "Yes - definitely.",
//         "You may rely on it."
//     };


//     Random randNum = new Random();
//     int randResponse = randNum.Next(0, response.Count);
//     Console.Write(response[randResponse]);
// };



// void MagicMoose()
// {

//     Console.WriteLine(@"
//                                        _.--^^^--,
//                                     .'          `\
//   .-^^^^^^-.                      .'              |
//  /          '.                   /            .-._/
// |             `.                |             |
//  \              \          .-._ |          _   \
//   `^^'-.         \_.-.     \   `          ( \__/
//         |             )     '=.       .,   \
//        /             (         \     /  \  /
//      /`               `\        |   /    `'
//      '..-`\        _.-. `\ _.__/   .=.
//           |  _    / \  '.-`    `-.'  /
//           \_/ |  |   './ _     _  \.'
//                '-'    | /       \ |
//                       |  .-. .-.  |
//                       \ / o| |o \ /
//                        |   / \   |   ASK ME A QUESTION!!!
//                       / `^`   `^` \
//                      /             \
//                     | '._.'         \
//                     |  /             |
//                      \ |             |
//                       ||    _    _   /
//                       /|\  (_\  /_) /
//                       \ \'._  ` '_.'
//                        `^^` `^^^`
//     ");
//     string question = Console.ReadLine();
// }







//~Code Before the Challenges
// void Main()
// {
//     Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
//     Console.WriteLine("--------------------------------------------");
//     Console.WriteLine();

//     // Let the moose speak!
//     MooseSays("H I, I'M  E N T H U S I A S T I C !");
//     MooseSays("I really am enthusiastic");

//     // Ask a question
//     Question();
// }

// void Question()
// {
//     bool isTrue = MooseAsks("Is Canada real?");
//     if (isTrue)
//     {
//         MooseSays("Really? It seems very unlikely.");
//     }
//     else if (!isTrue)
//     {
//         MooseSays("I  K N E W  I T !!!");
//     }


//     bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
//     if (doesLoveCSharp)
//     {
//         MooseSays("Good job sucking up to your instructor!");
//     }
//     else if (!doesLoveCSharp)
//     {
//         MooseSays("You will...oh, yes, you will...");
//     }

//     bool wantsSecret = MooseAsks("Do you want to know a secret?");
//     if (wantsSecret)
//     {
//         MooseSays("ME TOO!!!! I love secrets...tell me one!");
//     }
//     else if (!wantsSecret)
//     {
//         MooseSays("Oh, no...secrets are the best, I love to share them!");

//     }
// }




// void MooseSays(string message)
// {
//     Console.WriteLine($@"
//                                        _.--^^^--,
//                                     .'          `\
//   .-^^^^^^-.                      .'              |
//  /          '.                   /            .-._/
// |             `.                |             |
//  \              \          .-._ |          _   \
//   `^^'-.         \_.-.     \   `          ( \__/
//         |             )     '=.       .,   \
//        /             (         \     /  \  /
//      /`               `\        |   /    `'
//      '..-`\        _.-. `\ _.__/   .=.
//           |  _    / \  '.-`    `-.'  /
//           \_/ |  |   './ _     _  \.'
//                '-'    | /       \ |
//                       |  .-. .-.  |
//                       \ / o| |o \ /
//                        |   / \   |    {message}
//                       / `^`   `^` \
//                      /             \
//                     | '._.'         \
//                     |  /             |
//                      \ |             |
//                       ||    _    _   /
//                       /|\  (_\  /_) /
//                       \ \'._  ` '_.'
//                        `^^` `^^^`
//     ");
// }

// bool MooseAsks(string question)
// {
//     Console.Write($"{question} (Y/N): ");
//     string answer = Console.ReadLine().ToLower();


//     //While loop to check if the user inputs something other than y or n! I would've used an if statement for this, but a while loop makes more sense
//     while (answer != "y" && answer != "n")
//     {
//         Console.Write($"{question} (Y/N): ");
//         answer = Console.ReadLine().ToLower();
//     }

//     if (answer == "y")
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

