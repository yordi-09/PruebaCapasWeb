using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace AccesoDatos
{
    public class serviciosD
    {
        public List<Servicios> GetServicios()
        {
            using (DB_PruebaEntities db = new DB_PruebaEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                return db.Servicios.ToList();
            }
        }

        public void Agregar(Servicios servicio)
        {
            using (DB_PruebaEntities db = new DB_PruebaEntities())
            {
                db.Servicios.Add(servicio);
                db.SaveChanges();
            }
        }

        public Servicios ObtenerServicio(int id)
        {
            using (DB_PruebaEntities db = new DB_PruebaEntities())
            {
                return db.Servicios.Where(d => d.ID_Servicio == id).FirstOrDefault();
            }
        }

        public void Editar(Servicios servicio)
        {
            using (DB_PruebaEntities db = new DB_PruebaEntities())
            {
                var o = db.Servicios.Find(servicio.ID_Servicio);
                o.Descripción = servicio.Descripción;
                o.Monto = servicio.Monto;
                db.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            using (DB_PruebaEntities db = new DB_PruebaEntities())
            {
                var servicio = db.Servicios.Find(id);
                db.Servicios.Remove(servicio);
                db.SaveChanges();
            }
        }
    }
}
