using ExtensionsViewModel.Implementation;
using Mobilreklame.DataTransformations.Domain.Montering;
using Mobilreklame.Model.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilreklame.ViewModel.Domain.Montering
{
    class MasterDetailsViewModel : MasterDetailsViewModelCRUD<MonteringViewModel>
    {
        public MasterDetailsViewModel() : base(new ViewModelFactory(), ObjectProvider.MonteringCatalog, new List<string> { }, new List<string> { })
        {
        }
    }
}
