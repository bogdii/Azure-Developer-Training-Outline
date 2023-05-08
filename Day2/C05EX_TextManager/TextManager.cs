using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05EX_TextManager
{
    internal class TextManager
    {
        private string sentence;
        public void LoadSentence(string sentence)
        {
            this.sentence = sentence;
        }

        public string GetLongestWord()
        {
            if (sentence == null || sentence.Length == 0)
            {
                throw new InvalidOperationException("Sentence is empty or whitespace.");
            }

            string[] words = sentence.Split(new char[] { ' ' });
            if (words.Length == 0)
            {
                throw new InvalidOperationException("Sentence contains no words.");
            }

            string longestWord = words[0];
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > longestWord.Length)
                {
                    longestWord = words[i];
                }
            }

            return longestWord;
        }

        public string[] GetAllLongestWords()
        {
            if (sentence == null || sentence.Length == 0)
            {
                throw new InvalidOperationException("Sentence is empty or whitespace.");
            }

            string[] words = sentence.Split(new char[] { ' ' });
            if (words.Length == 0)
            {
                throw new InvalidOperationException("Sentence contains no words.");
            }

            int maxLength = 0;
            foreach (string word in words)
            {
                if (word.Length > maxLength)
                {
                    maxLength = word.Length;
                }
            }

            List<string> longestWords = new List<string>();
            foreach (string word in words)
            {
                if (word.Length == maxLength)
                {
                    longestWords.Add(word);
                }
            }

            return longestWords.ToArray();
        }
    }
}
