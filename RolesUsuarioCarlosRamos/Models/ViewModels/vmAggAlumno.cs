﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RolesUsuarioCarlosRamos.Models.ViewModels
{
    public class vmAggAlumno
    {
        public Alumno Alumno { get; set; }
        public Docente Docente { get; set; }
        public IEnumerable<Docente> lstDocentes { get; set; }
    }
}
