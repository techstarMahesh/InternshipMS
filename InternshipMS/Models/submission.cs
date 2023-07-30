namespace InternshipMS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Submission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Submission()
        {
            Remarks = new HashSet<Remark>();
        }

        public int Id { get; set; }

        public int Intern_id { get; set; }

        public int Task_id { get; set; }

        [Required]
        [StringLength(255)]
        public string File_name { get; set; }

        public DateTime? Created_at { get; set; }

        public virtual Intern Intern { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Remark> Remarks { get; set; }

        public virtual Task Task { get; set; }
    }
}
