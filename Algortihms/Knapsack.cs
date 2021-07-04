using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructureAlgorithm.Algortihms
{

    public class Item
    {
        public int Profit;
        public int Weight;

        public Item(int profit, int weight)
        {
            Profit = profit;
            Weight = weight;
        }
    }

    public class customComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Item item1 = (Item)x;
            Item item2 = (Item)y;
            double ratio1 = (double)item1.Profit / (double)item1.Weight;
            double ratio2 = (double)item2.Profit / (double)item2.Weight;
            if (ratio1 < ratio2)
            {
                return 1;
            }
            else if (ratio1 == ratio2)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
    public class Knapsack
    {

        public void Knapsack_main()
        {
            Item[] items = new Item[] {
                new Item(60,10),
                new Item(100,20),
                new Item(120,30)
            };
            var output = FracKnapSack(items, 50);
            Console.WriteLine(output);

            Item[] items1 = new Item[] {
                new Item(10,2),
                new Item(5,3),
                new Item(15,5),
                new Item(7,7),
                new Item(6,1),
                new Item(18,4),
                new Item(3,1),
            };
            var output1 = FracKnapSack(items1, 15);
            Console.WriteLine(output1);
        }

        public double FracKnapSack(Item[] items, int maxWeight)
        {

            customComparer cmp = new customComparer();
            Array.Sort(items, cmp);

            double totalProfit = 0;
            int currentWeight = 0;

            foreach (var item in items)
            {

                //check if full weight can be added
                if (currentWeight + item.Weight < maxWeight)
                {
                    currentWeight = currentWeight + item.Weight;
                    totalProfit = totalProfit + item.Profit;
                }
                else
                {
                    if (currentWeight == maxWeight)
                    {
                        break;
                    }
                    else
                    {
                        //add fraction
                        double fraction = (maxWeight - currentWeight) / (double)item.Weight;
                        totalProfit = totalProfit + (fraction * (double)item.Profit);
                        currentWeight = currentWeight + (int)(fraction * (double)item.Weight);
                    }
                }
            }
            return totalProfit;

        }

    }
}