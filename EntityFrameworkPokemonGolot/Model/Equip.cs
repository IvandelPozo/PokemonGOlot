using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace Connexio
{
    public partial class Equip
    {
        public Equip()
        {
            Usuaris = new HashSet<Usuari>();
            InventariEquips = new HashSet<InventariEquip>();
        }
        [Key]
        [Column("nom_equip",TypeName ="varchar(30)")]
        public string NomEquip { get; set; }
         [Column("img_equip",TypeName ="varchar(100)")]
        public string ImgEquip { get; set; }

        public virtual ICollection<Usuari> Usuaris { get; set; }
        public virtual ICollection<InventariEquip> InventariEquips { get; set; }

    }
}
