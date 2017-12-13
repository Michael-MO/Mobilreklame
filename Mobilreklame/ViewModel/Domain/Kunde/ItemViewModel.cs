using Mobilreklame.DataTransformations.Domain.Kunde;   
using Mobilreklame.Model.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Implementation;

namespace Mobilreklame.ViewModel.Domain.Kunde
{
    class ItemViewModel : ItemViewModelBase<KundeViewModel>
    {
        private KundeViewModel GetKunde()
        {
            return ObjectProvider.KundeCatalog.Read(DataObject.Key) as KundeViewModel;
        }
        public ItemViewModel(KundeViewModel obj) : base(obj)
        {

        }
    }
}
