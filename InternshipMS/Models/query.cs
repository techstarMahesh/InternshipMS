namespace InternshipMS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class query
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public query()
        {
            replies = new HashSet<reply>();
        }

        public int id { get; set; }

        public int intern_id { get; set; }

        public int guide_id { get; set; }

        public int task_id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string question { get; set; }

        public DateTime? created_at { get; set; }

        public virtual intern intern { get; set; }

        public virtual user user { get; set; }

        public virtual task task { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reply> replies { get; set; }
    }
}
