using ExtensionsViewModel.Implementation;
using InMemoryStorage.Implementation;
using Mobilreklame.DataTransformations.Domain.Ordre;
using Mobilreklame.Model.App;

namespace Mobilreklame.ViewModel.Domain.Ordre
{
    public class ItemViewModel : ItemViewModelWithImage<OrdreViewModel>
    {
        public string DescriptionCar
        {
            get { return GetCar() == null ? string.Empty : GetCar().LicensePlate; }
        }

        public string DescriptionCustomer
        {
            get { return GetCustomer() == null ? string.Empty : "Bought by " + GetCustomer().FullName; }
        }

        public string DescriptionEmployee
        {
            get { return GetEmployee() == null ? string.Empty : "Sold by " + GetEmployee().FullName; }
        }

        public override string Description
        {
            get { return "Not used"; }
        }

        public override int FontSize
        {
            get { return 14; }
        }

        public override int ImageKey
        {
            get { return GetCar() != null ? GetCar().ImageKey : StorableBase.NullKey; }
        }

        private CarVMO GetCar()
        {
            return ObjectProvider.CarCatalog.Read(DataObject.CarKey) as CarVMO;
        }

        private CustomerVMO GetCustomer()
        {
            return ObjectProvider.CustomerCatalog.Read(DataObject.CustomerKey) as CustomerVMO;
        }

        private EmployeeVMO GetEmployee()
        {
            return ObjectProvider.EmployeeCatalog.Read(DataObject.EmployeeKey) as EmployeeVMO;
        }

        public ItemViewModel(SaleVMO obj) : base(obj)
        {
        }
    }
}