namespace InternshipMS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reply
    {
        public int Id { get; set; }

        public int Query_id { get; set; }

        public int Guide_id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Answer { get; set; }

        public DateTime? Created_at { get; set; }

        public virtual Query Query { get; set; }

        public virtual User User { get; set; }
    }
}
