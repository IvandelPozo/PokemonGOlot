using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Connexio
{
    public partial class Tipu
    {
        public Tipu()
        {
            Pokemons = new HashSet<Pokemon>();
              TipusPotenciatClimas = new HashSet<TipusPotenciatClima>();
        }
        [Key]
        [Column("nom_tipus",TypeName ="varchar(40)")]
        public string NomTipus { get; set; }
        [Column("nom_color",TypeName ="varchar(7)")]
        public string NomColorHexadecimal { get; set; }

        public virtual ICollection<Pokemon> Pokemons { get; set; }
        public virtual ICollection<TipusPotenciatClima> TipusPotenciatClimas { get; set; }

    }
}
