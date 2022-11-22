using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////LastIndexOf metodu
            //string word = "Zamin";
            //char search = 'i';

            //for (int i = word.Length-1; i >=0; i--)
            //{
            //    if (word[i] ==search)
            //    {
            //        Console.WriteLine(i);
            //    }  
            //}

            //-----------------------------------------------------------------------------------------------
            ////contains metodu

            //string word = "World";
            //string[] words = new[] { "Hello", "World" };
            //bool k = false;

            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (word.Length == words[i].Length)
            //    {
            //        k = true;

            //        for (int j = 0; j < words[i].Length; j++)
            //        {
            //            k &= word[j] == words[i][j];

            //            if (!k)
            //            {
            //                break;
            //            }
            //        }
            //    }

            //    if (k)
            //    {
            //        break;
            //    }
            //}

            //Console.WriteLine(k.ToString());

            //-------------------------------------------------------------------------------------------------
            ////Replace metodu
            //string word = "Zamin";
            //string word2 = "";
            //char firstchar = 'i';
            //char secondchar = 'f';
            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] != firstchar)
            //    {
            //        word2 += word[i];
            //    }
            //    else
            //    {
            //        word2 += secondchar;
            //    }

            //}
            //Console.WriteLine(word2);

            //--------------------------------------------------------------------------------------------------------

            ////substring metodu
            //string word = "Zaminali";
            //string word2 = "";
            //int k = 5;

            //for (int i = k; i < word.Length; i++)
            //{
            //    word2 += word[i];
            //}
            //Console.WriteLine(word2);

            //---------------------------------------------------------------------------------------------------------

            ////trim metodu
            //string word = "                 Zaminali         ";
            //string word2 = "";
            //char space = ' ';

            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] != space)
            //    {
            //        word2 += word[i];
            //    }

            //}
            //Console.WriteLine(word2);
        }
    }
}