using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGI.Models.Usuarios
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public EStatus Status { get; set; }

    }
}