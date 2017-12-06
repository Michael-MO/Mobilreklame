using System;
using DataTransformation.Implementation;

namespace Mobilreklame.DataTransformations.Domain.Ordre
{
    public class OrdreViewModel : CopyableWithDefaultValuesBase
    {
        public int CustomerRefID { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public bool Delivery { get; set; }
        public bool ExtraProduction { get; set; }

        public override void SetDefaultValues()
        {
            Key = NullKey;
            Date = DateTime.Now;
        }
    }
}