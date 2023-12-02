using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


string[] array_of_words_1 = {"Hello", "2", "world", ":-)"};
string[] array_of_words_2 = {"1234", "1567", "-2", "computer science"};
string[] array_of_words_3 = {"Russia", "Denmark", "Kazan"};
var str_1 = string.Join(", ", array_of_words_1);
var str_2 = string.Join(", ", array_of_words_2);
var str_3 = string.Join(", ", array_of_words_3);

void check_words_array(string[] arr)
{
    List<string> words = new List<string>();
    Console.Write("[");
    foreach (string word in arr)
    {     
        if (word.Length <= 3)
        {
            words.Add(word);
        }
    }
    var stroka = string.Join(", ", words);
    Console.Write(stroka + "]");
}

Console.Write("\n" + "[" + str_1 + "]" + " -> ");
check_words_array(array_of_words_1);
Console.Write("\n" + "[" + str_2 + "]" + " -> ");
check_words_array(array_of_words_2);
Console.Write("\n" + "[" + str_3 + "]" + " -> ");
check_words_array(array_of_words_3);

