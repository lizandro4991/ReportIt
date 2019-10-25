using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReportIt.Model
{
    [Table("Tbl_Denuncias")]
    public class DenunciaModel
    {
        [PrimaryKey, AutoIncrement, Unique]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoViolencia { get; set; }
        public string Direccion { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
    }
}
