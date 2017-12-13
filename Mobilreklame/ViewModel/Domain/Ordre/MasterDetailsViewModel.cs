using ExtensionsViewModel.Implementation;
using Mobilreklame.DataTransformations.Domain.Ordre;
using Mobilreklame.Model.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilreklame.ViewModel.Domain.Ordre
{
    class MasterDetailsViewModel : MasterDetailsViewModelCRUD<OrdreViewModel>
    {
        public MasterDetailsViewModel() : base(new ViewModelFactory(), ObjectProvider.OrdreCatalog, new List<string> { }, new List<string> { })
        {
        }
    }
}
