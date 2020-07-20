using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using AccesoDatos;

namespace LogicaNegocio
{
    public class Vehiculo_ServicioN
    {
        private static vehiculo_ServicioD obj = new vehiculo_ServicioD();


        public static List<Vehiculo_Servicio> GetVehiculo_Servicio()
        {
            return obj.GetVehiculo_Servicio();
        }


        public static void Agregar(Vehiculo_Servicio vehiculo_Servicio)
        {
            obj.Agregar(vehiculo_Servicio);
        }

        public static Vehiculo_Servicio ObtenerVehiculo_Servicio(int id)
        {
            return obj.ObtenerVehiculo_Servicio(id);
        }

        public static void Editar(Vehiculo_Servicio vehiculo_Servicio)
        {
            obj.Editar(vehiculo_Servicio);
        }

        public static void Eliminar(int id)
        {
            obj.Eliminar(id);
        }
    }
}
