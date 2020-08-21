using System;
using System.Collections.Generic;
using System.Text;

namespace JeffBartonRouletteLab
{
    internal class Bet
  {

    internal static void Numbers(int randmBinCount, int totalBins)
    {
        if (randmBinCount == totalBins+1)
        {
            Console.WriteLine("If you bet 00 you win!");
        }
        else
        {
            Console.WriteLine($"If you bet {randmBinCount} you win!");
        }
    }

    internal static void EvenOdds(int randomBinCount, int totalBins)
    {
        if (randomBinCount == 0 || randomBinCount == totalBins+1)
        {
            Console.WriteLine("No luck on Even/Odds");
        }
        else
        {
            if ((randomBinCount % 2) == 0)
            {
                Console.WriteLine("Evens a winner!!");
            }
            else
            {
                Console.WriteLine("Odds a winner");
            }
        }
    }

    internal static void RedsBlacks(Bins binChoice, int randomBinCount, int totalBins)
    {
        if (randomBinCount == 0 || randomBinCount == totalBins +1)
        {
            Console.WriteLine("No luck on Red/Black");
        }
        else
        {
            Console.WriteLine($"{binChoice.color} is a winner!");
        }
    }

    internal static void LowsHighs(int randomBinCount, int totalBins)
    {
        if (randomBinCount == 0 || randomBinCount == totalBins +1)
        {
            Console.WriteLine("No luck on Lows or Highs");
        }
        else
        {
            if (randomBinCount < 19)
            {
                Console.WriteLine("Lows a winner!");
            }
            else
            {
                Console.WriteLine("Highs the big winner!");
            }
        }
    }

    internal static void Dozens(int randomBinCount, int totalBins)
    {
        if (randomBinCount == 0 || randomBinCount == totalBins +1)
        {
            Console.WriteLine("No luck on Dozens");
        }
        else
        {
            if (randomBinCount <= 12)
            {
                Console.WriteLine("1-12 is a winner!");
            }
            else if (randomBinCount >= 25)
            {
                Console.WriteLine("25-36 is a winner!");
            }
            else
            {
                Console.WriteLine("13-24 a big winner!");
            }
        }
    }

    internal static void Columns(int randomBinCount, int totalBins, int totalColumns)
    {
        if (randomBinCount == 0 || randomBinCount == totalBins +1)
        {
            Console.WriteLine("No winner for Columns");
        }
        else
        {
            switch (randomBinCount % totalColumns)
            {
                case 0:
                    Console.WriteLine("Column 1 (3/6/9/12/15/18/21/24/27/30/33/36)...Winner!!");
                    break;
                case 1:
                    Console.WriteLine("Column 3 (1/4/7/10/13/16/19/22/25/28/31/34)...Winner!!");
                    break;
                case 2:
                    Console.WriteLine("Column 2 (2/5/8/11/14/17/20/23/26/29/32/35)...Winner!!");
                    break;
                default:
                    break;
            }
        }
    }

    internal static void Street(int randomBinCount, int totalBins, int totalColumns)
    {
        if (randomBinCount == 0 || randomBinCount == totalBins +1)
        {
            Console.WriteLine("Its rough on them streets, No winner");
        }
        else
        {
            int temp = (randomBinCount - 1) / totalColumns;
            int temp1 = (temp * totalColumns) + totalColumns - 2;
            int temp2 = (temp * totalColumns) + totalColumns - 1;
            int temp3 = (temp * totalColumns) + totalColumns;
            Console.WriteLine($"{temp1}, {temp2}, {temp3} are winners");
        }
    }

