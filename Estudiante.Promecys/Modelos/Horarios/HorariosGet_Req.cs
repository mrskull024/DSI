﻿using System.ComponentModel.DataAnnotations;

namespace Modelos.Horarios_Req
{
    public class HorariosGet_Req
    {
        [Required(ErrorMessage = "{0} es requerido")]
        public int id { get; set; }
    }
}
