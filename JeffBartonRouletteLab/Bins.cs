using System;
using System.Collections.Generic;
using System.Text;
//List<Bins> binCount  = Bins.MakeBins(totalBins, totalColumns);
namespace JeffBartonRouletteLab
{
    public class Bins
    {
        public string color;
        public readonly string number;
        public readonly int x;
        public readonly int y;

        public Bins(string color = "Purple", string number = "Triple Zero", int x = 0, int y = 0)
        {
            this.color = color;
            this.number = number;
            this.x = x;
            this.y = y;
        }
        public static List<Bins> makeBins(int totalBins, int totalColumns)
        {
            List<Bins> binCount = new List<Bins>();

            var zero = new Bins("Green", "0", 1, 2);
            var doubleZero = new Bins("green", "00", 1, 1);

            binCount.Add(zero);
            for (int i = 1; i <= totalBins; i++)
            {
                int street = (i - 1) / totalColumns;
                var newBins = new Bins();

                if (i < 10)
                {
                    newBins = new Bins("Black", " " + i, street + 2, GetColumn(i, totalColumns));


                }
                else
                {
                    newBins = new Bins("Black", " " + i, street + 2, GetColumn(i, totalColumns));
                }
                binCount.Add(newBins);
            }

            binCount.Add(doubleZero);

            List<Bins> makeBins = RandomizeColors(binCount, totalBins);

            return makeBins;
        }

        private static int GetColumn(int i, int totalColumns)
        {
            int modulo = i % totalColumns;
            int y = 0;

            if (modulo == 1)
            {
                y = totalColumns;
            }
            else if (modulo == 0)
            {
                y = 1;
            }
            else
            {
                y = totalColumns - modulo + 1;
            }
            return y;
        }

        private static List<Bins> RandomizeColors(List<Bins> bincount, int totalBins)
        {
            bool finished = false;
            int i = 0;
            int tempRand = 0;
            Random rand = new Random();
            do
            {
                tempRand = rand.Next(1, totalBins);

                if (bincount[tempRand].color == "Black")
                {
                    bincount[tempRand].color = "Red";
                    i++;
                }
                if (i == 18)
                {
                    finished = true;
                }

            } while (!finished);

            return bincount;
        }
    }
}
