using Module2_Task3.Entities;

namespace Module2_Task3.Interfaces
{
    public interface IPresentItemsService
    {
        public PresentItem[] FilterByNameWeight(PresentItem[] rawItems, string name, double maxWeight);

        public PresentItem[] SortByPriceDesc(PresentItem[] rawItems);

        public double CountPresentWeight(PresentItem[] items);
    }
}
