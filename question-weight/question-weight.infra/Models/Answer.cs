using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace question_weight.infra.Models
{
    public class Answer : Base
    {
        public virtual TypeAnswer TypeAnswer { get; set; }

        [Required]
        public long TypeAnswerID { get; set; }

        public virtual TypeAnswer Question { get; set; }

        [Required]
        public long QuestionID { get; set; }

        [Required]
        public int Weight { get; set; }

    }
}
