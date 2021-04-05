using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace question_weight.infra.Models
{
    public class Base
    {
        [Key]
        public long ID { get; set; }

        [Required]
        public DateTime DtRegister { get; set; }

        [Required]
        public DateTime DtUpdate { get; set; }
    }
}
