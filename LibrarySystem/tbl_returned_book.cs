//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibrarySystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_returned_book
    {
        public int rb_id { get; set; }
        public int b_id { get; set; }
        public string stud_id_number { get; set; }
        public System.DateTime rb_returned_date { get; set; }
        public int rb_over_due_days { get; set; }
        public string ref_num { get; set; }
    }
}
