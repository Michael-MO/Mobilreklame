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
    class MasterDetailsViewModel : MasterDetailsViewModelCRUD<LeveringViewModel>
    {
        public MasterDetailsViewModel() : base(new ViewModelFactory(), ObjectProvider.LeveringCatalog, new List<string> { }, new List<string> { })
        {
        }
    }
}
