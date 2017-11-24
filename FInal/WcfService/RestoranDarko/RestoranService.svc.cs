using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RestoranDarko.Model;
using RestoranDarko.Db;

namespace RestoranDarko
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RestoranService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RestoranService.svc or RestoranService.svc.cs at the Solution Explorer and start debugging.
    public class RestoranService : IRestoranService
    {
        MusterijaDbContext db = new MusterijaDbContext();
        

        public void AddMusterija(Musterija m)
        {
            db.Musterija.Add(m);
            db.SaveChanges();
        }

        public void AddFood(Food f)
        {
            throw new NotImplementedException();
        }

        

        public string Comment(Musterija m)
        {
            throw new NotImplementedException();
        }

        public Musterija Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Musterija> GetAllCustomers()
        {
            return db.Musterija.ToList();
        }

        public void Order(Musterija m)
        {
            throw new NotImplementedException();
        }

        public void Phone(Musterija m)
        {
            throw new NotImplementedException();
        }

        public void Rating(Musterija m)
        {
            throw new NotImplementedException();
        }

        public void RemoveMusterija(int id)
        {
            throw new NotImplementedException();
        }
    }
}
