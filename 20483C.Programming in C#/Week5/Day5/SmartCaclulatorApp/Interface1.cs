using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCaclulatorApp
{
    interface CRUD
    {
        void Create(int num);
        void AddTotal();
        void ClearCalc();
        void ClearSB();
        void SubTotal();
    }
}
