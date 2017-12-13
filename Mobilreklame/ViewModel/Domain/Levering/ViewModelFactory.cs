using DataTransformation.Interfaces;
using Mobilreklame.DataTransformations.Domain.Levering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Implementation;

namespace Mobilreklame.ViewModel.Domain.Levering
{
    class ViewModelFactory : ViewModelFactoryBase<LeveringViewModel>
    {
        public override IDataWrapper<LeveringViewModel> CreateDetailsViewModel(LeveringViewModel obj)
        {
            return new DetailsViewModel(obj);
        }

        public override IDataWrapper<LeveringViewModel> CreateItemViewModel(LeveringViewModel obj)
        {
            return new ItemViewModel(obj);
        }
    }
}
