using System;
using System.Text;

int p = 10; // Указываем количество элементов в массиве
int[] origin = new int[p];
int o = 0;
int e = 0;
string alphabet = "abcdefghijklmnopqrstuvwxyz";

Console.Write(alphabet);
Console.WriteLine();

for (int i = 0; i < origin.Length; i++)
{
    origin[i] = new Random().Next(1, 26);

    if (origin[i] % 2 == 0)
    {
        e++;
    }
    else
    {
        o++;
    }
}

Console.Write("Изначальный массив:" + " ");

foreach (int i in origin)
{
    Console.Write(i + " ");
}

Console.WriteLine(" ");

int[] even = new int[p];        // Ввод четного массива

for (int i = 0; i < p; i++)
{
    int с = origin[i];

    if (origin[i] % 2 == 0)
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
    int x = origin[i];

    if (origin[i] % 2 != 0)
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
for (int i = 0; i < o; i++)
{
    int u =odd[i]
    if ( = u)
    {
        first[i] = letters[i];
    }
}