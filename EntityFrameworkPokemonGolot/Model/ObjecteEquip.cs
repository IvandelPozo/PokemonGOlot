using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Connexio
{
    public partial class ObjecteEquip
    {
        public ObjecteEquip()
        {
            InventariEquips = new HashSet<InventariEquip>();
        }
        [Key]
        [Column("nom_objecte_equip",TypeName ="varchar(30)")]
        public string NomObjecteEquip { get; set; }
        [Column("descripcio_objecte_equip",TypeName ="varchar(200)")]
        public string Desc { get; set; }
         [Column("img",TypeName ="varchar(100)")]
        public string Img { get; set; }
         [Column("valor")]
        public int? Valor { get; set; }

        public virtual ICollection<InventariEquip> InventariEquips { get; set; }
    }
}
