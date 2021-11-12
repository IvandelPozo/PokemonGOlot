using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Connexio
{
    public partial class RegalContingut
    {
        [Key]
        [Column("emisor",TypeName ="varchar(25)")]
        public string Emisor { get; set; }
        [Key]
        [Column("receptor",TypeName ="varchar(25)")]
        public string Receptor { get; set; }
        [Key]
        [Column("nom_objecte",TypeName ="varchar(30)")]
        public string NomObjecte { get; set; }
        [Column("quantitat")]
        public int? Quantitat { get; set; }

        public virtual Usuari EmisorNavigation { get; set; }
        public virtual Objecte NomObjecteNavigation { get; set; }
        public virtual Usuari ReceptorNavigation { get; set; }
    }
}
