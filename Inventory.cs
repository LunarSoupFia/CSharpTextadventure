using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    public class Inventory
    {
        private string[] _itemId;

        public string[] ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

    }
}