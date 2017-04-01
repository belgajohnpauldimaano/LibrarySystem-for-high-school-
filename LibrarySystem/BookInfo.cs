using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class BookInfo
    {

        public BookInfo(int id, string title, string author, string publisher)
        {
            this.B_id = id;
            this.B_title = title;
            this.B_author = author;
            this.B_publisher = publisher;
        }

        public BookInfo(int id, string title, string addinfo, string author, string publisher, int qty, string cr, string cn, string ac, string isbn, int bc_id)
        {
            this.B_id = id;
            this.B_title = title;
            this.B_author = author;
            this.B_publisher = publisher;
            this.B_addinfo = addinfo;
            this.B_qty = qty;
            this.B_cr = cr;
            this.B_callno = cn;
            this.B_acc_no = ac;
            this.B_isbn = isbn;
            this.Bc_id = bc_id;
        }

        private int b_id;
        private string b_title;
        private string b_addinfo;

        public string B_addinfo
        {
            get { return b_addinfo; }
            set { b_addinfo = value; }
        }
        private string b_author;
        private string b_publisher;
        private int b_qty;

        public int B_qty
        {
            get { return b_qty; }
            set { b_qty = value; }
        }
        private string b_cr;

        public string B_cr
        {
            get { return b_cr; }
            set { b_cr = value; }
        }
        private string b_callno;

        public string B_callno
        {
            get { return b_callno; }
            set { b_callno = value; }
        }
        private string b_acc_no;

        public string B_acc_no
        {
            get { return b_acc_no; }
            set { b_acc_no = value; }
        }
        private string b_isbn;

        public string B_isbn
        {
            get { return b_isbn; }
            set { b_isbn = value; }
        }
        private int bc_id;

        public int Bc_id
        {
            get { return bc_id; }
            set { bc_id = value; }
        }


        public int B_id
        {
            get { return b_id; }
            set { b_id = value; }
        }

        public string B_title
        {
            get { return b_title; }
            set { b_title = value; }
        }

        public string B_author
        {
            get { return b_author; }
            set { b_author = value; }
        }

        public string B_publisher
        {
            get { return b_publisher; }
            set { b_publisher = value; }
        }

    }
}
