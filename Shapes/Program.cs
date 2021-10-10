using System;
using static System.Console;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            pattern(5);
        }
        public static void pattern(int n)
        {
            /*
            ------------------------
            *
            **
            ***
            ****
            *****
            --------------------------
            */
            for (int Row = 1; Row <= n; Row++)
            {
                for (int Col = 1; Col <= Row; Col++)
                {
                    Write("* ");
                }
                WriteLine();
            }
            WriteLine();
            WriteLine();
            /*
            ------------------------
            *****
            *****
            *****
            *****
            *****
            --------------------------
            */
            for (int Row = 1; Row <= n; Row++)
            {
                for (int Col = 1; Col <= n; Col++)
                {
                    Write("* ");
                }
                WriteLine();
            }
            WriteLine();
            WriteLine();
            /*
            ------------------------
            *****
            ****
            ***
            **
            *
            --------------------------
            */
            for (int Row = 1; Row <= n; Row++)
            {
                for (int Col = 1; Col <= n - Row + 1; Col++)
                {
                    Write("* ");
                }
                WriteLine();
            }
            WriteLine();
            WriteLine();
            /*
            ------------------------
            1
            12
            123
            1234
            12345
            --------------------------
            */
            for (int Row = 1; Row <= n; Row++)
            {
                for (int Col = 1; Col <= Row; Col++)
                {
                    Write(Col + " ");
                }
                WriteLine();
            }
            WriteLine();
            WriteLine();
            /*
            ------------------------
            12345
            12345
            12345
            12345
            12345
            --------------------------
            */
            for (int Row = 1; Row <= n; Row++)
            {
                for (int Col = 1; Col <= n; Col++)
                {
                    Write(Col + " ");
                }
                WriteLine();
            }
            WriteLine();
            WriteLine();
            /*
            ------------------------
            12345
            1234
            123
            12
            1
            --------------------------
            */
            for (int Row = 1; Row <= n; Row++)
            {
                for (int Col = 1; Col <= n - Row + 1; Col++)
                {
                    Write(Col + " ");
                }
                WriteLine();
            }
            WriteLine();
            WriteLine();
            /*
            ------------------------
            *
            **
            ***
            ****
            *****
            ****
            ***
            **
            *
            --------------------------
            */
            for (int Row = 1; Row <= 2 * n - 1; Row++)
            {
                int ColumnIteration = Row <= n ? Row : 2 * n - Row;
                for (int Col = 1; Col <= ColumnIteration; Col++)
                {
                    Write("* ");
                }
                WriteLine();
            }
            WriteLine();
            WriteLine();
            /*
            ------------------------
            1
            12
            123
            1234
            12345
            1234
            123
            12
            1
            --------------------------
            */
            for (int Row = 1; Row <= 2 * n - 1; Row++)
            {
                int ColumnIteration = Row <= n ? Row : 2 * n - Row;
                for (int Col = 1; Col <= ColumnIteration; Col++)
                {
                    Write(Col + " ");
                }
                WriteLine();
            }
            WriteLine();
            WriteLine();
            /*
            ------------------------
                *
               **
              ***
             ****
            *****
            --------------------------
            */
            for (int Row = 1; Row <= n; Row++)
            {
                int Spaces = n - Row;
                for (int s = 1; s <= Spaces; s++)
                {
                    Write("  ");
                }
                for (int Col = 1; Col <= Row; Col++)
                {
                    Write("* ");
                }
                WriteLine();
            }
            WriteLine();
            WriteLine();
            /*
            ------------------------
                1
               12
              123
             1234
            12345
            --------------------------
            */
            for (int Row = 1; Row <= n; Row++)
            {
                int Spaces = n - Row;
                for (int s = 1; s <= Spaces; s++)
                {
                    Write("  ");
                }
                for (int Col = 1; Col <= Row; Col++)
                {
                    Write(Col + " ");
                }
                WriteLine();
            }
            WriteLine();
            WriteLine();
            /*
            ------------------------
                1
               21
              321
             4321
            54321
            --------------------------
            */
            for (int Row = 1; Row <= n; Row++)
            {
                int Spaces = n - Row;
                for (int s = 1; s <= Spaces; s++)
                {
                    Write("  ");
                }
                for (int Col = Row; Col >= 1; Col--)
                {
                    Write(Col + " ");
                }
                WriteLine();
            }
            WriteLine();
            WriteLine();
            /*
            ------------------------
                *
               * *
              * * *
             * * * *
            * * * * * 
            --------------------------
            */
            for (int Row = 1; Row <= n; Row++)
            {
                int Spaces = n - Row;
                for (int s = 1; s <= Spaces; s++)
                {
                    Write(" ");
                }
                for (int Col = 1; Col <= Row; Col++)
                {
                    Write("* ");
                }
                WriteLine();
            }
            WriteLine();
            WriteLine();
            /*
            ------------------------
                1
               1 2
              1 2 3
             1 2 3 4
            1 2 3 4 5 
            --------------------------
            */
            for (int Row = 1; Row <= n; Row++)
            {
                int Spaces = n - Row;
                for (int s = 1; s <= Spaces; s++)
                {
                    Write(" ");
                }
                for (int Col = 1; Col <= Row; Col++)
                {
                    Write(Col + " ");
                }
                WriteLine();
            }
            WriteLine();
            WriteLine();
            /*
               1  
              123
             12321
            1234321
           123454321
             */
            for (int Row = 1; Row <= n; Row++)
            {
                int Spaces = n - Row;
                for (int s = 1; s <= Spaces; s++)
                {
                    Write(" ");
                }
                for (int Col = 1; Col <= 1; Col++)
                {
                    if (Row == 1)
                    {
                        WriteLine("1");
                        WriteLine("   123");
                        WriteLine("  12321");
                        WriteLine(" 1234321");
                        WriteLine("123454321");
                    }
                }
                WriteLine();
            }
        }
    }
}
