using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Connexio
{
    public partial class Objecte
    {
        public Objecte()
        {
            ObjecteUsuaris = new HashSet<ObjecteUsuari>();
            RegalContinguts = new HashSet<RegalContingut>();
        }
        [Key]
        [Column("nom_objecte",TypeName ="varchar(30)")]
        public string NomObjecte { get; set; }
        [Column("descripcio_objecte",TypeName ="varchar(300)")]
        public string DescripcioObjecte { get; set; }
        [Column("img_objecte",TypeName ="varchar(100)")]
        public string ImgObjecte { get; set; }

        public virtual ICollection<ObjecteUsuari> ObjecteUsuaris { get; set; }
        public virtual ICollection<RegalContingut> RegalContinguts { get; set; }

    }
}
