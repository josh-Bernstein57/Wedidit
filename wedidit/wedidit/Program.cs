using System;

namespace MarshallsRevenue6
{
    internal class MarshallsRevenue
    {
        public MarshallsRevenue()
        {
        }

        private static void Main(string[] args)
        {
            int num;
            int num1;
            int i;
            bool flag;
            string[] strArrays = new string[30];
            string[] strArrays1 = new string[30];
            char[] chrArray = new char[] { 'L', 'S', 'A', 'C', 'O' };
            string[] strArrays2 = new string[] { "Landscape", "Seascape", "Abstract", "Children's", "Other" };
            char[] chr = new char[30];
            char[] chr1 = new char[30];
            int num2 = 0;
            int[] numArray = new int[5];
            int[] numArray1 = new int[5];
            Console.Write("Enter the month >> ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if ((num3 < 1 ? false : num3 <= 12))
                {
                    break;
                }
                Console.Write("Invalid month. Enter the month >> ");
                num3 = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter number of interior murals scheduled >> ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if ((num4 < 0 ? false : num4 <= 30))
                {
                    break;
                }
                Console.WriteLine("Number must be between {0} and {1} inclusive", 0, 30);
                Console.Write("Enter number of interior murals scheduled >> ");
                num4 = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter number of exterior murals scheduled >> ");
            int num5 = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if ((num5 < 0 ? false : num5 <= 30))
                {
                    break;
                }
                Console.WriteLine("Number must be between {0} and {1} inclusive", 0, 30);
                Console.Write("Enter number of Exterior murals scheduled >> ");
                num5 = Convert.ToInt32(Console.ReadLine());
            }
            if ((num3 == 12 || num3 == 1 ? true : num3 == 2))
            {
                num5 = 0;
            }
            num = ((num3 == 4 || num3 == 5 || num3 == 9 ? false : num3 != 1) ? num4 * 500 : num4 * 450);
            num1 = ((num3 == 7 ? false : num3 != 8) ? num5 * 750 : num5 * 699);
            int num6 = num + num1;
            bool flag1 = num4 > num5;
            int num7 = 500;
            Console.WriteLine("{0} interior murals are scheuled at {1} each for a total of {2}", num4, num7.ToString("C"), num.ToString("C"));
            num7 = 750;
            Console.WriteLine("{0} exterior murals are scheuled at {1} each for a total of {2}", num5, num7.ToString("C"), num1.ToString("C"));
            Console.WriteLine("Total revenue expected is {0}", num6.ToString("C"));
            Console.WriteLine("It is {0} that there are more interior murals scheduled than exterior ones.", flag1);
            Console.WriteLine("Entering interior jobs:");
            for (i = 0; i < num4; i++)
            {
                Console.Write("Enter customer name >> ");
                strArrays[i] = Console.ReadLine();
                Console.WriteLine("Mural options are:");
                for (int j = 0; j < (int)chrArray.Length; j++)
                {
                    Console.WriteLine("  {0}   {1}", chrArray[j], strArrays2[j]);
                }
                Console.Write("       Enter mural style code >> ");
                chr[i] = Convert.ToChar(Console.ReadLine());
                flag = false;
                while (!flag)
                {
                    for (int k = 0; k < (int)chrArray.Length; k++)
                    {
                        if (chr[i] == chrArray[k])
                        {
                            flag = true;
                            numArray[k]++;
                        }
                    }
                    if (!flag)
                    {
                        Console.WriteLine("{0} is not a valid code", chr[i]);
                        Console.Write("       Enter mural style code >> ");
                        chr[i] = Convert.ToChar(Console.ReadLine());
                    }
                }
            }
            Console.WriteLine("Entering exterior jobs:");
            for (i = 0; i < num5; i++)
            {
                Console.Write("Enter customer name >> ");
                strArrays1[i] = Console.ReadLine();
                Console.WriteLine("Mural options are:");
                for (int l = 0; l < (int)chrArray.Length; l++)
                {
                    Console.WriteLine("  {0}   {1}", chrArray[l], strArrays2[l]);
                }
                Console.Write("       Enter mural style code >> ");
                chr1[i] = Convert.ToChar(Console.ReadLine());
                flag = false;
                while (!flag)
                {
                    for (int m = 0; m < (int)chrArray.Length; m++)
                    {
                        if (chr1[i] == chrArray[m])
                        {
                            flag = true;
                            numArray1[m]++;
                        }
                    }
                    if (!flag)
                    {
                        Console.WriteLine("{0} is not a valid code", chr1[i]);
                        Console.Write("       Enter mural style code >> ");
                        chr[i] = Convert.ToChar(Console.ReadLine());
                    }
                }
            }
            Console.WriteLine("\nThe interior murals scheduled are:");
            for (i = 0; i < (int)numArray.Length; i++)
            {
                Console.WriteLine("{0, -20}  {1, 5}", strArrays2[i], numArray[i]);
            }
            Console.WriteLine("\nThe exterior murals scheduled are:");
            for (i = 0; i < (int)numArray1.Length; i++)
            {
                Console.WriteLine("{0, -20}  {1, 5}", strArrays2[i], numArray1[i]);
            }
            Console.Write("\nEnter a mural type or {0} to quit >> ", 'Z');
            for (char n = Convert.ToChar(Console.ReadLine()); n != 'Z'; n = Convert.ToChar(Console.ReadLine()))
            {
                flag = false;
                for (int o = 0; o < (int)chrArray.Length; o++)
                {
                    if (n == chrArray[o])
                    {
                        flag = true;
                        num2 = o;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("\nCustomers ordering {0} murals are:", strArrays2[num2]);
                    bool flag2 = false;
                    for (i = 0; i < num4; i++)
                    {
                        if (chr[i] == n)
                        {
                            Console.WriteLine("{0} Interior", strArrays[i]);
                            flag2 = true;
                        }
                    }
                    for (i = 0; i < num5; i++)
                    {
                        if (chr1[i] == n)
                        {
                            Console.WriteLine("{0} Exterior", strArrays1[i]);
                            flag2 = true;
                        }
                    }
                    if (!flag2)
                    {
                        Console.WriteLine("No customers ordered {0} murals", strArrays2[num2]);
                    }
                }
                else
                {
                    Console.WriteLine("{0} is not a valid code", n);
                }
                Console.Write("\nEnter a mural type or {0} to quit >> ", 'Z');
            }
        }
    }
}
