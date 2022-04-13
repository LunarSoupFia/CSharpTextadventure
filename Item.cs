using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    public class Item
    {
        private string itemName;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }
        private string itemDecription;

        public string ItemDescription
        {
            get { return itemDecription; }
            set { itemDecription = value; }
        }
        private string itemType;

        public string ItemType
        {
            get { return itemType; }
            set { itemType = value; }
        }

    }
}
