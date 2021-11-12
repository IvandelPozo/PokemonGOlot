using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace Connexio
{
    public partial class TipusPotenciatClima
    {
        [Key]
        [Column("nom_tipus",TypeName ="varchar(30)")] 
        public string NomTipus { get; set; }
        [Key]
        [Column("emisor",TypeName ="varchar(40)")]
        public string NomTemps { get; set; }

        public virtual Temp NomTempsNavigation { get; set; }
        public virtual Tipu NomTipusNavigation { get; set; }
    }
}
