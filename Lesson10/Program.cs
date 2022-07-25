//Метод который принимает массив строк и
//возвращает количество слов в которых больше 5-и символов

int LongWordCounter(string[] words, int wordLength)
{
    int counter = 0;

    for(int i = 0; i < words.Length; i++)
    {
        if(words[i].Length >= wordLength)
        {
            counter++;
        } 
        
               
    }
    return counter;

}
int count  = 5;
string[] names = {"Leonid", "Natalya", "Maxim", "Lubov", "Tom", "John", "Jan"};

Console.WriteLine("Number of long words is " + LongWordCounter(names, count));

