using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace AccesoDatos
{
    public class vehiculoD
    {
        //public vehiculoD()
        //{
        //    servicios = new List<Servicios>();
        //}


        //public ICollection<Servicios> servicios { get; set; }
        public void Agregar(Vehiculo vehiculo)
        {
            using (DB_PruebaEntities db = new DB_PruebaEntities())
            {
                db.Vehiculo.Add(vehiculo);
                db.SaveChanges();
            }

        }

        public List<Vehiculo> GetVehiculo()
        {
            using (DB_PruebaEntities db = new DB_PruebaEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                return db.Vehiculo.ToList();
            }
        }

        public Vehiculo ObtenerVehiculo(int id)
        {
            using (DB_PruebaEntities db = new DB_PruebaEntities())
            {
                return db.Vehiculo.Where(d => d.ID_Vehiculo == id).FirstOrDefault();
            }
        }

        public void Editar(Vehiculo vehiculo)
        {
            using(DB_PruebaEntities db = new DB_PruebaEntities())
            {
                var o = db.Vehiculo.Find(vehiculo.ID_Vehiculo);
                o.Placa = vehiculo.Placa;
                o.Dueño = vehiculo.Dueño;
                o.Marca = vehiculo.Marca;
                db.SaveChanges();

            }
        }

        public void Eliminar(int id)
        {
            using (DB_PruebaEntities db = new DB_PruebaEntities())
            {
                var vehiculo = db.Vehiculo.Find(id);
                db.Vehiculo.Remove(vehiculo);
                db.SaveChanges();
            }
        }
    }
}
