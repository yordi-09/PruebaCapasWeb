using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using AccesoDatos;

namespace LogicaNegocio
{
    public class VehiculoN
    {

        private static vehiculoD obj = new vehiculoD();

        public static void Agregar(Vehiculo vehiculo)
        {
            obj.Agregar(vehiculo);
        }

        public static List<Vehiculo> GetVehiculo()
        {
            return obj.GetVehiculo();
        }

        public static Vehiculo ObtenerVehiculo(int id)
        {
            return obj.ObtenerVehiculo(id);
        }


        public static void Editar(Vehiculo vehiculo)
        {
            obj.Editar(vehiculo);
        }

        public static void Eliminar(int id)
        {
            obj.Eliminar(id);
        }
    }
}
