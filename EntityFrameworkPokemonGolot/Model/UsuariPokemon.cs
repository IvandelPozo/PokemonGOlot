using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Connexio
{
    public partial class UsuariPokemon
    {
        public UsuariPokemon()
        {
            PokeparadaGymNomUsuari1Navigations = new HashSet<PokeparadaGym>();
            PokeparadaGymNomUsuari2Navigations = new HashSet<PokeparadaGym>();
            PokeparadaGymNomUsuari3Navigations = new HashSet<PokeparadaGym>();
            PokeparadaGymNomUsuari4Navigations = new HashSet<PokeparadaGym>();
            PokeparadaGymNomUsuari5Navigations = new HashSet<PokeparadaGym>();
        }

        [Key]
        [Column("id_usuari_pokemon")]
        public int IdUsuariPokemon { get; set; }
        [Column("nom_usuari",TypeName ="varchar(25)")]
        public string NomUsuari { get; set; }
        [Column("data_captura")]
        public DateTime DataCaptura { get; set; }
        [Column("num_pokedex")]
        public int NumPokedex { get; set; }
        [Column("pc")]
        public int? Pc { get; set; }
        [Column("ps")]
        public int? Ps { get; set; }
        [Column("habilitat_pokemon_simple",TypeName ="varchar(40)")]
        public string HabilitatPokemonSimple { get; set; }
        [Column("habilitat_pokemon_carregat",TypeName ="varchar(40)")]
        public string HabilitatPokemonCarregat { get; set; }
        [Column("is_in_gym")]
        public bool? IsInGym { get; set; }
       

        public virtual Habilitat HabilitatPokemonCarregatNavigation { get; set; }
        public virtual Habilitat HabilitatPokemonSimpleNavigation { get; set; }
        public virtual Usuari NomUsuariNavigation { get; set; }
        public virtual Pokemon NumPokedexNavigation { get; set; }
        public virtual ICollection<PokeparadaGym> PokeparadaGymNomUsuari1Navigations { get; set; }
        public virtual ICollection<PokeparadaGym> PokeparadaGymNomUsuari2Navigations { get; set; }
        public virtual ICollection<PokeparadaGym> PokeparadaGymNomUsuari3Navigations { get; set; }
        public virtual ICollection<PokeparadaGym> PokeparadaGymNomUsuari4Navigations { get; set; }
        public virtual ICollection<PokeparadaGym> PokeparadaGymNomUsuari5Navigations { get; set; }
    }
}
