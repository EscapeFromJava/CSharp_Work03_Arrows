using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp_Work03_Arrows
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"INPUT.txt";
            string s = File.ReadAllText(input);
            string arrow1 = ">>-->";
            string arrow2 = "<--<<";
            int count = 0, temp;
            for (int i = 0; i < s.Length - arrow1.Length + 1;)
            {
                temp = s.IndexOf(arrow1, i);
                if (temp == -1)
                    break;
                else
                {
                    count++;
                    i = temp + 1;
                }
            }
            for (int i = 0; i < s.Length - arrow2.Length + 1;)
            {
                temp = s.IndexOf(arrow2, i);
                if (temp == -1)
                    break;
                else
                {
                    count++;
                    i = temp + 1;
                }
            }
            string result = count.ToString();
            string output = @"OUTPUT.txt";
            File.WriteAllText(output, result);
        }
    }
}
