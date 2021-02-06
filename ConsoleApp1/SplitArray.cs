using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class SplitArray : ISplitArray
    {
        public void SplitString(string text)
        {
            if (text.Length < 6)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                int counter = 0;
                string element = String.Empty;
                List<string> elements = new List<string>();
                for (int i = 0; i < text.Length; i++)
                {
                    counter++;
                    if (counter == 1)
                    {
                        element = text[i].ToString();
                        elements.Add(element);
                    }
                    else if (counter == 2)
                    {
                        if (i + 1 < text.Length)
                        {
                            element = text[i].ToString() + text[i + 1].ToString();
                            elements.Add(element);
                        }
                    }
                    else if (counter == 3)
                    {
                        if (i + 1 < text.Length && i + 2 < text.Length)
                        {
                            element = text[i+1].ToString() + text[i + 2].ToString() + text[i + 3].ToString();
                            counter = 0;
                            elements.Add(element);
                            i += 3;
                        }
                    }
                }

                for (int i = 0; i < elements.Count; i++)
                    Console.Write(elements[i] + (i < elements.Count - 1 ? ", " : ""));

                Console.WriteLine();
                for (int i = 0; i < elements.Count; i++)
                    Console.Write(elements[i][0] + (i < elements.Count - 1 ? "--" : ""));

            }
        }
    }
}