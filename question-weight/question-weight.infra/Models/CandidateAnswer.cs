using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace question_weight.infra.Models
{
    public class CandidateAnswer : Base
    {
        public virtual TypeAnswer Candidate { get; set; }

        [Required]
        public long CandidateID { get; set; }

        public virtual TypeAnswer Question { get; set; }

        [Required]
        public long QuestionID { get; set; }

        public virtual Answer Answer { get; set; }

        [Required]
        public long AnswerID { get; set; }
    }
}
