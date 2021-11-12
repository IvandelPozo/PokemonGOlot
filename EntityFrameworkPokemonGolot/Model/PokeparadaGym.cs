using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Connexio
{
    public partial class PokeparadaGym
    {
        [Key]
        [Column("latitud")]
        public double Latitud { get; set; }
        [Key]
        [Column("longitud")]
        public double Longitud { get; set; }
        [Column("nom_equip",TypeName ="varchar(40)")]
        public string NomEquip { get; set; }
        [Column("nom_usuari_1")]
        public int? NomUsuari1 { get; set; }
        [Column("nom_usuari_2")]
        public int? NomUsuari2 { get; set; }
        [Column("nom_usuari_3")]
        public int? NomUsuari3 { get; set; }
        [Column("nom_usuari_4")]
        public int? NomUsuari4 { get; set; }
        [Column("nom_usuari_5")]
        public int? NomUsuari5 { get; set; }

        public virtual UsuariPokemon NomUsuari1Navigation { get; set; }
        public virtual UsuariPokemon NomUsuari2Navigation { get; set; }
        public virtual UsuariPokemon NomUsuari3Navigation { get; set; }
        public virtual UsuariPokemon NomUsuari4Navigation { get; set; }
        public virtual UsuariPokemon NomUsuari5Navigation { get; set; }
    }
}
