//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database_Assessment
{
    using System;
    using System.Collections.Generic;
    
    public partial class SweetDishesList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SweetDishesList()
        {
            this.PrasadamDistributions = new HashSet<PrasadamDistribution>();
        }
    
        public int ItemID { get; set; }
        public string DishName { get; set; }
        public decimal CostPerPlate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrasadamDistribution> PrasadamDistributions { get; set; }
    }
}