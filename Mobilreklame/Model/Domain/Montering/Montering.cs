using InMemoryStorage.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilreklame.Model.Domain.Montering
{
    public class Montering : CopyableBase
    {
        public Montering(
            int key,
            int leveringID
            ) : base(key)
        {
            LeveringID = leveringID;
        }
        public Montering() : base(NullKey)
        {

        }
        public int LeveringID { get; set; }
    }
}
