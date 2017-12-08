using System.Collections.Generic;
using ExtensionsViewModel.Implementation;
using Mobilreklame.DataTransformations.Domain.Ordre;
using Mobilreklame.Model.App;

namespace Mobilreklame.ViewModel.Domain.Ordre
{
    public class MasterDetailsViewModel : MasterDetailsViewModelCRUD<OrdreViewModel>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), ObjectProvider.OrdreCatalog,
                new List<string> { "Car", "Customer", "Employee" },
                new List<string> { "Date", "Price" })
        {
        }
    }
}