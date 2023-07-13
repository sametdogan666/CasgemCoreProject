﻿using System;

namespace PizzaPan.EntityLayer.Concrete
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string ContactSubject { get; set; }
        public string ContactMail { get; set; }
        public string ContactMessage { get; set; }
        public DateTime ContactSendDateMessage { get; set; }
    }
}