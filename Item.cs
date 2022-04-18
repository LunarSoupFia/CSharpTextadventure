using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    public class Item
    {
        private string _itemName;

        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }
        private string _itemDecription;

        public string ItemDescription
        {
            get { return _itemDecription; }
            set { _itemDecription = value; }
        }
        private string _itemType;

        public string ItemType
        {
            get { return _itemType; }
            set { _itemType = value; }
        }

    }
}
