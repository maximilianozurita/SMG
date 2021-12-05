
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Conexion_BD
{
 public class EmailService
    {
        private MailMessage email;
        private SmtpClient server;

        public  EmailService()
        {
            server = new SmtpClient();
            server.Credentials = new NetworkCredential("gabicordoba1998@gmail.com", "RubenGabriel");
            server.EnableSsl = true;
            server.Port = 587;
            server.Host = "smtp.gmail.com";
        }
        public void armarcorreo()
        {
            email = new MailMessage();
            email.From = new MailAddress("noresponder@ecomerceprogramacioniii.com");
            email.To.Add("smg2021.prog3@gmail.com");
            //email.subject=asunto;
            email.IsBodyHtml = true;
            email.Body = "<h3>registro de compra</h3> <p>hola hiciste una compra en la tienda de video juegos smg</p> <h4>gracias por su compra</h4>";
        }
        public void enviaremail()
        {
    
            try
            {
                server.Send(email);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
