using System;
using System.Text;

int p = 10; // Указываем количество элементов в массиве
int[] initial = new int[p];
int o = 0;
int e = 0;

for (int i = 0; i < initial.Length; i++)
{
    initial[i] = new Random().Next(1, 26);

    if (initial[i] % 2 == 0)
    {
        e++;
    }
    else
    {
        o++;
    }
}

Console.Write("Изначальный массив:" + " ");

foreach (int i in initial)
{
    Console.Write(i + " ");
}

Console.WriteLine(" ");

int[] even = new int[p];        // Ввод четного массива
int[] odd = new int[p];         // Ввод нечетного массива

for (int i = 0; i < p; i++)
{
    int с = initial[i];

    if (initial[i] % 2 == 0)
    {
        even[i] = с;
    }
    else
    {
        odd[i] = initial[i];
    }
}

Console.Write("Четный массив:" + " ");

foreach (int i in even)
{
    Console.Write(i + " ");
}

Console.WriteLine(" ");

char[] first = new char[o];

string alphabet = "/abcdefghijklmnopqrstuvwxyz";
string[] letters = { " ", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

foreach (string ok in letters)
{
    string test = ok;
    var pos = alphabet.IndexOf(test);
    for (int i = 0; i < p; i++)
    {
        int once = even[i];
        if (even[i] == pos)
        {
            first[i] = pos;
        }
    }
}