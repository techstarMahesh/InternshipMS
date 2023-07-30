namespace InternshipMS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class remark
    {
        public int id { get; set; }

        public int submission_id { get; set; }

        public int guide_id { get; set; }

        [Column("remark", TypeName = "text")]
        [Required]
        public string remark1 { get; set; }

        public DateTime? created_at { get; set; }

        public virtual user user { get; set; }

        public virtual submission submission { get; set; }
    }
}
