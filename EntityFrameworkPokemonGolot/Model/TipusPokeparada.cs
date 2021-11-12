using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Connexio
{
    public partial class TipusPokeparada
    {
        public TipusPokeparada()
        {
            Pokeparada = new HashSet<Pokeparada>();
        }
        [Key]
        [Column("nom_pokeparada",TypeName ="varchar(50)")]
        public string NomTipus { get; set; }

        public virtual ICollection<Pokeparada> Pokeparada { get; set; }
    }
}
