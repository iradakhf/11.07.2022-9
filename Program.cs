using System;
using System.Text;
namespace ConsoleApp37
{
    class Program
    {
        public static void Main(string [] args)
        {
            Insertion insertion = new Insertion("Hello, how is it going","Irada");
            insertion.InsertToTheSentence(insertion.Word, insertion.Sentence);
            
        }
        class Insertion
        {
        public string Word { get; set; }
        public string Sentence { get; set; }
            public Insertion(string sentence, string word)
            {
                this.Sentence = sentence;
                    this.Word = word;
            }

            public void InsertToTheSentence(string word, string sentence)
            {
                StringBuilder str = new StringBuilder(sentence,50);
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i]== ' ')
                    {
                        str.Insert(i, word);
                        break;
                    }
                }
                Console.WriteLine(str);
            }
        }


    }
}