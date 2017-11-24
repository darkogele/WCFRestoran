using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RestoranDarko.Model;

namespace RestoranDarko
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRestoranService" in both code and config file together.
    [ServiceContract]
    public interface IRestoranService
    {
        [OperationContract]
        List<Musterija> GetAllCustomers();

        [OperationContract]
        Musterija Get(int Id);

        [OperationContract]
        void AddMusterija(Musterija m);

        [OperationContract]
        void AddFood(Food f);

        [OperationContract]
        void Order(Musterija m);

        [OperationContract]
        void Phone(Musterija m);

        //[OperationContract]
        //void EditOrder(Musterija m);

        //[OperationContract]
        //void RemoveOrder(int id);

        [OperationContract]
        void RemoveMusterija(int id);

        [OperationContract]
        string Comment(Musterija m);

        [OperationContract]
        void Rating(Musterija m);

        //[OperationContract]
        //void EditRating(Musterija m);
    }
}
