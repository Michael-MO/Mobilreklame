using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilreklame.Model.App
{
    public class ObjectProvider
    {
        public static Domain.Ordre.OrdreCatalog OrdreCatalog
        {
            get { return Domain.Ordre.OrdreCatalog.Instance; }
        }
    }
}
