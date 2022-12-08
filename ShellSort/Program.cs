using System;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(10); // Сортировка Шелла
            stack.Push(1);
            stack.Push(5);
            stack.Push(4);
            stack.Push(7);
            stack.Push(2);
            stack.Push(8);
            stack.Push(9);
            stack.Push(0);
            stack.Push(3);
            stack.Push(6);

            foreach (var st in stack)
            {
                Console.WriteLine(st);
            }


            int len = stack.Size / 2;
            while (len >= 1)
            {
                for (int i = len; i < stack.Size; i++)
                {
                    int j = i;
                    while ((j >= len) && (stack.Get(j - len) > stack.Get(j)))
                    {
                        int temp = stack.Get(j);
                        stack.Set(j, stack.Get(j - len));
                        stack.Set(j - len, temp);
                        j -= len;
                    }
                }

                len /= 2;
            }

            Console.WriteLine("---------");

            foreach (var st in stack)
            {
                Console.WriteLine(st);
            }

            Console.Read();
        }
    }
}
