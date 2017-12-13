using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilreklame.Model.Domain.Faktura
{
    public class FakturaCatalog
    {
        private static FakturaCatalog _Instance = new FakturaCatalog();
        public static FakturaCatalog Instance => _Instance;
        private FakturaCatalog()
        {

        }
    }
}
