using ExtensionsViewModel.Implementation;
using Mobilreklame.DataTransformations.Domain.Kunde;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog.Interfaces;
using ViewModel.Interfaces;
using Mobilreklame.Model.App;
using Mobilreklame.Model.Domain.Kunde;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Mobilreklame.ViewModel.Domain.Kunde
{
    class MasterDetailsViewModel : MasterDetailsViewModelCRUD<KundeViewModel>
    {
        public MasterDetailsViewModel() : base(new ViewModelFactory(), ObjectProvider.KundeCatalog, new List<string> { }, new List<string> { })
        {
            KundeCatalog.Instance.Load();
        }
    }
}
