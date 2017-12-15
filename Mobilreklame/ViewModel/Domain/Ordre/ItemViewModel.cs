﻿using Mobilreklame.Model.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobilreklame.DataTransformations.Domain.Ordre;
using ViewModel.Implementation;
using Mobilreklame.Model.Domain.Ordre;

namespace Mobilreklame.ViewModel.Domain.Ordre
{
    class ItemViewModel : ItemViewModelBase<OrdreViewModel>
    {
        private OrdreViewModel GetOrdre()
        {
            return ObjectProvider.OrdreCatalog.Read(DataObject.Key);
        }
        public ItemViewModel(OrdreViewModel obj) : base(obj)
        {
            
        }
    }
}
