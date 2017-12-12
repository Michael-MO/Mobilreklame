using System;
using InMemoryStorage.Implementation;

namespace Mobilreklame.Model.Domain.Ordre
{
    public class Ordre : CopyableBase
    {
        public Ordre(int key, int customerRefID, DateTimeOffset date, string description, bool delivery, bool extraProduction)
            : base(key)
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

        public int CustomerRefID { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Description { get; set; }
        public bool Delivery { get; set; }
        public bool ExtraProduction { get; set; }
    }
}
