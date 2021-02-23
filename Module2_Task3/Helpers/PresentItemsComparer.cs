using System.Collections.Generic;
using Module2_Task3.Entities;

namespace Module2_Task3.Helpers
{
    public class PresentItemsComparer : IComparer<PresentItem>
    {
        public int Compare(PresentItem p1, PresentItem p2)
        {
            if (p1.Price > p2.Price)
            {
                return -1;
            }
            else if (p1.Name.Length < p2.Name.Length)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
