using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace AccesoDatos
{
    public class vehiculo_ServicioD
    {
        public List<Vehiculo_Servicio> GetVehiculo_Servicio()
        {
            //var sql = @"select vs.[ID_Vehiculo-Servicio], v.Placa, v.Dueño, v.Marca, s.Descripción from Vehiculo v
            //    inner join [Vehiculo-Servicio] vs on v.ID_Vehiculo=vs.ID_Vehiculo
            //    inner join Servicios s on vs.ID_Servicio=s.ID_Servicio";

            using (DB_PruebaEntities db = new DB_PruebaEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                // return db.Database.SqlQuery<Vehiculo_Servicio>(sql).ToList();
                
                return db.Vehiculo_Servicio.ToList();
            }
        }


        public void Agregar(Vehiculo_Servicio vehiculo_Servicio)
        {
            using (DB_PruebaEntities db = new DB_PruebaEntities())
            {
                db.Vehiculo_Servicio.Add(vehiculo_Servicio);
                db.SaveChanges();
            }
        }

        public Vehiculo_Servicio ObtenerVehiculo_Servicio(int id)
        {
            using (DB_PruebaEntities db = new DB_PruebaEntities())
            {
                return db.Vehiculo_Servicio.Where(d => d.ID_Vehiculo_Servicio == id).FirstOrDefault();
            }
        }

        public void Editar(Vehiculo_Servicio vehiculo_Servicio)
        {
            using (DB_PruebaEntities db = new DB_PruebaEntities())
            {
                var o = db.Vehiculo_Servicio.Find(vehiculo_Servicio.ID_Servicio);
                o.ID_Servicio = vehiculo_Servicio.ID_Servicio;
                o.ID_Vehiculo = vehiculo_Servicio.ID_Vehiculo;
                db.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            using (DB_PruebaEntities db = new DB_PruebaEntities())
            {
                var vehiculo_Servicio = db.Vehiculo_Servicio.Find(id);
                db.Vehiculo_Servicio.Remove(vehiculo_Servicio);
                db.SaveChanges();
            }
        }
    }
}
