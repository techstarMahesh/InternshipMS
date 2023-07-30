namespace InternshipMS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class submission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public submission()
        {
            remarks = new HashSet<remark>();
        }

        public int id { get; set; }

        public int intern_id { get; set; }

        public int task_id { get; set; }

        [Required]
        [StringLength(255)]
        public string file_name { get; set; }

        public DateTime? created_at { get; set; }

        public virtual intern intern { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<remark> remarks { get; set; }

        public virtual task task { get; set; }
    }
}
