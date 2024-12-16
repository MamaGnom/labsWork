using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp5
{
    internal class SupportForLab4
    {
        protected static void FindUnigueCharsusingArray(string text)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in text)
            {
                if (char.IsLetterOrDigit(c)) //учитывает только цифры и буквыchar
                {
                    if (charCount.ContainsKey(c))
                    {
                        charCount[c]++;
                    }
                    else
                    {
                        charCount[c] = 1;
                    }
                }
            }
            //вывод символов, которые встречаются один раз
            foreach (var item in charCount)
            {
                if (item.Value == 1)
                {
                    Console.Write(item.Key + " ");
                }


            }

            Console.WriteLine();




        }

        protected static void FindUnigueCharsusingMethods(string text)
        {
            var unigueChar = text
                .Where(c => char.IsLetterOrDigit(c))
                .GroupBy(c => c)
                .Where(g => g.Count() == 1)
                .Select(g => g.Key);

            foreach (char c in unigueChar)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();












        }

        protected static string FormaStringUsingArray(string text)
        {
            StringBuilder result = new StringBuilder();
            int wordCount = 0;
            bool inWord = false;

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                if (char.IsLetterOrDigit(c))
                {
                    if (!inWord)
                    {
                        wordCount++;
                        inWord = true;
                        result.Append(c);
                    }
                    else
                    {
                        result.Append(c);
                    }
                }
                else
                {

                    if (inWord)
                    {

                        result.Append($"({wordCount})");
                        inWord = false;

                    }
                    result.Append(c);


                }
            }

            if (inWord)
            {
                result.Append($"({wordCount})");

            }

            return result.ToString();














        }

        protected static string FormaStringUsingMethods(string text)
        {
            string textWithoutPeriod = text.TrimEnd('.');


            string[] words = Regex.Split(textWithoutPeriod, @"(\s+|,|-)");

            StringBuilder result = new StringBuilder();
            int wordCount = 0;

            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word) && Regex.IsMatch(word, @"\w+"))
                {

                    wordCount++;
                    result.Append($"{word}({wordCount})");
                }
                else
                {
                    result.Append(word);
                }
            }

            result.Append(".");
            return result.ToString();





        }

        protected static string ReverseWordsUsingArray(string text)
        {
            text = text.TrimEnd(',');
            char[] charArray = text.ToCharArray();
            StringBuilder word = new StringBuilder();
            StringBuilder result = new StringBuilder();

            var words = new System.Collections.Generic.List<string>();


            for (int i = 0; i < charArray.Length; i++)
            {

                if (charArray[i] != ' ')
                {
                    word.Append(charArray[i]);
                }
                else if (word.Length > 0)
                {
                    words.Add(word.ToString());
                    word.Clear();
                }

            }

            if (word.Length > 0)
            {
                words.Add(word.ToString());
            }

            for (int i = words.Count - 1; i >= 0; i--)
            {
                result.Append(words[i]);
                if (i != 0)
                {
                    result.Append(" ");
                }

            }
            result.Append(".");
            return result.ToString();











        }

        protected static string ReverseWordsUsingStringBuilder(string text)
        {
            text = text.TrimEnd('.');
            string[] words = text.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(words);

            StringBuilder result = new StringBuilder();
            result.Append(string.Join(" ", words));
            result.Append(".");

            return result.ToString();








        }

        protected static void FindlinesWithComAndMinSpacesUsingArray(string[] lines)
        {
            int minSpacesIndex = -1;

            int minSpaceCount = int.MaxValue;

            Console.WriteLine("Строки,содержащие хотя бы одно слово, оканчивающееся на .com");
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                bool hasComWord = false;
                int spaceCount = 0;
                //  int wordEnd = -1;

                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] == ' ')
                    {
                        spaceCount++;
                    }

                    if (j >= 3 && line[j - 3] == '.' && line.Substring(j - 2, 3).ToLower() == "com")
                    {
                        hasComWord = true;
                    }

                    if (spaceCount < minSpacesIndex)
                    {
                        minSpaceCount = spaceCount;
                        minSpacesIndex = 1;
                    }
                }

                if (hasComWord)
                {
                    Console.WriteLine(line);
                }


            }
            Console.WriteLine($"Номер строки с наименьшим  числом пробелов:{minSpacesIndex + 1}");

        }

        protected static void FindlinesWithComAndMinSpacesUsingStringMethods(string[] lines)
        {
            int minSpacesIndex = -1;
            int minSpaceCount = int.MaxValue;

            Console.WriteLine("Строки, содержащие хотя бы одно слово , заканчивающееся на .com");
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];


                if (Regex.IsMatch(line, @"\b\w+\.com\b", RegexOptions.IgnoreCase))
                {
                    Console.WriteLine(line);
                }

                int spaceCount = line.Split(' ').Length - 1;
                if (spaceCount < minSpaceCount)
                {

                    minSpaceCount = spaceCount;
                    minSpacesIndex = i;
                }



            }
            Console.WriteLine($"Номер строки с наименьшим числом пробелов:{minSpacesIndex + 1}");



        }

         protected static void FindWordsYsingArray(string text)
          {
              var words = new System.Collections.Generic.List<string>();
              StringBuilder word = new StringBuilder();

              for (int i = 0; i < text.Length; i++)
              {
                  char c = text[i];

                  if (char.IsLetterOrDigit(c))
                  {
                      word.Append(c);
                  }
                  else
                  {

                      if (word.Length > 0 && IsValidWord(word.ToString()))
                      {
                          words.Add(word.ToString());
                      }
                      word.Clear();
                  }
              }

              if (word.Length > 0 && IsValidWord(word.ToString()))
              {
                  words.Add(word.ToString());
              }
              Console.WriteLine("Найденные слова:");
              foreach (var foundWord in words)
              {
                  Console.WriteLine($"{foundWord}");



              }
          }
           static bool IsValidWord(string word)
          {
              if (word.Length >= 3 &&
                  char.IsUpper(word[0]) &&
                  char.IsDigit(word[^1]) &&
                  char.IsDigit(word[^2]))
              {
                  return true;

              }
              return false;

           }

        protected static void FindWordsUsingRegex(string text)
        {
            string pettern = @"\b[A-Z][a-zA-Z]*\d{2}\b";
            MatchCollection matches = Regex.Matches(text, pettern);

            Console.WriteLine("Найденные слова");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

        }

        public class Track
        {
            public string Title { get; set; }

            public int DurationInSeconds { get; set; }

            public Track(string title, int durationInSeconds)
            {
                DurationInSeconds = durationInSeconds;
            }


        }

        protected static string FormatTime(int totalSecons)
        {

            int minutes = totalSecons/60;
            int seconds = totalSecons%60;
            return $"{minutes:D2}:{seconds:D2}";
        }

        public static string ReplaceWords(string text)
        {
            // Регулярное выражение для поиска слов "and" или "or" (независимо от регистра)
            string pattern = @"\b(and|or)\b";
            // Замена "and" на "&" и "or" на "|" с использованием регулярного выражения
            string replacedText = Regex.Replace(text, pattern, m =>
            {
                if (m.Value.Equals("and", StringComparison.OrdinalIgnoreCase))
                {
                    return "&";
                }
                else if (m.Value.Equals("or", StringComparison.OrdinalIgnoreCase))
                {
                    return "|";
                }
                else
                {
                    return m.Value; // Возвращаем исходное слово, если что-то пошло не так
                }
            }, RegexOptions.IgnoreCase);

            return replacedText;
        }

    }
}






































    

