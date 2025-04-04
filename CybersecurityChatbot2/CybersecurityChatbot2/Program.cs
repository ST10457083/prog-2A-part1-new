using System;
using System.Media;
using System.Threading;

class CybersecurityChatbot2
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        try
        {
            using (SoundPlayer player = new SoundPlayer("..\\..\\welcome.wav"))
            {
                player.Play();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error playing welcome sound: " + ex.Message);
            Console.ResetColor();
        }
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(@"
   ____       _                  _                      
  / ___|  ___| |_ _   _ _ __ ___| |__   ___ _ __  _   _ 
  \___ \ / _ \ __| | | | '__/ __| '_ \ / _ \ '_ \| | | |
   ___) |  __/ |_| |_| | | | (__| | | |  __/ | | | |_| |
  |____/ \___|\__|\__,_|_|  \___|_| |_|\___|_| |_|\__,_|

      Welcome to the Cybersecurity Chatbot ( PROGRAMMING 2A - PROG6221 )
                        Created by: Hlompho PETJA
        ");
        Console.ResetColor();


        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Enter your name: ");
        Console.ResetColor();
        string userName = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(userName))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Name cannot be empty.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter your name: ");
            Console.ResetColor();
            userName = Console.ReadLine();
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nWelcome, {userName}! Let’s explore the world of cybersecurity together.");
        Console.ResetColor();

        ChatbotInteraction();
    }

    static void ChatbotInteraction()
    {
        while (true)
        {
     
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Ask a question or type 'exit' to quit: ");
            Console.ResetColor();
            string input = Console.ReadLine().ToLower();

         
            if (input == "exit")
            {
                Respond("Goodbye!");
                Thread.Sleep(50);
                break;
            }

         
            if (input.Contains("worried") || input.Contains("nervous"))
                Respond("It's okay to feel that way. Cybersecurity can seem complex, but I'm here to guide you step by step.");
            else if (input.Contains("frustrated") || input.Contains("confused"))
                Respond("Don't worry. Everyone starts somewhere.");
            else if (input.Contains("curious") || input.Contains("interested"))
                Respond("That's great! Curiosity is the first step toward cyber awareness.");


            switch (input)
            {
                case "how are you?":
                case "how are you":
                    Respond("I’m running smoothly, thanks for asking! Ready to help you stay cyber safe.");
                    break;

                case "what’s your purpose?":
                case "what is your purpose?":
                case "why are you here?":
                    Respond("My mission is to help you understand and stay safe in the digital world! Ask me anything about cybersecurity.");
                    break;

                case "what can i ask you about?":
                case "what do you know?":
                case "help":
                    Respond("You can ask me about:\n" +
                            " Password Safety\n" +
                            " Phishing Scams\n" +
                            "Safe Browsing Habits\n" +
                            " Malware and how to avoid it\n" +
                            "Mobile device security\n" +
                            "Online privacy tips\n" +
                            "Try asking something like 'How do I protect my password?' or 'What is phishing?'");
                    break;

                case "what is phishing?":
                    Respond("Phishing is a cyber scam where attackers pretend to be trustworthy to trick you into giving personal info.");
                    break;

                case "how do i protect my password?":
                    Respond("Use long, complex passwords with symbols, numbers, and upper/lowercase letters. And don't reuse passwords!");
                    break;

                case "how do i browse safely?":
                case "how to stay safe online?":
                    Respond("Stick to trusted websites, avoid clicking unknown links, and always update your browser and antivirus software.");
                    break;

             
                case "what is malware?":
                    Respond("Malware is software designed to damage or gain unauthorized access to your system.");
                    break;

               

                case "how do i stay safe online?":
                    Respond("Browse trusted sites, don’t click unknown links, update your software, and use antivirus tools.");
                    break;

                default:
                    Respond("I’m not sure how to answer that yet. Try asking about malware, phishing, or password safety.");
                    break;
            }
        }
    }

    static void Respond(string message)
    {
        Console.ForegroundColor = ConsoleColor.White;
        for (int i = 0; i < message.Length; i++)
        {
            Console.Write(message[i]);  
            Thread.Sleep(25); 
        }

        Console.WriteLine();
        Console.ResetColor();
    }

  

}
