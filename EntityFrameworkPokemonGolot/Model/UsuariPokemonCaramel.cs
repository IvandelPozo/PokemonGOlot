using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Connexio
{
    public partial class UsuariPokemonCaramel
    {
        [Key]
        [Column("nom_usuari",TypeName ="varchar(25)")]
        public string NomUsuari { get; set; }
        [Key]
        [Column("num_pokemon")]
        public int NumPokemon { get; set; }
        [Column("quantitat")]
        public int? Quantitat { get; set; }

        public virtual Usuari NomUsuariNavigation { get; set; }
        public virtual Pokemon NumPokemonNavigation { get; set; }
    }
}
