using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace Connexio
{
    public partial class UsuariAmic
    {
        [Key]
        [Column("nom_usuari",TypeName ="varchar(25)")]
        public string NomUsuari { get; set; }
        [Key]
        [Column("nom_usuari_amic",TypeName ="varchar(25)")]
        public string NomUsuariAmic { get; set; }

        public virtual Usuari NomUsuariAmicNavigation { get; set; }
        public virtual Usuari NomUsuariNavigation { get; set; }
    }
}
