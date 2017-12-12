using System;
using DataTransformation.Implementation;

namespace Mobilreklame.DataTransformations.Domain.Ordre
{
    public class OrdreViewModel : CopyableWithDefaultValuesBase
    {
        public int CustomerRefID { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Description { get; set; }
        public bool Delivery { get; set; }
        public bool ExtraProduction { get; set; }

        public override void SetDefaultValues()
        {
            Key = NullKey;
            CustomerRefID = 0;
            Date = DateTimeOffset.Now;
            Description = "No description";
            Delivery = false;
            ExtraProduction = false;
        }
    }
}