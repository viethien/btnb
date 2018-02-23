using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SupplierService : ISupplierService
    {
        private ISupplierRepository supplierRepository = new SupplierRepository();
        public List<Models.Supplier> GetAll()
        {
            return supplierRepository.GetAll();
        }

        public Models.Supplier GetById(int supplierId)
        {
            return supplierRepository.GetById(supplierId);
        }

        public int Add(Models.Supplier supplier)
        {
            return supplierRepository.Add(supplier);
        }

        public bool Update(Models.Supplier supplier)
        {
            return supplierRepository.Update(supplier);
        }

        public bool Delete(int supplierId)
        {
            return supplierRepository.Delete(supplierId);
        }
    }
}
