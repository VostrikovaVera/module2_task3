using System;

namespace Module2_Task3.Entities
{
    public class EdibleItem : PresentItem
    {
        public double CaloriesValue { get; set; }

        public int ShelfLife { get; set; }
    }
}
