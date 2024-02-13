using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infixtoPosfix
{
    class Program
    {
          internal static int Operant(char ch)
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

         public static string infixtoPosfix(string exp)
        {
            string sonuc = " ";
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < exp.Length; i++)
            {
                
                char c = exp[i];

                if(char.IsLetterOrDigit(c))
                {
                    sonuc += c;

                }
                else if( c=='(')
                {
                    stack.Push(c);
                }
                else if (c==')')
                {
                    while(stack.Count>0 && stack.Peek()!='(')
                    {
                        sonuc += stack.Pop();
                    }
                    if(stack.Count>0 && stack.Peek()!='(')
                    {
                        return "invalid Expression";
                    }
                    else
                    {
                        stack.Pop();
                    }

                }
                else
                {
                    if(stack.Count>0 && Operant(c)<=Operant(stack.Peek()))
                    {
                        sonuc += stack.Pop();
                    }
                    stack.Push(c);
                }
                
            }
            while(stack.Count>0)
            {
                stack.Pop();
            }


            return sonuc;
        }





        static void Main(string[] args)
        {
            string exp = "a+b*(c/d-e)-(f+g*h)-i";
            Console.WriteLine(infixtoPosfix(exp));
            Console.ReadLine();


        }
    }
}
