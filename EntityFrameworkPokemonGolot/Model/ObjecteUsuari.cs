using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Connexio
{
    public partial class ObjecteUsuari
    {
         [Key]
        [Column("nom_usuari",TypeName ="varchar(25)")]
        public string NomUsuari { get; set; }
        [Key]
        [Column("nom_objecte",TypeName ="varchar(25)")]
        public string NomObjecte { get; set; }
        [Column("quantitat")]
        public int? Quantitat { get; set; }

        public virtual Objecte NomObjecteNavigation { get; set; }
        public virtual Usuari NomUsuariNavigation { get; set; }
    }
}
