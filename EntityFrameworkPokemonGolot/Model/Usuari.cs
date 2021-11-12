using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Connexio
{
    public partial class Usuari
    {
        public Usuari()
        {
            ObjecteUsuaris = new HashSet<ObjecteUsuari>();
            UsuariAmicNomUsuariNavigations = new HashSet<UsuariAmic>();
            UsuariPokemonCaramels = new HashSet<UsuariPokemonCaramel>();
            UsuariPokemons = new HashSet<UsuariPokemon>();
            PokedexUsuaris = new HashSet<PokedexUsuari>();
            RegalContingutEmisorNavigations = new HashSet<RegalContingut>();
            RegalContingutReceptorNavigations = new HashSet<RegalContingut>();
        }
        [Key]
        [Column("nom_usuari",TypeName ="varchar(25)")]
        public string NomUsuari { get; set; }
        [Column("nivell")]
        public double? Nivell { get; set; }
        [Column("data_creacio")]
        public DateTime? DataCreacio { get; set; }
        [Column("distancia")]
        public double? Distancia { get; set; }
        [Column("polvos_estelares")]
        public int? PolvosEstelares { get; set; }
        [Column("is_online")]
        public bool? IsOnline { get; set; }
        [Column("nom_equip",TypeName ="varchar(30)")]
        public string NomEquip { get; set; }

        public virtual Equip NomEquipNavigation { get; set; }
        public virtual UsuariAmic UsuariAmicNomUsuariAmicNavigation { get; set; }
        public virtual UsuariOpcion UsuariOpcion { get; set; }
        public virtual ICollection<ObjecteUsuari> ObjecteUsuaris { get; set; }
        public virtual ICollection<UsuariAmic> UsuariAmicNomUsuariNavigations { get; set; }
        public virtual ICollection<UsuariPokemonCaramel> UsuariPokemonCaramels { get; set; }
        public virtual ICollection<UsuariPokemon> UsuariPokemons { get; set; }
         public virtual ICollection<PokedexUsuari> PokedexUsuaris { get; set; }
        public virtual ICollection<RegalContingut> RegalContingutEmisorNavigations { get; set; }
        public virtual ICollection<RegalContingut> RegalContingutReceptorNavigations { get; set; }
    }
}
