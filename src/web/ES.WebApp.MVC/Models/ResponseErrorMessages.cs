﻿using System.Collections.Generic;

namespace ES.WebApp.MVC.Models
{
    public class ResponseErrorMessages
    {
        public ResponseErrorMessages()
        {
            Mensagens = new List<string>();
        }
        public List<string> Mensagens { get; set; }
    }
}
