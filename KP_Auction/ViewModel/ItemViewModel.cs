using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KP_Auction.Models;

namespace KP_Auction.ViewModel
{
    public class ItemViewModel
    {
        public ItemModel Item { get; set; }
        public IEnumerable<ItemCategoryModel> ItemCategories { get; set; }
    }
}