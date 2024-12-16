using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class answerstolaba4 : SupportForLab4
    {
        public static void level1()
        {
            Console.WriteLine("Введите предложение, завершонное точкой.");
            string input = Console.ReadLine();

            if (input == null || !input.EndsWith("."))
            {
                Console.WriteLine("Error:предложение должно заканчиваться точкой.");
            }

            Console.WriteLine("Первый способ (обработка строки как массива символов)");
            FindUnigueCharsusingArray(input);

            Console.WriteLine("Второй способ(методы класса string");
            FindUnigueCharsusingMethods(input);











        }
        public static void level2()
        {
            Console.WriteLine("Введите предложение, завершонное точкой. ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input) || !input.EndsWith("."))
            {
                Console.WriteLine("Ошибка:предложение должно заканчиваться точкой. ");
            }
            Console.WriteLine("Первый способ (обработка строки как массива символов )");
            string resultUsigArray = FormaStringUsingArray(input);
            Console.WriteLine(resultUsigArray);


            Console.WriteLine("второй способ (методы класса string)");
            string A = FormaStringUsingMethods(input);
            Console.WriteLine(A);







        }
        public static void level3()
        {
            Console.WriteLine("Введите тескт из нескольких слов, завершенный точкой.");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input) || !input.EndsWith("."))
            {
                Console.WriteLine("Error:Текст доолжен заканчиваться точкой");
                return;
            }

            Console.WriteLine("Первый способ (обработка строки как массива символов)");
            string reversedUsingArray = ReverseWordsUsingArray(input);
            Console.WriteLine(reversedUsingArray);

            Console.WriteLine("\n Второй способ (использование классов string  and StringBuilder)");
            string ReversedUsingBuilder = ReverseWordsUsingStringBuilder(input);
            Console.WriteLine(ReversedUsingBuilder);
        }


        public static void level4()
        {
            Console.WriteLine("Введите 7 строк текста");
            string[] lines = new string[7];
            for (int i = 0; i < 7; i++)
            {
                lines[i] = Console.ReadLine();
            }

            Console.WriteLine("\nПервый способ (обработка строки как массива символов )");
            FindlinesWithComAndMinSpacesUsingArray(lines);


            Console.WriteLine("\nВторой способ (методы класса string)");
            FindlinesWithComAndMinSpacesUsingStringMethods(lines);


        }
        public static void level5()
        {
            Console.WriteLine("Введите текст");
            string input = Console.ReadLine();

            Console.WriteLine("\n Первый способ ");
            FindWordsYsingArray(input);


            Console.WriteLine("\n Второй спосб ");
            FindWordsUsingRegex(input);
        }
        public static void level6()
        {
            Console.WriteLine("Введите выражение вида 'число+число=число '(  без пробелам, возможны отрицательные чифры  ");
            string input = Console.ReadLine();

            string pattern = @"\s*(-?\d+)s*\+\s*(-?\d+)\s*=\s*(-?\d+)\s*";

            Match match = Regex.Match(input, pattern);

            if (match.Success)
            {
                int operand1 = int.Parse(match.Groups[1].Value);
                int operand2 = int.Parse(match.Groups[2].Value);
                int result = int.Parse(match.Groups[3].Value);


                Console.WriteLine($"Первое число:{operand1}");
                Console.WriteLine($"Второе число:{operand2}");
                Console.WriteLine($"Результат {result}");

                if (operand1 + operand2 == result)
                {
                    Console.WriteLine("Сумма правельная ");
                }
                else
                {
                    Console.WriteLine("Error:Сумма неверная ");
                }
            }
            else
            {
                Console.WriteLine("Error:Строка не соответствует формату (число+число=число)");
            }


        }
        public static void level7()
        {
            string[] tracklist =
            {
                "Gentle Giant – Free Hand [6:15]",
                "Supertramp – Child Of Vision[07:27]",
                "Camel – Lawrence[10:46]",
                "Yes – Don’t Kill The Whale[3:55]",
                "10CC – Notell Hotel[04:58]",
                "Nektar – King Of Twilight[4:16]",
                "The Flower Kings – Monsters & Men[21:19]",
                "Focus – Le Clochard[1:59]",
                "Pendragon – Fallen Dream And Angel[5:23]",
                "Kaipa – Remains Of The Day(08:02)"
            };

            List<Track> tracks = new List<Track>();
            int totalDuration = 0;

            string pettern = @"\[(\d+):(\d+)\]|\((\d+):(\d+)\)";

            foreach (string line in tracklist)
            {
                Match match = Regex.Match(line, pettern);

                if (match.Success)
                {
                    int minutes = int.Parse(match.Groups[1].Value != "" ? match.Groups[1].Value : match.Groups[3].Value);
                    int seconds = int.Parse(match.Groups[2].Value != "" ? match.Groups[2].Value : match.Groups[4].Value);

                    int durationInSeconds = minutes * 60 + seconds;
                    totalDuration += durationInSeconds;



                    tracks.Add(new Track(line, durationInSeconds));

                }
            }
            Track longestTrack = null;
            Track ShortestTrack = null;
            foreach (Track track in tracks)
            {
                if (longestTrack == null || track.DurationInSeconds > longestTrack.DurationInSeconds)
                {
                    longestTrack = track;
                }
                if (ShortestTrack == null || track.DurationInSeconds < longestTrack.DurationInSeconds)
                {
                    ShortestTrack = track;
                }
            }

            Track minDiffTracck1 = null;
            Track minDiffTracck2 = null;
            int minDifference = int.MaxValue;

            for (int i = 0; i < tracks.Count; i++)
            {
                for (int j = i + 1; j < tracks.Count; j++)
                {
                    int difference = Math.Abs(tracks[i].DurationInSeconds - tracks[j].DurationInSeconds);
                    if (difference < minDifference)
                    {
                        minDifference = difference;
                        minDiffTracck1 = tracks[i];
                        minDiffTracck2 = tracks[j];
                    }
                }
            }
            Console.WriteLine("Общее время звучания всех песен:" + FormatTime(totalDuration));
            Console.WriteLine("Самая длинная песня:" + longestTrack.Title + $"( + {FormatTime(longestTrack.DurationInSeconds)})");
            Console.WriteLine("Самая короткая песня:" + ShortestTrack.Title + $"( + {FormatTime(ShortestTrack.DurationInSeconds)})");
            Console.WriteLine("Пара песен с минимальной разницей во время звучания");
            Console.WriteLine($"1. {minDiffTracck1.Title}({FormatTime(minDiffTracck1.DurationInSeconds)})");
            Console.WriteLine($"2. {minDiffTracck2.Title}({FormatTime(minDiffTracck2.DurationInSeconds)})");
            Console.WriteLine("Разница во времени" + FormatTime(minDifference));





        }
        public static void level8()
        {

        }
        public static void level9()
        {
           
                Console.WriteLine("Введите текст:");
                string inputText = Console.ReadLine();

                if (inputText != null)
                {
                    string newText = ReplaceWords(inputText);
                    Console.WriteLine("Преобразованный текст:");
                    Console.WriteLine(newText);
                }
                else
                {
                    Console.WriteLine("Ввод пуст.");
                }


               
            
        }
            
            public static void level10()
            {
                Console.WriteLine("Введите текст : ");
                string s = Console.ReadLine();
                Regex data = new Regex(@"(\b\d{2}-\d{2}-\d{4}\b)");
                MatchCollection matches = data.Matches(s);
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }

        
    }
}






    
 
