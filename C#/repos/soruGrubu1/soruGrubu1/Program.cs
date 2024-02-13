using System;
using System.Collections.Generic

namespace soruGrubu1
{
    class Program
    {
        internal static int Op(char ch)
        {
            switch (ch)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
            }
            return -1;
        }


        public static string infixtopPosfix(string a)
        {
            string sonuc = " ";
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < a.Length; i++)
            {
                char c = a[i];
                if (char.IsLetterOrDigit(c))
                {
                    sonuc += c;
                }

                else if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        sonuc += stack.Pop();
                    }
                    if (stack.Count > 0 && stack.Peek() != '(')
                    {
                        return "gecersiz ifade";
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    if(stack.Count>0 && Op(c)<=Op(stack.Peek()))
                    {
                        sonuc += stack.Pop();
                    }
                    stack.Push(c);
                }
            }
            while(stack.Count>0)
            {
                sonuc += stack.Pop();
            }
            return sonuc;
        }
        static void Main(string[] args)
        {
            string str = "a+b-(a*(a-c))/a-b";
            Console.WriteLine(infixtoPosfix(str));

        }   
    }
}
