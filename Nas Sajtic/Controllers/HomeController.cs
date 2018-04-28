using Nas_Sajtic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Nas_Sajtic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Galerija()
        {
            return View();
        }


        public ActionResult ONama ()
        {
            return View();
        }

        public ActionResult Kontakt ()
        {
            return View(new Contact());
        }

        public ActionResult RadoviUToku ()
        {
            return View();
        }

        public ActionResult SendMessage(Contact c)
        {
            if (ModelState.IsValid)
            {
                MailAddress sender = new MailAddress(c.Email);
                MailAddress reciever = new MailAddress("MikroMarsBg@gmail.com");

                MailMessage message = new MailMessage();

                message.From = sender;
                message.To.Add(reciever);
                message.Subject = "Poruka od: " + c.Name + " , " + c.Email;
                message.IsBodyHtml = true;
                message.Body = c.Message;

                SmtpClient client = new SmtpClient("smtp.gmail.com");

                client.EnableSsl = true;
                client.Port = 587;
                client.Credentials = new NetworkCredential("MikroMarsBg@gmail.com", "Sifrazamejl1");

                try
                {

                    client.Send(message);
                    Response.Write("<script>alert('Poruka poslana!');</script>");
                    return View("Index");
                }
                catch (Exception)
                {
                    return Redirect("Kontakt");
                }
            }
            return View("Kontakt", c);
        }
    }
}