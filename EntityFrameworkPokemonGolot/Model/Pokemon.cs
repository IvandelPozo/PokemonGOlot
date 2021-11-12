using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Connexio
{
    public partial class Pokemon
    {
        public Pokemon()
        {
            HabilitatsPokemons = new HashSet<HabilitatsPokemon>();
            UsuariPokemonCaramels = new HashSet<UsuariPokemonCaramel>();
            UsuariPokemons = new HashSet<UsuariPokemon>();
            PokedexUsuaris = new HashSet<PokedexUsuari>();

        }

        [Key]
        [Column("num_pokedex")]
        public int NumPokedex { get; set; }
        [Column("nom_pokemon",TypeName ="varchar(40)")]
        public string NomPokemon { get; set; }
        [Column("descripcio_pokemon",TypeName ="varchar(300)")]
        public string DescripcioPokemon { get; set; }
        [Column("img_pokemon",TypeName ="varchar(100)")]
        public string ImgPokemon { get; set; }
        [Column("tipus_pokemon",TypeName ="varchar(40)")]
        public string TipusPokemon { get; set; }
        [Column("ps_min")]
        public int? PsMin { get; set; }
        [Column("ps_max",TypeName ="varchar(40)")]
        public int? PsMax { get; set; }
        [Column("pc_min")]
        public int? PcMin { get; set; }
        [Column("pc_max")]
        public int? PcMax { get; set; }
        [Column("nom_familia",TypeName ="varchar(40)")]
        public string NomFamilia { get; set; }
        [Column("ordre_familia")]
        public int? OrdreFamilia { get; set; }

        public virtual Tipu TipusPokemonNavigation { get; set; }
        public virtual ICollection<HabilitatsPokemon> HabilitatsPokemons { get; set; }
        public virtual ICollection<UsuariPokemonCaramel> UsuariPokemonCaramels { get; set; }
        public virtual ICollection<UsuariPokemon> UsuariPokemons { get; set; }
        public virtual ICollection<PokedexUsuari> PokedexUsuaris { get; set; }

    }
}
