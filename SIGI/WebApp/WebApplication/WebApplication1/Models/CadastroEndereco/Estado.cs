﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGI.Models.CadastroEndereco
{
    public class Estado
    {
     
        public int Id { get; set; }
        public int PaisID { get; set; }
        public Pais Pais { get; set; }
        public string  Nome { get; set; }


    }
}