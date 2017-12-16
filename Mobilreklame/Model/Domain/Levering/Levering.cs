using InMemoryStorage.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilreklame.Model.Domain.Levering
{
    public class Levering : CopyableBase
    {
        public Levering(
            int key,
            int customerRefID,
            int orderID,
            DateTime dato,
            TimeSpan tidspunkt,
            string adresse,
            string by,
            int zip,
            bool montering
            ) : base(key)
        {
            CustomerRefID = customerRefID;
            OrderID = orderID;
            Dato = dato;
            Tidspunkt = tidspunkt;
            Adresse = adresse;
            By = by;
            Zip = zip;
            Montering = montering;
        }

        public Levering() : base(NullKey)
        {

        }
        public int OrderID { get; set; }
        public int CustomerRefID { get; set; }
        public DateTime Dato { get; set; }
        public TimeSpan Tidspunkt { get; set; }
        public string Adresse { get; set; }
        public string By { get; set; }
        public int Zip { get; set; }
        public bool Montering { get; set; }
    }
}
