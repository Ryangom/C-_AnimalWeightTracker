//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _00185511_AnimalWeightTracker
{
    using System;
    using System.Collections.Generic;
    
    public partial class meal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public meal()
        {
            this.daily_meal = new HashSet<daily_meal>();
        }
    
        public int Id { get; set; }
        public string name { get; set; }
        public string unit_in_gram { get; set; }
        public Nullable<double> caloriers { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<daily_meal> daily_meal { get; set; }
    }
}
