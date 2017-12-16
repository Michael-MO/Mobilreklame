using System;
using DataTransformation.Implementation;

namespace Mobilreklame.DataTransformations.Domain.Ordre
{
    public class OrdreViewModel : CopyableWithDefaultValuesBase
    {
        //int key;
        //int customerRefID;
        //DateTimeOffset date;
        //string description;
        //bool delivery;
        //bool extraProduction;
        public OrdreViewModel()
        {

        }
        public int CustomerRefID { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Description { get; set; }
        public bool Delivery { get; set; }
        public bool ExtraProduction { get; set; }
        public override void SetDefaultValues()
        {
            CustomerRefID = 0;
            Date = DateTimeOffset.Now;
            Description = "";
            Delivery = false;
            ExtraProduction = false;
        }
    }
}