using DataTransformation.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilreklame.DataTransformations.Domain.Ordre
{
    public class OrdreViewModel : CopyableWithDefaultValuesBase
    {
        int customerRefID;
        DateTime date;
        string description;
        bool delivery;
        bool extraProduction;
        public OrdreViewModel()
        {

        }
        public int CustomerRefID { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public bool Delivery { get; set; }
        public bool ExtraProduction { get; set; }
        public override void SetDefaultValues()
        {
        }
    }
}
