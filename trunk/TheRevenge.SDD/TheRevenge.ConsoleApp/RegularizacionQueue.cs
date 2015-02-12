using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using TheRevenge.Data.Dominio;
using TheRevenge.Data.Persistencia;

namespace TheRevenge.ConsoleApp
{
    class RegularizacionQueue
    {
        static void Main(string[] args)
        {
            CitaDAO dao = new CitaDAO();
            string rutaCola = @".\private$\CitaRecibida";
            if (MessageQueue.Exists(rutaCola) == true)
            {
                MessageQueue cola = new MessageQueue(rutaCola);
                Message[] msgs = cola.GetAllMessages();
                Cita _cita = new Cita();
                if (cola.GetAllMessages().Count() > 0)
                {
                    foreach (Message msg in cola.GetAllMessages())
                    {
                        msg.Formatter = new XmlMessageFormatter(new Type[] { typeof(Cita) });
                        _cita = (Cita)msg.Body;
                        if (dao.Obtener(_cita.IdCita) == null)
                        {
                            dao.Crear(_cita);
                        }
                        else
                        { 
                            dao.Modificar(_cita); 
                        }

                        cola.Receive();
                    }
                }
            }
        }
    }
}
