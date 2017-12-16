using DataTransformation.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilreklame.DataTransformations.Domain.Montering
{
    public class MonteringViewModel : CopyableWithDefaultValuesBase
    {
        //int key;
        //int leveringID;
        public MonteringViewModel()
        {

        }
        public int LeveringID { get; set; }
        public override void SetDefaultValues()
        {
            LeveringID = 0;
        }
    }
}
