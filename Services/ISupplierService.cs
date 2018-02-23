using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Services
{
    public interface ISupplierService
    {
        List<Supplier> GetAll();
        Supplier GetById(int supplierId);
        int Add(Supplier supplier);
        bool Update(Supplier supplier);
        bool Delete(int supplierId);
    }
}
