namespace InternshipMS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class intern
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public intern()
        {
            queries = new HashSet<query>();
            submissions = new HashSet<submission>();
        }

        public int id { get; set; }

        public int user_id { get; set; }

        public int guide_id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [Required]
        [StringLength(255)]
        public string email { get; set; }

        [Required]
        [StringLength(20)]
        public string phone { get; set; }

        [Required]
        [StringLength(255)]
        public string address { get; set; }

        [Required]
        [StringLength(100)]
        public string city { get; set; }

        [Required]
        [StringLength(100)]
        public string state { get; set; }

        [Required]
        [StringLength(100)]
        public string country { get; set; }

        [Required]
        [StringLength(20)]
        public string pincode { get; set; }

        public DateTime? created_at { get; set; }

        public virtual user user { get; set; }

        public virtual user user1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<query> queries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<submission> submissions { get; set; }
    }
}
