using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        private static String PrintHelp()
        {
            String help = "";
            help += Environment.NewLine;
            help += "base64tool.exe is designed to encode and decode UTF-16 format which can be used in Microsoft Active Directory 'unicodePwd' value. USAGE:";
            help += Environment.NewLine;
            help += Environment.NewLine;
            help += "base64tool [mode [-e | -d]] [string] [OPTIONAL: > mystring.txt]";
            help += Environment.NewLine;
            help += Environment.NewLine;
            help += "\t -e \t\t encode the string";
            help += Environment.NewLine;
            help += "\t -d \t\t decode the string";
            help += Environment.NewLine;
            help += "\t string \t string to encode or decode" + Environment.NewLine;
            help += "\t\t\t (must be enclosed double quotes [eg. \"\"\"Password1\"\"\"])";
            help += Environment.NewLine;
            help += "\t > mystring.txt  write output to a text file named 'mystring.txt'";
            return help;
        }

        static void Main(string[] args)
        {
            Encoding u16LE = Encoding.Unicode;
            Encoding u16BE = Encoding.BigEndianUnicode;
            System.Text.Decoder utf16Decode = u16LE.GetDecoder();

            string arg0 = "";
            string arg1 = "";

            if (args.Length == 2)
            {
                arg0 = args[0];
                arg1 = args[1];

                switch (arg0)
                {
                    case "-e":
                        Console.WriteLine(Convert.ToBase64String(u16LE.GetBytes(arg1.ToCharArray())));
                        break;
                    case "-d":
                        byte[] toDecodeByte = Convert.FromBase64String(arg1.Trim());
                        int charCount = utf16Decode.GetCharCount(toDecodeByte, 0, toDecodeByte.Length);
                        char[] decodedChar = new char[charCount];
                        utf16Decode.GetChars(toDecodeByte, 0, toDecodeByte.Length, decodedChar, 0);
                        string t = new String(decodedChar);
                        Console.WriteLine(t);
                        break;
                    case "-h":
                        Console.WriteLine(PrintHelp());
                        break;
                    case "/?":
                        Console.WriteLine(PrintHelp());
                        break;
                    case "?":
                        Console.WriteLine(PrintHelp());
                        break;
                    case "-help":
                        Console.WriteLine(PrintHelp());
                        break;
                    case "help":
                        Console.WriteLine(PrintHelp());
                        break;
                    default:
                        Console.WriteLine(PrintHelp());
                        break;
                }
            }
            else if (args.Length == 1)
            {
                arg0 = args[0];

                switch (arg0)
                {
                    case "-e":
                        Console.WriteLine("Missing string");
                        break;
                    case "-d":
                        Console.WriteLine("Missing string");
                        break;
                    case "-h":
                        Console.WriteLine(PrintHelp());
                        break;
                    case "/?":
                        Console.WriteLine(PrintHelp());
                        break;
                    case "?":
                        Console.WriteLine(PrintHelp());
                        break;
                    case "-help":
                        Console.WriteLine(PrintHelp());
                        break;
                    case "help":
                        Console.WriteLine(PrintHelp());
                        break;
                    default:
                        Console.WriteLine(PrintHelp());
                        break;
                }
            }
            else
                Console.WriteLine(PrintHelp());



            Console.WriteLine(Environment.NewLine); 
            Console.WriteLine(Environment.NewLine);
            //Console.WriteLine("Press a key when finished.");
            //Console.ReadLine();
        }


    }
}
