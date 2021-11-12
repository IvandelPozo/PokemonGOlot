using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace Connexio
{
    public partial class Habilitat
    {
        public Habilitat()
        {
            HabilitatsPokemons = new HashSet<HabilitatsPokemon>();
            UsuariPokemonHabilitatPokemonCarregatNavigations = new HashSet<UsuariPokemon>();
            UsuariPokemonHabilitatPokemonSimpleNavigations = new HashSet<UsuariPokemon>();
        }
        [Key]
        [Column("nom_habilitat",TypeName ="varchar(40)")]
        public string NomHabilitat { get; set; }
        [Column("tipus_habilitat",TypeName ="varchar(40)")]
        public string TipusHabilitat { get; set; }
        [Column("dmg")]
        public int? Dmg { get; set; }
        [Column("descripcio_habilitat",TypeName ="varchar(150)")]
        public string DescripcioHabilitat { get; set; }

        public virtual ICollection<HabilitatsPokemon> HabilitatsPokemons { get; set; }
        public virtual ICollection<UsuariPokemon> UsuariPokemonHabilitatPokemonCarregatNavigations { get; set; }
        public virtual ICollection<UsuariPokemon> UsuariPokemonHabilitatPokemonSimpleNavigations { get; set; }
    }
}
