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
    
    public partial class view_book_returned
    {
        public string b_title { get; set; }
        public string b_author { get; set; }
        public System.DateTime rb_returned_date { get; set; }
        public int rb_over_due_days { get; set; }
        public string stud_id_number { get; set; }
        public string stud_fn { get; set; }
        public string stud_ln { get; set; }
        public Nullable<int> yr_details { get; set; }
        public string sec_details { get; set; }
        public int sec_id { get; set; }
        public string ref_num { get; set; }
    }
}
