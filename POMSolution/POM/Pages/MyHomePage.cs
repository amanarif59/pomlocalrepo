﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.Pages
{
    public class MyHomePage
    {
        TopMenu topMenu;
        public ShoppingCartPage BuyProduct(string productName)
        {
            return new ShoppingCartPage();
        }

        public TopMenu GeTTopMenu()
        {
            topMenu = new TopMenu();
            return topMenu;
        }
    }
}
