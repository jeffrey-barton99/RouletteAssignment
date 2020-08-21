using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace JeffBartonRouletteLab
{
   internal class App
   {
        public App()
        {
        }       
    
    /*
    1. Numbers: the number of the bin
    2. Evens/Odds: even or odd numbers
    3. Reds/Blacks: red or black colored numbers
    4. Lows/Highs: low (1 – 18) or high (19 – 38) numbers.
    5. Dozens: row thirds, 1 – 12, 13 – 24, 25 – 36
    6. Columns: first, second, or third columns
    7. Street: rows, e.g., 1/2/3 or 22/23/24 -12 rows of 3
    8. 6 Numbers: double rows, e.g., 1/2/3/4/5/6 or 22/23/24/25/26/26- 6 rows of 6
    9. Split: at the edge of any two contiguous numbers, e.g., 1/2, 11/14, and 35/36
    10. Corner: at the intersection of any four contiguous numbers, e.g., 1/2/4/5, or 23/24/26/27
    */
        internal void Run()
        //bins
        {
            int totalBins = 36;
            //int totalRows = 12; not sure if rows will work this way
            int totalColumns = 3;
            
            List<Bins> binCount  = Bins.makeBins(totalBins, totalColumns);
            int randombinCount = 0;
            Bins hitBin = new Bins();
            
            //randombinCount = binCount, totalBins;
            hitBin = binCount[randombinCount];
            Console.WriteLine("Your winning numbers are:");
            // the bets. randombinCount = 35???

            Bet.Numbers(totalBins, randombinCount);
            Bet.EvenOdds(totalBins, randombinCount);
            Bet.RedsBlacks(hitBin, totalBins, randombinCount);
            Bet.LowsHighs(randombinCount, totalBins);
            Bet.Dozens(totalBins, randombinCount);
            Bet.Columns(totalBins, randombinCount, totalColumns);
            Bet.Street(totalBins, randombinCount, totalColumns);
            Bet.SixNumbers(totalColumns, totalBins, randombinCount);
            Bet.Splits(totalBins, randombinCount, totalColumns);
            Bet.Corner(totalBins, randombinCount, totalColumns);
        }

        //private int RandomBall(List<Bins> binCount, int binCount)
   }
}
