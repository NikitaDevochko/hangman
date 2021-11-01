using System;
using System.IO;

namespace Game
{
    class Hangman
    {
        string[] words;
        string stringWord;
        char[] charWord;
        char[] viewWord;
        int openLetters = 0;
        Random random = new Random();

        public int WordLetter => stringWord.Length;
        public bool IsSolved => openLetters == stringWord.Length;
        public string ViewWord => new string(viewWord);
        public string MainWord => stringWord;

        public Hangman(string path)
        {
            words = File.ReadAllLines(path);
        }

        public void GenerateWord()
        {
            stringWord = words[random.Next(0, words.Length)];
            charWord = stringWord.ToCharArray();
            viewWord = new char[stringWord.Length];
            for (int i = 0; i < viewWord.Length; i++)
            {
                viewWord[i] = '*';
            }
        }

        public bool CheckLetter(char letter)
        {
            letter = char.ToLower(letter);
            bool isLetterExist = false;
            for (int i = 0; i < charWord.Length; i++)
            {
                if (charWord[i] == letter)
                {
                    openLetters++;
                    viewWord[i] = letter;
                    charWord[i] = ' ';
                    isLetterExist = true;
                }
            }
            return isLetterExist;
        }
    }
}
