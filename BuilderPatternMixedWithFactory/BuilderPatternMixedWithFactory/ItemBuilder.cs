using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternMixedWithFactory
{
    class ItemBuilder
    {
        public CellPhone IphoneXOrder()
        {
            CellPhone cellPhone = new CellPhone();
            cellPhone.AddItem(new IphoneX());
            return cellPhone;
        }
    }
}
