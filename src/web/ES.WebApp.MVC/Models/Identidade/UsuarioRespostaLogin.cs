﻿
using ES.Core.Communication;

namespace ES.WebApp.MVC.Models
{
    public class UsuarioRespostaLogin
    {
        public string AccessToken { get; set; }
        public double ExpiresIn { get; set; }
        public UsuarioToken UsuarioToken { get; set; }
        public ResponseResult ResponseResult { get; set; }
    }
}
