using Fidelitas.DAL;
using Fidelitas.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Fidelitas.BS
{
    public class Mantenimiento :ICRUD<DAL.Automovil>
    {
        private static Mantenimiento Instancia;

        public static Mantenimiento _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new Mantenimiento();
                }
                return Instancia;
            }
            set
            {
                if (Instancia == null)
                {
                    Instancia = value;
                }
            }
        }

        public void Delete(Automovil entity)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Mantenimiento._Instancia.Delete(entity);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Automovil> GetAll()
        {
            List<Automovil> lista = new List<Automovil>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Mantenimiento._Instancia.GetAll();
                    scope.Complete();
                }
                return lista;
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public Automovil GetOneById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Automovil entity)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Mantenimiento._Instancia.Insert(entity);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Update(Automovil entity)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Mantenimiento._Instancia.Update(entity);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }

        }
    }
}
