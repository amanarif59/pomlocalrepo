﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.Pages
{
    public class ShoppingCartPage
    {
        TopMenu topMenu;

        public OrderReviewPage ConfirmOrder()
        {
            return new OrderReviewPage();
        }

        public TopMenu GeTTopMenu()
        {
            topMenu = new TopMenu();
            return topMenu;
        }
    }
}
