using System;
using System.Collections.Generic;

namespace WordCloudData
{
    class Program
    {
        static void Main(string[] args)
        {
            // var text = "We came, we saw, we conquered...then we ate Bill's (Mille-Feuille) cake.";
            var text = "Dessert - mille-feuille cake.";
            var actual = new WordCloudData(text);

            Console.WriteLine("Hello World!");
        }

    }
    public class WordCloudData
    {
        private Dictionary<string, int> _wordsToCounts = new Dictionary<string, int>();

        public IDictionary<string, int> WordsToCounts
        {
            get { return _wordsToCounts; }
        }

        public WordCloudData(string inputString)
        {
            PopulateWordsToCounts(inputString);
        }

        private void PopulateWordsToCounts(string inputString)
        {
            // Count the frequency of each word
            SplitStringIntoWords(inputString);
        }

        private void SplitStringIntoWords(string inputString)
        {
            var words = new List<string>();
            int count = 0;
            int currentWordLength = 0;
            int currentWordStartIndex = 0;

            foreach (var c in inputString)
            {
                if (count == inputString.Length - 1)
                {
                    if (Char.IsLetter(c))
                    {
                        currentWordLength++;
                    }
                    if (currentWordLength > 0)
                    {
                        var currentWord = inputString.Substring(currentWordStartIndex, currentWordLength);
                        AddWordToDictionary(currentWord);
                        currentWordLength = 0;
                    }
                }
                else if (Char.IsLetter(c) || c == '\'')
                {
                    if (currentWordLength == 0)
                    {
                        currentWordStartIndex = count;
                    }
                    currentWordLength++;
                }
                else if (c == '.' && count < inputString.Length - 1 && inputString[count + 1] == '.')
                {
                    if (currentWordLength > 0)
                    {
                        var currentWord = inputString.Substring(currentWordStartIndex, currentWordLength);
                        AddWordToDictionary(currentWord);
                        currentWordLength = 0;
                    }

                }
                else if (count > 0 && c == '-')
                {
                    if (Char.IsLetter(inputString[count - 1]) && Char.IsLetter(inputString[count + 1]))
                    {
                        if (currentWordLength == 0)
                        {
                            currentWordStartIndex = count;
                        }
                        currentWordLength++;
                    }
                    else
                    {
                        if (currentWordLength > 0)
                        {
                            var currentWord = inputString.Substring(currentWordStartIndex, currentWordLength);
                            AddWordToDictionary(currentWord);
                            currentWordLength = 0;
                        }
                    }
                }
                else if (Char.IsWhiteSpace(c))
                {
                    if (currentWordLength > 0)
                    {
                        var currentWord = inputString.Substring(currentWordStartIndex, currentWordLength);
                        AddWordToDictionary(currentWord);
                        currentWordLength = 0;
                    }
                }
                count++;
            }
        }
        private void AddWordToDictionary(string word)
        {
            var titleCase = ToTitleCase(word);
            // Title case version of the word is in the dictionary
            if (_wordsToCounts.ContainsKey(word))
            {
                _wordsToCounts[word]++;
            }
            else if (_wordsToCounts.ContainsKey(word.ToLower()))
            {
                _wordsToCounts[word.ToLower()]++;
            }
            else if (_wordsToCounts.ContainsKey(titleCase))
            {
                var titleCaseCount = _wordsToCounts[titleCase];
                _wordsToCounts.Add(word.ToLower(), titleCaseCount + 1);
                _wordsToCounts.Remove(titleCase);
            }
            else
                _wordsToCounts.Add(word, 1);
        }
        private string ToTitleCase(string word)
        {
            return word.Substring(0, 1).ToUpper() + word.Substring(1);
        }
    }
}
