using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correct = true;
            Console.Write("Введите текст: "); 
            string text = Console.ReadLine();

            Stack<string> brace = new Stack<string>();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    brace.Push(")");
                }
                else if (text[i] == '[')
                {
                    brace.Push("]");
                }
                else if (text[i] == '{')
                {
                    brace.Push("}");
                }
                else if (text[i] == ')')
                {
                    try
                    {
                        if (brace.Peek() == ")")
                        {
                            brace.Pop();
                        }
                        else
                        {
                            correct = false;
                        }
                    }
                    catch (System.InvalidOperationException)
                    {
                        correct = false;
                    }
                }
                else if (text[i] == ']')
                {
                    try
                    {
                        if (brace.Peek() == "]")
                        {
                            brace.Pop();
                        }
                        else
                        {
                            correct = false;
                        }
                    }
                    catch (System.InvalidOperationException)
                    {
                        correct = false;
                    }
                }
                else if (text[i] == '}')
                {
                    try
                    {
                        if (brace.Peek() == "}")
                        {
                            brace.Pop();
                        }
                        else
                        {
                            correct = false;
                        }
                    }
                    catch (System.InvalidOperationException)
                    {
                        correct = false;
                    }
                }
            }

            if (brace.Count != 0)
            {
                correct = false;
            }

            if (correct)
            {
                Console.WriteLine("Скобки расставлены правильно.");
            }
            else
            {
                Console.WriteLine("Скобки расставлены неправильно.");
            }

            Console.ReadKey();

        }
    }
}
