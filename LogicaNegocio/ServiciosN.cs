using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using AccesoDatos;

namespace LogicaNegocio
{
    public class ServiciosN
    {
        public static serviciosD obj = new serviciosD();


        public static List<Servicios> GetServicios()
        {
            
            return obj.GetServicios();
        }

        public static void Agregar(Servicios servicio)
        {
            obj.Agregar(servicio);
        }

        public static Servicios ObtenerServicio(int id)
        {
            return obj.ObtenerServicio(id);
        }

        public static void Editar(Servicios servicio)
        {
            obj.Editar(servicio);
        }

        public static void Eliminar(int id)
        {
            obj.Eliminar(id);
        }
    }
}
