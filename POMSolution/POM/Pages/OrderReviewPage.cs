using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.Pages
{
    public class OrderReviewPage
    {
        TopMenu topMenu;

        public OrderStatusPage PlaceOrder()
        {
            return new OrderStatusPage();
        }

        public TopMenu GeTTopMenu()
        {
            topMenu = new TopMenu();
            return topMenu;
        }
    }
}
