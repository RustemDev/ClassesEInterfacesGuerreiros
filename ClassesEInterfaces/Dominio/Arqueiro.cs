﻿using ClassesEInterfaces.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesEInterfaces.Dominio
{
    class Arqueiro : IAcao
    {
        public string Nome { get; set; }
        public int Forca { get; set; }

        public string ArmaAtaque()
        {
            
            return "Arco e flecha";
        }
    }
}
