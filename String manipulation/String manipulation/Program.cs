using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Count_words();
        }
        private static void Count_words()
        {
            
            string Text = "O rato roeu a roupa do rei de roma";
            char[] count_text = Text.ToCharArray();

            int count_letter = 0;
            int count_word = 0;
            /*
            foreach(char caracter in count_text)
            {
                if (caracter != ' ')
                {
                    count_letter += 1;

                    if (count_letter >= 1)
                    {
                        count_word += 1;
                        Console.Write("Number of words: {0}: letras {1}", count_word, count_letter);
                    }


                }                       
                                 
            }*/
           
            Console.ReadLine();

            int i = 0;
            while (count_text[i] != ' ')
            {
                count_word += 1;
                i++;
                for (int j = 0; j < count_text[i]; j++)
                {

                }
            }

      
            /*
                Console.WriteLine("Please write a sentence:\t ");
                string text = Console.ReadLine();

                int wordCount;
                int charCount;

                for (int i = 0; i < text.Length; i++)
                {
                    wordCount = text.Split(' ').Length;
                    
                        char[] countText = text.ToCharArray();
                        //charCount = text.Length;
                    }

                    Console.WriteLine(countText);
                    Console.WriteLine("\n");

                    Console.WriteLine("The Number of Words are:\t" + wordCount);
                    Console.WriteLine("The Number of Characters are:\t" + charCount);
                    Console.ReadLine();
                    */
                
            }
        }
    }
    

