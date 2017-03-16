//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasyBookShop.models
{
    using System;
    using System.Collections.Generic;
    
    public partial class retail_invoices
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public retail_invoices()
        {
            this.retail_invoice_items = new HashSet<retail_invoice_items>();
            this.retail_returns = new HashSet<retail_returns>();
        }
    
        public int id { get; set; }
        public Nullable<int> customer { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<decimal> total { get; set; }
        public string customer_level { get; set; }
        public Nullable<int> cashier { get; set; }
    
        public virtual customer customer1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<retail_invoice_items> retail_invoice_items { get; set; }
        public virtual user user { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<retail_returns> retail_returns { get; set; }
    }
}