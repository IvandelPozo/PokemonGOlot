using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Connexio
{
    public partial class Temp
    {
        public Temp()
        {
            TipusPotenciatClimas = new HashSet<TipusPotenciatClima>();
        }
        [Key]
        [Column("nom_temps",TypeName ="varchar(30)")]
        public string NomTemps { get; set; }
        [Column("img_temps",TypeName ="varchar(100)")]
        public string ImgTemps { get; set; }
        public virtual ICollection<TipusPotenciatClima> TipusPotenciatClimas { get; set; }

    }
}