    internal static void SixNumbers(int randomBinCount, int totalBins, int totalColumns)
    {
        if (randomBinCount == 0 || randomBinCount == totalBins +1)
        {
            Console.WriteLine("No joy on Sixs");
        }
        else
        {
            int temp = (randomBinCount = 1) / totalColumns;
            switch (temp)
            {
                case 0:
                    int temp1 = (temp * totalColumns) + 1;
                    int temp2 = (temp * totalColumns) + 2;
                    int temp3 = (temp * totalColumns) + 3;
                    int temp4 = (temp * totalColumns) + 4;
                    int temp5 = (temp * totalColumns) + 5;
                    int temp6 = (temp * totalColumns) + 6;
                    Console.WriteLine($"{temp1}, {temp2}, {temp3}, {temp4}, {temp5}, {temp6} are winners!!!");
                    break;
                case 1:
                    temp1 = ((temp - 1) * totalColumns) + 1;
                    temp2 = ((temp - 1) * totalColumns) + 2;
                    temp3 = ((temp - 1) * totalColumns) + 3;
                    temp4 = (temp * totalColumns) + 1;
                    temp5 = (temp * totalColumns) + 2;
                    temp6 = (temp * totalColumns) + 3;
                    Console.WriteLine($"{temp1}, {temp2}, {temp3}, {temp4}, {temp5}, {temp6} are winners!!!");
                    break;
                default:
                    temp1 = ((temp - 1) * totalColumns) + 1;
                    temp2 = ((temp - 1) * totalColumns) + 2;
                    temp3 = ((temp - 1) * totalColumns) + 3;
                    temp4 = (temp * totalColumns) + 1;
                    temp5 = (temp * totalColumns) + 2;
                    temp6 = (temp * totalColumns) + 3;
                    Console.WriteLine($"{temp1}, {temp2}, {temp3}, {temp4}, {temp5}, {temp6} or  {temp4}, {temp5}, {temp6}, {temp4 + totalColumns}, {temp5 + totalColumns}, {temp6 + totalColumns} all winners here!!!");
                    break;
            }
        }
    }
    internal static void Splits(int randomBinCount, int totalBins, int totalColumns)
    {
        if (randomBinCount == 0 || randomBinCount == totalBins +1)
        {
            Console.WriteLine("No love from the Splits");
        }
        else
        {
            int street = (randomBinCount - 1) / totalColumns;
            int Columns = (randomBinCount % totalColumns);
            string a = randomBinCount + "/" + (randomBinCount + 1) + " ";
            string b = randomBinCount + "/" + (randomBinCount - 1) + " ";
            string c = randomBinCount + "/" + (randomBinCount + totalColumns);
            string d = (randomBinCount - totalColumns) + "/" + randomBinCount + " ";

            switch (street)
            {
                case 0:
                    d = "";
                    break;
                case 1:
                    c = "";
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Winners on {a}{b}{c}and{d}");
        }
               
    }
        internal static void Corner(int randomBinCount, int totalBins, int totalColumns)
        {
            if (randomBinCount == 0 || randomBinCount == totalBins + 1)
            {
                Console.WriteLine("No cutting corners today");
            }
            else
            {
                int street = (randomBinCount - 1) / totalColumns;
                int column = (randomBinCount % totalColumns);
                string ad = (randomBinCount + 1 - totalColumns) + "/" + (randomBinCount + 1) + "/" + (randomBinCount - totalColumns) + "/" + randomBinCount + " ";
                string ac = (randomBinCount + 1) + "/" + (randomBinCount + 1 + totalColumns) + "/" + randomBinCount + "/" + (randomBinCount + totalColumns) + " ";
                string bd = (randomBinCount - totalColumns) + "/" + randomBinCount + "/" + (randomBinCount - totalColumns - 1) + "/" + (randomBinCount - 1) + " ";
                string bc = randomBinCount + "/" + (randomBinCount + totalColumns) + "/" + (randomBinCount - 1) + "/" + (randomBinCount - 1 + totalColumns) + " ";

                switch (street)
                {
                    case 0:
                        ad = "";
                        bd = "";
                        break;
                    case 1:
                        ac = "";
                        bc = "";
                        break;
                    default:
                        break;
                }
                switch (column)
                {
                    case 0:
                        ad = "";
                        ac = "";
                        break;
                    case 1:
                        bd = "";
                        bc = "";
                        break;
                    default:
                        break;
                }

                Console.WriteLine($"We have winners on {ad}, {ac}, {bd} and {bc}!!!");
            }
        }
    }
}
