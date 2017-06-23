using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.Pages
{
    public class OrderStatusPage
    {
        TopMenu topMenu;

        public void VerifyOrder()
        {

        }

        public TopMenu GeTTopMenu()
        {
            topMenu = new TopMenu();
            return topMenu;
        }
    }
}
