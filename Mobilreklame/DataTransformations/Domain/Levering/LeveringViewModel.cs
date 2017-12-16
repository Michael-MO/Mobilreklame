using DataTransformation.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilreklame.DataTransformations.Domain.Levering
{
    public class LeveringViewModel : CopyableWithDefaultValuesBase
    {
        //int key;
        //int customerRefID;
        //int orderID;
        //DateTime dato;
        //DateTime tidspunkt;
        //string adresse;
        //string by;
        //int zip;
        //bool montering;
        public LeveringViewModel()
        {

        }
        public int CustomerRefID { get; set; }
        public int OrderID { get; set; }
        public DateTime Dato { get; set; }
        public TimeSpan Tidspunkt { get; set; }
        public string Adresse { get; set; }
        public string By { get; set; }
        public int Zip { get; set; }
        public bool Montering { get; set; }
        public override void SetDefaultValues()
        {
            CustomerRefID = 0;
            OrderID = 0;
            Dato = DateTime.Today;
            Tidspunkt = TimeSpan.Zero;
            Adresse = "";
            By = "";
            Zip = 0;
            Montering = false;
        }
    }
}
