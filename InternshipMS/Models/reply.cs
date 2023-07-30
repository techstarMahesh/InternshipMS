namespace InternshipMS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class reply
    {
        public int id { get; set; }

        public int query_id { get; set; }

        public int guide_id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string answer { get; set; }

        public DateTime? created_at { get; set; }

        public virtual query query { get; set; }

        public virtual user user { get; set; }
    }
}
