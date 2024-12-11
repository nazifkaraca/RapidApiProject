using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ServicesManager : IServicesService
    {
        private readonly IServicesDal _servicesDal;

        public ServicesManager(IServicesDal servicesDal)
        {
            _servicesDal = servicesDal;
        }

        public void TDelete(Services t)
        {
            _servicesDal.Delete(t);
        }

        public Services TGetById(int id)
        {
            return _servicesDal.GetById(id);
        }

        public List<Services> TGetList()
        {
            return _servicesDal.GetList();
        }

        public void TInsert(Services t)
        {
            _servicesDal.Insert(t);
        }

        public void TUpdate(Services t)
        {
            _servicesDal.Update(t);
        }
    }
}
