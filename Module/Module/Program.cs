﻿using System;

namespace Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] origin = new int[10]; //Указываем количество элементов в массиве
            int o = 0;
            int e = 0;

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

            foreach (int i in origin)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(" ");

            int[] even = new int[o];

            for (int i = 0; i < e; i++)
            {
                int с = origin[i];

                if (origin[i] % 2 == 0)
                {
                    even[i] = с;
                }
            }

            foreach (int i in even)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(" ");

            int[] odd = new int[o];

            for (int i = 0; i < o; i++)
            {
                int x = origin[i];

                if (origin[i] % 2 != 0)
                {
                    odd[i] = x;
                }
            }

            foreach (int i in odd)
            {
                Console.Write(i + " ");
            }
        }
    }
}