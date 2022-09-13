using System;

namespace DiamondPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {

            String str = UserInput();
            if (str.Length == 1)
            {
                Pattern(str);
            }

            Console.ReadLine();

        }

        static void Pattern(string str)
        {
            int letter = 65;

            char ch = Convert.ToChar(str);
            int j = Convert.ToInt32(ch) - letter + 1;

            UpperHalf(j);

            LowerHalf(j);

        }

        static void UpperHalf(int j)
        {
            RecursivePattern recursive = new RecursivePattern();

            for (int i = 1; i <= j; i++)
            {
                for (int a = 1; a <= j - i; a++)
                {
                    Console.Write(" ");
                }
                recursive.PrintPattern(i, i);
            }
        }
        static void LowerHalf(int j)
        {
            RecursivePattern recursive = new RecursivePattern();
            for (int i = j - 1; i > 0; i--)
            {
                for (int a = i; a < j; a++)
                {
                    Console.Write(" ");
                }
                recursive.PrintPattern(i, i);
            }
        }

        public static string UserInput()
        {
            try
            {

                Console.Write("Enter Capital abphabets: ");

                string strMesssage = "";
                String str = Console.ReadLine();

                if (str.Length > 1)
                {
                    Console.Write("Please Enter Alphabet Character <A-Z or a-z> ");
                    strMesssage = "String Character invalid character";
                    return strMesssage;
                }
                else
                {
                    char ch = Convert.ToChar(str.ToUpper());
                    if (ch > 64 && ch < 91)
                    {
                        return str.ToUpper();
                    }
                    else
                    {
                        Console.WriteLine("Only Alphabet Charater allowed");
                        strMesssage = "Invalid Alphabet Character";
                        return strMesssage;
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }

        public class RecursivePattern
        {
            public void PrintPattern(int n, int k)
            {
                int i = n;
                if (n == 1)
                {
                    for (int a = 0; a < 2 * k - 1; a++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine((char)(65 + k - 1));
                }
                else
                {
                    if (i == k)
                    {
                        Console.Write((char)(65 + n - 1));
                    }
                    PrintPattern(n - 1, k);
                }

            }
        }
    }
}
