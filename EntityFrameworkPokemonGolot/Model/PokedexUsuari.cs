using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Connexio
{
    public partial class PokedexUsuari
    {
        [Key]
        [Column("num_pokedex")]
        public int NumPokedex { get; set; }
        [Column("nom_usuari",TypeName ="varchar(25)")]
        public string NomUsuari { get; set; }
        [Column("data_visualitzacio")]
        public DateTime? DataVisualitzacio { get; set; }
        [Column("cops_atrapats")]
        public int? CopsAtrapat { get; set; }
        [Column("hasSeenShiny")]
        public bool? HasSeenShiny { get; set; }

        public virtual Usuari NomUsuariNavigation { get; set; }
        public virtual Pokemon NumPokedexNavigation { get; set; }
    }
}
