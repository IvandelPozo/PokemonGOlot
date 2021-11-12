using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Connexio
{
    public partial class HabilitatsPokemon
    {
        [Key]
        [Column("num_pokedex")]
        public int NumPokedex { get; set; }
        [Key]
        [Column("nom_habilitat",TypeName ="varchar(40)")]
        public string NomHabilitat { get; set; }

        public virtual Habilitat NomHabilitatNavigation { get; set; }
        public virtual Pokemon NumPokedexNavigation { get; set; }
    }
}
