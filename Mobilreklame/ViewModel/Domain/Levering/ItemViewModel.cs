using Mobilreklame.DataTransformations.Domain.Levering;
using Mobilreklame.Model.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Implementation;

namespace Mobilreklame.ViewModel.Domain.Levering
{
    public class ItemViewModel : ItemViewModelBase<LeveringViewModel>
    {

        public string Key
        {
            get { return "Ordre nr. " + DataObject.Key.ToString(); }
        }

        private LeveringViewModel GetKunde()
        {
            return ObjectProvider.LeveringCatalog.Read(DataObject.Key) as LeveringViewModel;
        }
        public ItemViewModel(LeveringViewModel obj) : base(obj)
        {
        }
    }
}
