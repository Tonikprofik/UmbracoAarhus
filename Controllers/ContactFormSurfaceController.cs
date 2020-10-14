﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Core.Models;
using UmbracoAarhus.ViewModels;
using System.Net.Mail;


namespace UmbracoAarhus.Controllers
{
    public class ContactFormSurfaceController : SurfaceController
    {
        // GET: ContactFormSurface
        public ActionResult Index()
        {
            return PartialView("ContactForm", new ContactForm());
        }

        [HttpPost]
        public ActionResult HandleFormSubmit(ContactForm model)
        {
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }

            //send mail
            MailMessage message = new MailMessage();
            message.To.Add("siteadmin@domain");
            message.Subject = "New Contact request";
            message.From = new System.Net.Mail.MailAddress(model.Email, model.Name);
            message.Body = model.Message;
            SmtpClient smtp = new SmtpClient();
            smtp.Send(message);

            TempData["success"] = true;

            //saving data to umbraco backend Les4 Ex2 - 2.
            IContent comment = Services.ContentService.Create(model.Subject, CurrentPage.Id, "comment");
            comment.SetValue("username", model.Name);
            comment.SetValue("email", model.Email);
            comment.SetValue("subject", model.Subject);
            comment.SetValue("message", model.Message);
            Services.ContentService.Save(comment);

            return RedirectToCurrentUmbracoPage();
        }
    }
}