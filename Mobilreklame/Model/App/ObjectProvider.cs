using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilreklame.Model.App
{
    public class ObjectProvider
    {
        //public static Domain.Faktura.FakturaCatalog FakturaCatalog
        //{
        //    get { return Domain.Faktura.FakturaCatalog.Instance; }
        //}
        public static Domain.Kunde.KundeCatalog KundeCatalog
        {
            get { return Domain.Kunde.KundeCatalog.Instance; }
        }
        public static Domain.Ordre.OrdreCatalog OrdreCatalog
        {
            get { return Domain.Ordre.OrdreCatalog.Instance; }
        }
        public static Domain.Levering.LeveringCatalog LeveringCatalog
        {
            get { return Domain.Levering.LeveringCatalog.Instance; }
        }
        public static Domain.Montering.MonteringCatalog MonteringCatalog
        {
            get { return Domain.Montering.MonteringCatalog.Instance; }
        }
    }
}
