﻿using System;
using System.Collections.Generic;

namespace RolesUsuarioCarlosRamos.Models
{
    public partial class Director
    {
        public int Id { get; set; }
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
    }
}
