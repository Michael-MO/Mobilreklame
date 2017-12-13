using Mobilreklame.DataTransformations.Domain.Montering;
using Mobilreklame.Model.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Implementation;

namespace Mobilreklame.ViewModel.Domain.Montering
{
    class ItemViewModel : ItemViewModelBase<MonteringViewModel>
    {
        private MonteringViewModel GetMontering()
        {
            return ObjectProvider.MonteringCatalog.Read(DataObject.Key) as MonteringViewModel;
        }
        public ItemViewModel(MonteringViewModel obj) : base(obj)
        {

        }
    }
}
