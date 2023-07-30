namespace InternshipMS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Query
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Query()
        {
            Replies = new HashSet<Reply>();
        }

        public int Id { get; set; }

        public int Intern_id { get; set; }

        public int Guide_id { get; set; }

        public int Task_id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Question { get; set; }

        public DateTime? Created_at { get; set; }

        public virtual Intern Intern { get; set; }

        public virtual User User { get; set; }

        public virtual Task Task { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reply> Replies { get; set; }
    }
}
