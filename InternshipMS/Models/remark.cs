namespace InternshipMS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Remark
    {
        public int Id { get; set; }

        public int Submission_id { get; set; }

        public int Guide_id { get; set; }

        [Column("remark", TypeName = "text")]
        [Required]
        public string Remarks { get; set; }

        public DateTime? Created_at { get; set; }

        public virtual User User { get; set; }

        public virtual Submission Submission { get; set; }
    }
}
