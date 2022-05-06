using System;
using System.Text;

int p = 10; // Указываем количество элементов в массиве
int[] initial = new int[p];
int o = 0;
int e = 0;
string alphabet = "abcdefghijklmnopqrstuvwxyz";

Console.Write(alphabet);
Console.WriteLine();

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

for (int i = 0; i < p; i++)
{
    int с = initial[i];

    if (initial[i] % 2 == 0)
    {
        even[i] = с;
    }
}

Console.Write("Четный массив:" + " ");

foreach (int i in even)
{
    Console.Write(i + " ");
}

Console.WriteLine(" ");

int[] odd = new int[p];         // Ввод нечетного массива

for (int i = 0; i < p; i++)
{
    int x = initial[i];

    if (initial[i] % 2 != 0)
    {
        odd[i] = x;
    }
}

Console.Write("Нечетный массив:" + " ");

foreach (int i in odd)
{
    Console.Write(i + " ");
}

Console.WriteLine(" ");

string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

char[] first = new char[o];
