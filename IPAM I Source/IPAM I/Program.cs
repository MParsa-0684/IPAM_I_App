using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;


namespace IPAM_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            string command = " ";
            int page = 1;
            int p = 0;
            int ip = 0;
            string Line;
            string ACHRISTMASCAROL;
            string book;
            string name;
            string output2 = " ";
            string input2 = "";
            string mathmark = " ";
            double firstnumber = 0;
            double secondnumber = 0;
            string Sender;
            string Receiver;
            string Q1;
            string Sad = File.ReadAllText("Sad.txt");
            double Response = 0;
            string Up = File.ReadAllText("Up.txt");
            Console.WriteLine(Up);
            Console.WriteLine("          | Hi ! I'm IPAM ! The Helper Artificial intelligence ! |");
            string Down = File.ReadAllText("Down.txt");
            string IPAM;
            Console.WriteLine(Down);
            //  string smile = File.ReadAllText("smile.txt");
            // Console.WriteLine(smile);
            string Kind = "";
            string input = " ";
            string output = " ";
            while (Kind != "Quit")
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                //  Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("                          << How can I help you ? >>  ");
                Console.WriteLine("          << I can help you in Calculating,Conversation,Read book, >>");
                Console.WriteLine("                       << To leave , Write  'Quit' >>");
                Console.Write("                             >> ");

                Kind = Console.ReadLine();
                if (Kind == " Conversation" || Kind == "  Conversation" || Kind == "Conversation " || Kind == "Conversation  " || Kind == " Conversation " || Kind == "  Conversation  ")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("           << Please write your talk like this : 'Conversation' >>");

                }
                if (Kind == " Calculating" || Kind == "  Calculating" || Kind == "Calculating " || Kind == "Calculating  " || Kind == " Calculating " || Kind == "  Calculating  ")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("           << Please write your talk like this : 'Calculating' >>");

                }
                if (Kind == " Read book" || Kind == "  Read book" || Kind == "Read book " || Kind == "Read book  " || Kind == " Read book " || Kind == "  Read book  ")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("           << Please write your talk like this : 'Read book' >>");

                }
                if (Kind == "Conversation")
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    //  Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("                       << To leave , Write  'Quit' >>");
                    Console.WriteLine("                     << You can talk to me and enjoy >>   ");
                    Console.WriteLine("    << Please don't write 'Space' in First and last Part of your talks >>");
                    Console.WriteLine("               <<  Please write your first letter , capital >>");
                    Console.WriteLine("                  << Don't write '.' & '!' in your talks >>");
                    while (input != "Quit")
                    {
                        IPAM = "IPAM Knowledge.txt";
                        Console.Write("                      >> ");
                        input = Console.ReadLine();


                        using (StreamReader SR = new StreamReader(IPAM))
                        {

                            while (!SR.EndOfStream)
                            {
                                Line = SR.ReadLine();
                                string[] items = Line.Split(',');


                                if (input == items[0])
                                {

                                    Console.WriteLine("                      << " + items[1] + " >>");
                                    output = items[1];
                                    input2 = items[0];


                                }


                            }

                        }
                        if (input != input2)
                        {
                            output = "nothing";
                        }
                        if (input == "I want to teach you new conversation")
                        {
                            Console.WriteLine("                      << Thank you for your attention >>");
                            Console.Write("         When you say >>");
                            Sender = Console.ReadLine();
                            Console.Write("         I should say >>");
                            Receiver = Console.ReadLine();
                            using (StreamWriter SW = File.AppendText(IPAM))
                            {
                                SW.WriteLine();
                                SW.Write(Sender + "," + Receiver + ",");
                                SW.Close();
                            }

                        }
                        if (input == "What time is it ?" || input == "What is today's date ?")
                        {
                            DateTime localDate = DateTime.Now;
                            DateTime utcDate = DateTime.UtcNow;
                            String[] cultureNames = { "", "en-GB", "te-IR",
                                "de-DE", "ru-RU" };

                            foreach (var cultureName in cultureNames)
                            {
                                var culture = new CultureInfo(cultureName);
                                // Console.WriteLine("{0}:", culture.NativeName);
                                Console.WriteLine("           << Local Date and Time : {0}, {1:G} >>",
                                                  localDate.ToString(culture), localDate.Kind);
                                //    Console.WriteLine("   UTC date and time: {0}, {1:G}\n",
                                //      utcDate.ToString(culture), utcDate.Kind);
                                break;
                            }
                        }
                        using (StreamReader SR = new StreamReader(IPAM))
                        {

                            while (!SR.EndOfStream)
                            {
                                Line = SR.ReadLine();
                                string[] items = Line.Split(',');
                                Console.ForegroundColor = ConsoleColor.DarkRed;

                                if (input == " " + items[0])
                                {
                                    Console.WriteLine("  << Sorry , Please write your talk  like this to continue conversation : '" + items[0] + "' >>");
                                    output2 = items[0];
                                }
                                if (input == "  " + items[0])
                                {
                                    Console.WriteLine("  << Sorry , Please write your talk  like this to continue conversation : '" + items[0] + "' >>");
                                    output2 = items[0];
                                }

                                if (input == items[0] + " ")
                                {
                                    Console.WriteLine("  << Sorry , Please write your talk  like this to continue conversation : '" + items[0] + "' >>");
                                    output2 = items[0];
                                }
                                if (input == items[0] + "  ")
                                {
                                    Console.WriteLine("  << Sorry , Please write your talk  like this to continue conversation : '" + items[0] + "' >>");
                                    output2 = items[0];
                                }
                                if (input == " " + items[0] + " ")
                                {
                                    Console.WriteLine("  << Sorry , Please write your talk  like this to continue conversation : '" + items[0] + "' >>");
                                    output2 = items[0];
                                }
                                if (input == "  " + items[0] + "  ")
                                {
                                    Console.WriteLine("  << Sorry , Please write your talk  like this to continue conversation : '" + items[0] + "' >>");
                                    output2 = items[0];
                                }

                            }
                        }

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        if (output == "nothing" && input != "Quit" && input != "What time is it ?" && input != "What is today's date ?" && input != "I want to teach you new conversation" && output2 == " ")
                        {
                            Console.WriteLine("                      << Sorry , I didn't get that !! >>");
                            Console.WriteLine("                       << Can you teach it to me ?? >>");
                            Console.Write("         When you say >>");
                            Sender = Console.ReadLine();
                            Console.Write("         I should say >>");
                            Receiver = Console.ReadLine();
                            using (StreamWriter SW = File.AppendText(IPAM))
                            {
                                SW.WriteLine();
                                SW.Write(Sender + "," + Receiver + ",");
                                SW.Close();

                            }

                        }
                        output2 = " ";
                        Console.ForegroundColor = ConsoleColor.Black;

                    }
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("            << Please before quit , teach me a new conversation >>");
                    Console.Write("         When you say >>");
                    Sender = Console.ReadLine();
                    Console.Write("         I should say >>");
                    Receiver = Console.ReadLine();
                    using (StreamWriter SW = File.AppendText("IPAM Knowledge.txt"))
                    {
                        SW.WriteLine();
                        SW.Write(Sender + "," + Receiver + ",");
                    }
                    Console.WriteLine(Sad);
                    Console.ResetColor();
                }

                if (Kind == "Calculating")
                {

                    mathmark = " ";
                    firstnumber = 0;
                    secondnumber = 0;
                    string ever = "yes";
                    while (ever == "yes")
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        //    Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;

                        // Console.WriteLine("                       << To leave , Write  'Quit' >>");
                        Console.WriteLine("                    ______________________________________");
                        Console.WriteLine("                    |                                    |");
                        Console.WriteLine("                    |            CALCULATOR              |  ");
                        Console.WriteLine("                    |____________________________________|");
                        Console.WriteLine("                    |||            Part 1              |||");
                        Console.WriteLine("                    |||        your first number       |||");
                        Console.Write("                                     ");
                        firstnumber = double.Parse(Console.ReadLine());
                        Console.WriteLine("                    |____________________________________|");

                        Console.WriteLine("                    ______________________________________");
                        Console.WriteLine("                    |||            Part 2              |||");
                        Console.WriteLine("                    |||         your math mark         |||");
                        Console.Write("                                     ");
                        mathmark = Console.ReadLine();
                        Console.WriteLine("                    |____________________________________|");
                        Console.WriteLine("                    ______________________________________");
                        Console.WriteLine("                    |||            Part 3              |||");
                        Console.WriteLine("                    |||        your second number      |||");
                        Console.Write("                                     ");
                        secondnumber = double.Parse(Console.ReadLine());
                        Console.WriteLine("                    |____________________________________|");
                        Console.WriteLine("                    ______________________________________");
                        Console.WriteLine("                    |||            Part 4              |||");
                        Console.WriteLine("                    |||           Your answer          |||");
                        if (mathmark == "+")
                        {
                            Console.WriteLine("                                     " + (firstnumber + secondnumber) + "                  ");
                            Response = firstnumber + secondnumber;
                        }
                        if (mathmark == "-")
                        {
                            Console.WriteLine("                                     " + (firstnumber - secondnumber) + "                  ");
                            Response = firstnumber - secondnumber;
                        }
                        if (mathmark == "*")
                        {
                            Console.WriteLine("                                     " + (firstnumber * secondnumber) + "                  ");
                            Response = firstnumber * secondnumber;

                        }
                        if (mathmark == "/")
                        {
                            Console.WriteLine("                                     " + (firstnumber / secondnumber) + "                  ");
                            Response = firstnumber / secondnumber;
                        }
                        Console.WriteLine("                    |____________________________________|");
                        Console.WriteLine("                    |||  Thank you for your attention  |||");
                        Console.WriteLine("                    |  Do you want to replay ? yes / no  |");
                        Console.Write("                                     ");
                        ever = Console.ReadLine();
                        Console.WriteLine("                    |____________________________________|");
                        using (StreamWriter SR = File.AppendText("History.txt"))
                        {
                            SR.WriteLine();
                            SR.Write(firstnumber + " " + mathmark + " " + secondnumber + " = " + Response + ",");
                            DateTime localDate = DateTime.Now;
                            DateTime utcDate = DateTime.UtcNow;
                            String[] cultureNames = { "", "en-GB", "te-IR",
                                "de-DE", "ru-RU" };

                            foreach (var cultureName in cultureNames)
                            {
                                var culture = new CultureInfo(cultureName);
                                // Console.WriteLine("{0}:", culture.NativeName);
                                SR.Write(" Local Date & Time: {0} {1:G} ,",
                                                  localDate.ToString(culture), localDate.Kind);
                                //    Console.WriteLine("   UTC date and time: {0}, {1:G}\n",
                                //      utcDate.ToString(culture), utcDate.Kind);
                                break;
                            }

                        }

                    }
                    Console.WriteLine();
                    Console.WriteLine("          << Do you want to see History of calculations ? yes /no >>");
                    Console.Write("                                >> ");
                    Q1 = Console.ReadLine();
                    if (Q1 == "yes")
                    {
                        Console.WriteLine("             ____________________________________________________");
                        Console.WriteLine("             |                                                  |");
                        Console.WriteLine("             |                 CALCULATOR HISTORY               |  ");
                        Console.WriteLine("             |__________________________________________________|");
                        Console.WriteLine("             |                                                  |");

                        using (StreamReader SR = new StreamReader("History.txt"))
                        {
                            while (!SR.EndOfStream)
                            {
                                Line = SR.ReadLine();
                                string[] items = Line.Split(',');
                                Console.WriteLine("             || " + items[1] + " ||");
                                Console.WriteLine("                 " + items[0]);
                                Console.WriteLine("             |                                                  |");
                            }
                        }
                        Console.WriteLine("             |__________________________________________________|");
                        Console.WriteLine(Sad);
                    }

                }
                if (Kind == "Read book")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("                        << Please Choose your Book. >>");
                    Console.WriteLine("                    ______________________________________");
                    Console.WriteLine("                    |                                    |");
                    Console.WriteLine("                    |              Library               |  ");
                    Console.WriteLine("                    |____________________________________|");
                    Console.WriteLine("                    |||      Classical literature      |||");
                    Console.WriteLine("                    |          A CHRISTMAS CAROL         |");
                    Console.WriteLine("                    |____________________________________|");

                    Console.Write("                             >> ");
                    book = Console.ReadLine();
                    if (book == "A CHRISTMAS CAROL")
                    {

                        using (StreamReader Sr = new StreamReader("A CHRISTMAS CAROL.txt"))
                        {


                            ACHRISTMASCAROL = File.ReadAllText("A CHRISTMAS CAROL.txt");
                            string[] Part = ACHRISTMASCAROL.Split('&');
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write(Part[0]);
                            // Console.WriteLine(Part[1]);
                            Console.Write(Part[2]);
                            // Console.WriteLine(Part[3]);
                            Console.Write(Part[4]);
                            Console.WriteLine("                                 <<  Waht page ? >>");
                            Console.WriteLine("                             << To leave , write '0' >>");
                            Console.Write("                                       >> ");
                            p = 7;
                            ip = 7;
                            page = int.Parse(Console.ReadLine());

                            while (page != 0)
                            {
                                if (page == ip)
                                {
                                    Console.WriteLine(Part[p - 1]);
                                    Console.WriteLine("                                 " + Part[p]);
                                    Console.WriteLine();
                                    break;
                                }
                                else
                                {
                                    p = p + 2;
                                    ip++;
                                }

                            }
                            while (command != "Quit")
                            {
                                Console.WriteLine("          << Write command 'Next page' or 'Previous page' or 'Quit' >>");
                                Console.Write("                                      >> ");
                                command = Console.ReadLine();
                                if (command == "Next page")
                                {
                                    p = p + 2;
                                    ip++;
                                    Console.Write(Part[p - 1]);
                                    Console.WriteLine(Part[p]);
                                    Console.WriteLine();

                                }
                                if (command == "Previous page")
                                {
                                    p = p - 2;
                                    ip = ip - 1;
                                    Console.Write(Part[p - 1]);
                                    Console.WriteLine(Part[p]);
                                    Console.WriteLine();

                                }

                            }
                        }
                    }
                }
            }
            string Up2 = File.ReadAllText("Up2.txt");
            Console.WriteLine(Up2);
            Console.WriteLine("          |                Goodbye ! Hope to meet !              |");
            string Down2 = File.ReadAllText("Down2.txt");
            Console.WriteLine(Down2);

        }
    }
}
