﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Model
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "varchar")]
        [Required]
        [MaxLength(50)]
        public string Code { get; set; }

        [MaxLength(50)]
        public string ValueString { get; set; }

        public int? ValueInt { get; set; }
    }
}