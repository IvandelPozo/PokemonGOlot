using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Connexio
{
    public partial class Pokeparada
    {   
         [Key]
        [Column("latitud")]
        public double Latitud { get; set; }
        [Key]
        [Column("longitud")]
        public double Longitud { get; set; }
        [Column("nom_pokeparada",TypeName ="varchar(40)")]
        public string NomPokeparada { get; set; }
        [Column("descripcio_pokeparada",TypeName ="varchar(300)")]
        public string DescripcioPokeparada { get; set; }
        [Column("img_pokeparada",TypeName ="varchar(100)")]
        public string ImgPokeparada { get; set; }
        [Column("tipus_pokeparada",TypeName ="varchar(50)")]
        public string TipusPokeparada { get; set; }

        public virtual TipusPokeparada TipusPokeparadaNavigation { get; set; }
    }
}
