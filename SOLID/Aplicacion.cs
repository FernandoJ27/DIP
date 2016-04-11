using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Aplicacion
    {
        //El mensaje debe ser null debido a que no existe ningún evento aún.
        INotificar escritor = null;

        public void Notificar(string mensaje)
        {
            if (escritor == null)
            {
                
            }
            escritor.CrearNotificacion(mensaje);
        }
    }

    class EventLogWriter : INotificar
    {
        void INotificar.CrearNotificacion(string mensaje)
        {
            // Aquí se escribe el evento sucedido.
        }
    }

    class EnviarEmail : INotificar
    {
        void INotificar.CrearNotificacion(string mensaje)
        {
            // Aquí se escribe el evento sucedido.
        }
    }

    class EnviarSMS : INotificar
    {
        void INotificar.CrearNotificacion(string mensaje)
        {
            // Aquí se escribe el evento sucedido.
        }
    }

    // Como se puede observar, la dependencia entre clases a sido invertida. La clase principal Aplicacion, se comunica con nuestra clase Interfaz.
    // Y la interfaz se comunica a su vez con las diferentes clases para enviar mensajes. 

}
