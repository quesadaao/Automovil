using Fidelitas.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fidelitas.DAL
{
    public class Mantenimiento: ICRUD<Automovil>
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
                AutomovilE entities = new AutomovilE();
                var result = entities.Automovil.Find(entity.iID);
                entities.Automovil.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Automovil> GetAll()
        {
            //Inicializamos
            List<Automovil> lista = new List<Automovil>();

            try
            {
                AutomovilE entities = new AutomovilE();
                lista = entities.Automovil.ToList();
                entities.SaveChanges();

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
                AutomovilE entities = new AutomovilE();
                entities.Automovil.Add(entity);
                entities.SaveChanges();

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
                using (AutomovilE entities = new AutomovilE())
                {
                    entities.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();

                    //var result = entities.Personas.Find(persona.iID);
                    //result = persona;
                    //entities.SaveChanges();
                }


            }
            catch (Exception ee)
            {

                throw;
            }
        }

        //public void Insertar(DO.Persona persona)
        //{
        //    DbProviderFactory factory = DbProviderFactories.GetFactory(Settings.Default.proveedor);
        //    DbConnection conn = null;
        //    DbCommand comm = null;

        //    try
        //    {
        //        conn = factory.CreateConnection();
        //        conn.ConnectionString = Settings.Default.connection;
        //        comm = factory.CreateCommand();

        //        DbParameter param1 = factory.CreateParameter();
        //        DbParameter param2 = factory.CreateParameter();
        //        DbParameter param3 = factory.CreateParameter();
        //        DbParameter param4 = factory.CreateParameter();
        //        DbParameter param5 = factory.CreateParameter();
        //        DbParameter param6 = factory.CreateParameter();

        //        //Carga de Parametros
        //        param1.ParameterName = "@iCedula";
        //        param1.DbType = System.Data.DbType.Int32;
        //        param1.Value = persona.ICedula;

        //        param2.ParameterName = "@vNombre";
        //        param2.DbType = System.Data.DbType.String;
        //        param2.Value = persona.VNombre;

        //        param3.ParameterName = "@bMuerto";
        //        param3.DbType = System.Data.DbType.Boolean;
        //        param3.Value = persona.BMuerto;

        //        param4.ParameterName = "@dtNacimiento";
        //        param4.DbType = System.Data.DbType.Date;
        //        param4.Value = persona.DTNacimiento;

        //        param5.ParameterName = "@iEdad";
        //        param5.DbType = System.Data.DbType.Int32;
        //        param5.Value = persona.IEdad;

        //        param6.ParameterName = "@vEmail";
        //        param6.DbType = System.Data.DbType.String;
        //        param6.Value = persona.VEmail;

        //        //Abrir Coneccion 
        //        comm.Connection = conn;
        //        conn.Open();

        //        //Ejecutar Store Procedure
        //        comm.CommandType = System.Data.CommandType.TableDirect;
        //        comm.CommandText = "sp_Inserta";
        //        comm.Parameters.Add(param1);
        //        comm.Parameters.Add(param2);
        //        comm.Parameters.Add(param3);
        //        comm.Parameters.Add(param4);
        //        comm.Parameters.Add(param5);
        //        comm.Parameters.Add(param6);
        //        comm.ExecuteNonQuery();
        //    }
        //    catch (Exception ee)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        comm.Dispose();
        //        conn.Dispose();
        //    }
        //}

        //public List<DO.Persona> Mostar()
        //{
        //    //Inicializamos 
        //    List<DO.Persona> lista = new List<DO.Persona>();
        //    // Creamos patro de fabrica 
        //    // Pasamos proveedor que esta en el archivo de configuracion para obtener string de conx
        //    // Variables e Inicializacion
        //    DbConnection conn = null;
        //    DbCommand comm = null;
        //    try
        //    {
        //        DbProviderFactory factory = DbProviderFactories.GetFactory(Settings.Default.proveedor);

        //        //Creacion de la connection
        //        conn = factory.CreateConnection();
        //        conn.ConnectionString = Settings.Default.connection;
        //        comm = factory.CreateCommand();

        //        //Abrir connection
        //        comm.Connection = conn;
        //        conn.Open();

        //        //Ejecuta SP
        //        comm.CommandType = System.Data.CommandType.StoredProcedure;
        //        comm.CommandText = "sp_Mostrar";

        //        using (IDataReader dataReader = comm.ExecuteReader())
        //        {
        //            DO.Persona persona;
        //            while (dataReader.Read())
        //            {
        //                persona = new DO.Persona
        //                {
        //                    ICedula = Convert.ToInt32(dataReader["iCedula"].ToString()),
        //                    VNombre = dataReader["vNombre"].ToString(),
        //                    BMuerto = Convert.ToBoolean(dataReader["bMuerto"].ToString()),
        //                    DTNacimiento = Convert.ToDateTime(dataReader["dtNacimiento"].ToString()),
        //                    IEdad = Convert.ToInt32(dataReader["iEdad"].ToString()),
        //                    VEmail = dataReader["vEmail"].ToString()
        //                };
        //                lista.Add(persona);
        //            }
        //        }

        //        return lista;
        //    }
        //    catch (Exception ee)
        //    {
        //        throw;
        //    }
        //}

        //public void Actualizar(DO.Persona persona)
        //{
        //    DbProviderFactory factory = DbProviderFactories.GetFactory(Settings.Default.proveedor);
        //    DbConnection conn = null;
        //    DbCommand comm = null;

        //    try
        //    {
        //        conn = factory.CreateConnection();
        //        conn.ConnectionString = Settings.Default.connection;
        //        comm = factory.CreateCommand();

        //        DbParameter param1 = factory.CreateParameter();
        //        DbParameter param2 = factory.CreateParameter();
        //        DbParameter param3 = factory.CreateParameter();
        //        DbParameter param4 = factory.CreateParameter();
        //        DbParameter param5 = factory.CreateParameter();
        //        DbParameter param6 = factory.CreateParameter();

        //        //Carga de Parametros
        //        param1.ParameterName = "@iCedula";
        //        param1.DbType = System.Data.DbType.Int32;
        //        param1.Value = persona.ICedula;

        //        param2.ParameterName = "@vNombre";
        //        param2.DbType = System.Data.DbType.String;
        //        param2.Value = persona.VNombre;

        //        param3.ParameterName = "@bMuerto";
        //        param3.DbType = System.Data.DbType.Boolean;
        //        param3.Value = persona.BMuerto;

        //        param4.ParameterName = "@dtNacimiento";
        //        param4.DbType = System.Data.DbType.Date;
        //        param4.Value = persona.DTNacimiento;

        //        param5.ParameterName = "@iEdad";
        //        param5.DbType = System.Data.DbType.Int32;
        //        param5.Value = persona.IEdad;

        //        param6.ParameterName = "@vEmail";
        //        param6.DbType = System.Data.DbType.String;
        //        param6.Value = persona.VEmail;

        //        //Abrir Coneccion 
        //        comm.Connection = conn;
        //        conn.Open();

        //        //Ejecutar Store Procedure
        //        comm.CommandType = System.Data.CommandType.StoredProcedure;
        //        comm.CommandText = "sp_Actualizar";
        //        comm.Parameters.Add(param1);
        //        comm.Parameters.Add(param2);
        //        comm.Parameters.Add(param3);
        //        comm.Parameters.Add(param4);
        //        comm.Parameters.Add(param5);
        //        comm.Parameters.Add(param6);
        //        comm.ExecuteNonQuery();
        //    }
        //    catch (Exception ee)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        comm.Dispose();
        //        conn.Dispose();
        //    }
        //}

        //public void Borrar(DO.Persona persona)
        //{
        //    DbProviderFactory factory = DbProviderFactories.GetFactory(Settings.Default.proveedor);
        //    DbConnection conn = null;
        //    DbCommand comm = null;

        //    try
        //    {
        //        conn = factory.CreateConnection();
        //        conn.ConnectionString = Settings.Default.connection;
        //        comm = factory.CreateCommand();

        //        DbParameter param1 = factory.CreateParameter();

        //        //Carga de Parametros
        //        param1.ParameterName = "@iCedula";
        //        param1.DbType = System.Data.DbType.Int32;
        //        param1.Value = persona.ICedula;

        //        //Abrir Coneccion 
        //        comm.Connection = conn;
        //        conn.Open();

        //        //Ejecutar Store Procedure
        //        comm.CommandType = System.Data.CommandType.StoredProcedure;
        //        comm.CommandText = "sp_Borrar";
        //        comm.Parameters.Add(param1);
        //        comm.ExecuteNonQuery();
        //    }
        //    catch (Exception ee)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        comm.Dispose();
        //        conn.Dispose();
        //    }
        //}

    }
}
