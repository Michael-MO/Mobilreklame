using ExtensionsViewModel.Implementation;
using Mobilreklame.DataTransformations.Domain.Levering;
using Mobilreklame.Model.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilreklame.ViewModel.Domain.Levering
{
    public class MasterDetailsViewModel : MasterDetailsViewModelCRUD<LeveringViewModel>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), ObjectProvider.LeveringCatalog,
                new List<string> { "CustomerRefID", "OrderID", "Dato", "Tidspunkt", "Adresse", "By", "Zip", "Montering" },
                new List<string> { })
        {
        }
    }
}
