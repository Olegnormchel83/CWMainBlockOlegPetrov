using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


string[] array_of_words_1 = {"Hello", "2", "world", ":-)"};
string[] array_of_words_2 = {"1234", "1567", "-2", "computer science"};
string[] array_of_words_3 = {"Russia", "Denmark", "Kazan"};

void check_words_array(string[] arr)
{
    int count_words = 0, count_symbols = 0;

    Console.WriteLine("Массив 1: ");
    foreach (string word in array_of_words_1)
    {
        count_words++;
        count_symbols = word.Length;
        if (count_symbols <= 3)
        {
            Console.WriteLine($"[{word}]");
        }
    }
}

check_words_array(array_of_words_1);

