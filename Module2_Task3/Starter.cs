using Module2_Task3.Helpers;
using Module2_Task3.Services;

namespace Module2Task1
{
    public class Starter
    {
        private readonly ChildrenPresentProvider _childrenPresentProvider;
        private readonly PresentItemsService _presentItemsService;

        public Starter()
        {
            _childrenPresentProvider = new ChildrenPresentProvider();
            _presentItemsService = new PresentItemsService();
        }

        public void Run()
        {
            var childrenPresent = _childrenPresentProvider.GetAll();

            var childrenPresentWeight = _presentItemsService.CountPresentWeight(childrenPresent);

            var childrenPresentSorted = _presentItemsService.SortByPriceDesc(childrenPresent);

            var childrenPresentFiltered = _presentItemsService.FilterByNameWeight(childrenPresent, "Caramel", 50);
        }
    }
}