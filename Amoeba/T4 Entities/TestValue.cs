//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace T4Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class TestValue : BaseEntity
    {
        public int EntityPropertyId { get; set; }
        public int RowId { get; set; }
        public string Value { get; set; }
    
        public virtual EntityProperty EntityProperty { get; set; }
    }
}