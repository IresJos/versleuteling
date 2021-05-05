using System;
using System.IO;

namespace GeocachingCode
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Aan = true;
            string text = " ";
            Console.WriteLine("Druk op x om te stoppen");
            while (Aan)
            {
                Console.WriteLine("Voer één cijfer of meerder cijfers in: ");
                string Cijfer = Console.ReadLine();
                for (int i = 0; i < Cijfer.Length; i++)
                {
                    switch (Cijfer[i])
                    {
                        case '2':
                            text += Environment.NewLine + "abc";
                            break;
                        case '3':
                            text += Environment.NewLine + "def";
                            break;
                        case '4':
                            text += Environment.NewLine + "ghi";
                            break;
                        case '5':
                            text += Environment.NewLine + "jkl";
                            break;
                        case '6':
                            text += Environment.NewLine + "mno";
                            break;
                        case '7':
                            text += Environment.NewLine + "pqrs";
                            break;
                        case '8':
                            text += Environment.NewLine + "tuv";
                            break;
                        case '9':
                            text += Environment.NewLine + "wxyz";
                            break;
                        case 'a':
                            text += Environment.NewLine + "1";
                            break;
                        case 'b':
                            text += Environment.NewLine + "2";
                            break;
                        case 'c':
                            text += Environment.NewLine + "3";
                            break;
                        case 'd':
                            text += Environment.NewLine + "4";
                            break;
                        case 'e':
                            text += Environment.NewLine + "5";
                            break;
                        case 'f':
                            text += Environment.NewLine + "6";
                            break;
                        case 'g':
                            text += Environment.NewLine + "7";
                            break;
                        case 'h':
                            text += Environment.NewLine + "8";
                            break;
                        case 'i':
                            text += Environment.NewLine + "9";
                            break;
                        case 'j':
                            text += Environment.NewLine + "0";
                            break;
                        case 'k':
                            text += Environment.NewLine + "!";
                            break;
                        case 'l':
                            text += Environment.NewLine + ",";
                            break;
                        case 'm':
                            text += Environment.NewLine + ".";
                            break;
                        case 'n':
                            text += Environment.NewLine + "@";
                            break;
                        case 'o':
                            text += Environment.NewLine + "#";
                            break;
                        case 'p':
                            text += Environment.NewLine + "$";
                            break;
                        case 'q':
                            text += Environment.NewLine + "€";
                            break;
                        case 'r':
                            text += Environment.NewLine + "%";
                            break;
                        case 's':
                            text += Environment.NewLine + "&";
                            break;
                        case 't':
                            text += Environment.NewLine + "(";
                            break;
                        case 'u':
                            text += Environment.NewLine + ")";
                            break;
                        case 'v':
                            text += Environment.NewLine + "?";
                            break;
                        case 'w':
                            text += Environment.NewLine + "/";
                            break;
                        case 'x':
                            text += Environment.NewLine + "+";
                            break;
                        case 'y':
                            text += Environment.NewLine + "=";
                            break;
                        case 'z':
                            text += Environment.NewLine + "*";
                            break;
                        case ']':
                            Aan = false;
                            break;
                        case '[':
                            TextOpslaan(text);
                            break;
                        default:
                            Console.WriteLine("Foute invoer. Probeer opnieuw");
                            break;
                    }
                }
                Console.WriteLine(text);
            }
            static void TextOpslaan(string text)
            {
                StreamWriter opgeslagenTekst = File.CreateText("ontsleuteling.txt");
                opgeslagenTekst.WriteLine(text);
                opgeslagenTekst.Close();
            }
        }
    }
}
