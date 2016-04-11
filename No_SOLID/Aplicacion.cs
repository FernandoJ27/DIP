using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No_SOLID
{
    //Un requerimiento de la aplicación es que pueda mandar un Mensaje al usuario, cada vez que ocurra algún evento importante.
    class Aplicacion
    {
        //El mensaje debe ser null debido a que no existe ningún evento aún.
        EventLogWriter escritor = null;

        //Cada vez que exista algún evento importante suceda.
        public void Notificar(string mensaje)
        {
            if (escritor == null)
            {
                //Instanciamos nuestra clase que "escribe" los eventos.
                escritor = new EventLogWriter();
            }
            //Escribimos el mensaje.
            escritor.Escribir(mensaje);
        }

    }

    class EventLogWriter
    {
        public void Escribir(string mensaje)
        {
            //Aquí se genera el mensaje del evento sucedido, y se le envía este al usuario.
        }
    }

    //EXPLICACION DEL PROBLEMA CON EL CODIGO

    // A primera instancia, el código da la impresión que esté bien estructurado. Pero la verdad, es que este código no respeta el principio de Dependencia Inversa.
    // La clase Aplicación depende de la clase EventLogWriter, y no de una clase Interfaz. 

    // El problema es el siguiente:
    // Existe un nuevo requerimiento. Se debe enviar un E-Mail al correo del Administrador de la App, con la descripción del evento sucedido (como algún error).
    // No es posible realizar esa tarea con esta clase. Por lo tanto, tendríamos que crear una clase EnviarEmail. 
    // Cuando necesitemos enviar nuestro mensaje, tendremos dos opciones: utilizar EventLogWriter o utilizar EnviarEmail.
    // Y si nuestro requerimiento sigue creciendo, como enviar un SMS, nuestro problema seguirá creciendo. 

    // Para este momento, es realmente claro que nuestra Aplicacion depende de las clases menores EventLogWriter, EnviarEmail y alguna otra que creemos con el mismo fin.
    // Es necesaria entonces una clase Interfaz que será usada por nuestra Aplicación cada vez que necesitemos mandar mensajes de cualquier tipo. 
}
