using System;
using System.Collections.Generic;

#nullable disable

namespace Mantenimiento_Api.EntityModels
{
    public partial class CrudBase
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcioncorta { get; set; }
        public string Descripcionlarga { get; set; }
        public DateTime? Fechacreacion { get; set; }
        public string Usuariocreacion { get; set; }
        public DateTime? Fechamodificacion { get; set; }
        public string Usuariomodificacion { get; set; }
        public bool Estado { get; set; }
    }
}
