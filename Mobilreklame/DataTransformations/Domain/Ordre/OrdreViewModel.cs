using System;
using DataTransformation.Implementation;

namespace Mobilreklame.DataTransformations.Domain.Ordre
{
    public class OrdreViewModel : Model.Domain.Ordre.Ordre
    {
        public OrdreViewModel()
        {    
        }

        public OrdreViewModel(int key, int customerRefID, DateTimeOffset date, string description, bool delivery, bool extraProduction)
            : base(key, customerRefID, date, description, delivery, extraProduction)
        {
            
        }
    }
}