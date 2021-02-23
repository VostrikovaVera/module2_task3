using Module2_Task3.Entities;

namespace Module2_Task3.Extentions
{
    public static class PresentItemExtension
    {
        public static PresentItem[] FilterNameWeight(this PresentItem[] items, string name, double maxWeight)
        {
            var filteredItems = new PresentItem[items.Length];
            var count = 0;

            for (var i = 0; i < items.Length; i++)
            {
                if (items[i].Name.Contains(name) && items[i].Weight <= maxWeight)
                {
                    filteredItems[i] = items[i];
                    count++;
                }
            }

            if (count == 0)
            {
                return null;
            }

            var result = new PresentItem[count];
            var counter = 0;

            for (var i = 0; i < filteredItems.Length; i++)
            {
                if (filteredItems[i] != null)
                {
                    result[counter] = filteredItems[i];
                    counter++;
                }
            }

            return result;
        }
    }
}
