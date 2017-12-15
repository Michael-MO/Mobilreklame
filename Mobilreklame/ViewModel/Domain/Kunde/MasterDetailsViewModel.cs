using System.Collections.Generic;
using ExtensionsViewModel.Implementation;
using Mobilreklame.DataTransformations.Domain.Kunde;
using Mobilreklame.Model.App;

namespace Mobilreklame.ViewModel.Domain.Kunde
{
    public class MasterDetailsViewModel : MasterDetailsViewModelCRUD<KundeViewModel>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), ObjectProvider.KundeCatalog,
                new List<string> { "Name", "PhoneNumber", "Email", "CvrNr", "Street", "ZipCode", "City", "Company" },
                new List<string> {  })
        {
        }
    }
}