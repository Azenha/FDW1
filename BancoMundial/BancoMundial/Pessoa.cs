﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial
{
    public abstract class Pessoa
    {
        public static int NumeroDePessoas { get; set; }
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }

    }
}
