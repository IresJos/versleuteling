using System;
using System.IO;

namespace TekstVersleutelen
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Aan = true;
            bool opslaan = false;
            string text = "";
            Console.WriteLine("Druk op ']' om te stoppen");
            Console.WriteLine("Druk op '[' om het bestand op te slaan.");
            while (Aan)
            {
                Console.WriteLine("Voer de text in die gecodeerd moet worden.");
                string invoer = Console.ReadLine();
                for (int i = 0; i < invoer.Length; i++)
                {
                    switch (invoer[i])
                    {
                        case ' ':
                            break;
                        case 'a':
                        case 'b':
                        case 'c':
                            text += "2";
                            break;
                        case 'd':
                        case 'e':
                        case 'f':
                            text += "3";
                            break;
                        case 'g':
                        case 'h':
                        case 'i':
                            text += "4";
                            break;
                        case 'j':
                        case 'k':
                        case 'l':
                            text += "5";
                            break;
                        case 'm':
                        case 'n':
                        case 'o':
                            text += "6";
                            break;
                        case 'p':
                        case 'q':
                        case 'r':
                        case 's':
                            text += "7";
                            break;
                        case 't':
                        case 'u':
                        case 'v':
                            text += "8";
                            break;
                        case 'w':
                        case 'x':
                        case 'y':
                        case 'z':
                            text += "9";
                            break;
                        case 'A':
                        case 'B':
                        case 'C':
                            text += "2";
                            break;
                        case 'D':
                        case 'E':
                        case 'F':
                            text += "3";
                            break;
                        case 'G':
                        case 'H':
                        case 'I':
                            text += "4";
                            break;
                        case 'J':
                        case 'K':
                        case 'L':
                            text += "5";
                            break;
                        case 'M':
                        case 'N':
                        case 'O':
                            text += "6";
                            break;
                        case 'P':
                        case 'Q':
                        case 'R':
                        case 'S':
                            text += "7";
                            break;
                        case 'T':
                        case 'U':
                        case 'V':
                            text += "8";
                            break;
                        case 'W':
                        case 'X':
                        case 'Y':
                        case 'Z':
                            text += "9";
                            break;
                        case '1':
                            text += "a";
                            break;
                        case '2':
                            text += "b";
                            break;
                        case '3':
                            text += "c";
                            break;
                        case '4':
                            text += "d";
                            break;
                        case '5':
                            text += "e";
                            break;
                        case '6':
                            text += "f";
                            break;
                        case '7':
                            text += "g";
                            break;
                        case '8':
                            text += "h";
                            break;
                        case '9':
                            text += "i";
                            break;
                        case '0':
                            text += "j";
                            break;
                        case '!':
                            text += "k";
                            break;
                        case ',':
                            text += "l";
                            break;
                        case '.':
                            text += "m";
                            break;
                        case '@':
                            text += "n";
                            break;
                        case '#':
                            text += "o";
                            break;
                        case '$':
                            text += "p";
                            break;
                        case '€':
                            text += "q";
                            break;
                        case '%':
                            text += "r";
                            break;
                        case '&':
                            text += "s";
                            break;
                        case '(':
                            text += "t";
                            break;
                        case ')':
                            text += "u";
                            break;
                        case '?':
                            text += "v";
                            break;
                        case '/':
                            text += "w";
                            break;
                        case '+':
                            text += "x";
                            break;
                        case '=':
                            text += "y";
                            break;
                        case '*':
                            text += "z";
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
            }   if (!opslaan)
            {
                TextOpslaan(text);
            }         
        }
        static void TextOpslaan(string text)
        {
            StreamWriter opgeslagenTekst = File.CreateText("versleuteling.txt");
            opgeslagenTekst.WriteLine(text);
            opgeslagenTekst.Close();
        }
    }
}
