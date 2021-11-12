using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Connexio
{
    public partial class UsuariOpcion
    {
        [Key]
        [Column("nom_usuari",TypeName ="varchar(25)")]
        public string NomUsuari { get; set; }
        [Column("musica")]
        public int? Musica { get; set; }
        [Column("soroll")]
        public int? Soroll { get; set; }
        [Column("vibracio")]
        public bool? Vibracio { get; set; }

        public virtual Usuari NomUsuariNavigation { get; set; }
    }
}
