using Mobilreklame.DataTransformations.Domain.Levering;
using Mobilreklame.DataTransformations.Domain.Ordre;
using Mobilreklame.Model.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Implementation;

namespace Mobilreklame.ViewModel.Domain.Levering
{
    class ItemViewModel : ItemViewModelBase<LeveringViewModel>
    {
        private LeveringViewModel GetLevering()
        {
            return ObjectProvider.LeveringCatalog.Read(DataObject.Key) as LeveringViewModel;
        }
        public ItemViewModel(LeveringViewModel obj) : base(obj)
        {

        }
    }
}
