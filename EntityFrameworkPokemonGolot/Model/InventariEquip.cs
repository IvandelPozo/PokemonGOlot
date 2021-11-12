using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable


namespace Connexio
{
    public partial class InventariEquip
    {
        [Key]
        [Column("nom_equip",TypeName ="varchar(30)")]
        public string NomEquip { get; set; }
         [Column("nom_objecte_equip",TypeName ="varchar(30)")]
        public string NomObjecteEquip { get; set; }
        [Column("quantitat")]
        public int? Quantitat { get; set; }

        public virtual Equip NomEquipNavigation { get; set; }
        public virtual ObjecteEquip NomObjecteEquipNavigation { get; set; }
    }
}
