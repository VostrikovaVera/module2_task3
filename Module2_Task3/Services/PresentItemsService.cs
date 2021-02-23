using System;
using Module2_Task3.Entities;
using Module2_Task3.Extentions;
using Module2_Task3.Interfaces;

namespace Module2_Task3.Helpers
{
    public class PresentItemsService : IPresentItemsService
    {
        public PresentItem[] FilterByNameWeight(PresentItem[] items, string name, double maxWeight)
        {
            var fiteredItems = items.FilterNameWeight(name, maxWeight);

            return fiteredItems;
        }

        public PresentItem[] SortByPriceDesc(PresentItem[] items)
        {
            Array.Sort(items, new PresentItemsComparer());

            return items;
        }

        public double CountPresentWeight(PresentItem[] items)
        {
            double weight = 0;

            for (var i = 0; i < items.Length; i++)
            {
                weight += items[i].Weight;
            }

            return weight;
        }
    }
}
