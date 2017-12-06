using System;
using DataTransformation.Implementation;

namespace Mobilreklame.Model.Domain.Ordre
{
    public class Ordre : TransformedBase<Ordre>
    {
        public Ordre(
            int key,
            int customerRefID,
            DateTime date,
            string description,
            bool delivery,
            bool extraProduction) : base(key)
        {
            CustomerRefID = customerRefID;
            Date = date;
            Description = description;
            Delivery = delivery;
            ExtraProduction = extraProduction;
        }

        public Ordre() : base(NullKey)
        {

        }

        public int OrderID { get; set; }
        public int CustomerRefID { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public bool Delivery { get; set; }
        public bool ExtraProduction { get; set; }


        public override void SetValuesFromObject(Ordre obj)
        {
            Key = obj.Key;
            OrderID = obj.OrderID;
            CustomerRefID = obj.CustomerRefID;
            Date = obj.Date;
            Description = obj.Description;
            Delivery = obj.Delivery;
            ExtraProduction = obj.ExtraProduction;
        }
    }
}
