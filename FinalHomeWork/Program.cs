
//Метод выводящий строковый массив на печать
void PrintArray(string[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");        
    }
    Console.WriteLine();
}

//Метод который принимает массив строк и
//возвращает слова в которых 3 символа и меньше

string[] FindStringsGivenLength(string[] words, int wordLength)
{
    int counter = 0;

    for(int i = 0; i < words.Length; i++)
    {
        if(words[i].Length <= wordLength)
        {
            counter++;
        }               
    }

    string[] names = new string[counter];

    for(int i = 0, j = 0; i < words.Length; i++)
    {
        if(words[i].Length <= wordLength)
        {   
            names[j] = words[i];
            j++;
        }                
    }
    return names;
}

int wordLength  = 3;
string[] words = {"Leonid", "Natalya", "Maxim", "Lubov", "Tom", "John", "Jan"};

PrintArray(words);
words = FindStringsGivenLength(words, wordLength);
PrintArray(words);