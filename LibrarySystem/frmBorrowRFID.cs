using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class frmBorrowRFID : Form
    {
        BookInfo bookinfo;

        DateTime rd = new DateTime();
        public frmBorrowRFID(BookInfo _bookinfo)
        {
            InitializeComponent();
            this.bookinfo = _bookinfo;
            //this.Text = bookinfo.B_id.ToString();
            lblBtitle.Text = bookinfo.B_title;
            lblBAuthor.Text = bookinfo.B_author;
            lblBPublisher.Text = bookinfo.B_publisher;

            rd = DateTime.Now;
            rd = rd.AddDays(3);

            lblBDate.Text = DateTime.Now.ToShortDateString();
            lblRDate.Text = rd.ToShortDateString();

            SelectDevice();
            establishContext();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBorrowRFID_Load(object sender, EventArgs e)
        {
            tmrRead.Enabled = true;
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {

            using (library_dbEntities db = new library_dbEntities())
            {
                tbl_borrowed_book borrow = new tbl_borrowed_book 
                { 
                    b_id = bookinfo.B_id,
                    stud_id_number = lblIDNumber.Text,
                    bb_status = 0,
                    bb_borrowed_date = DateTime.Now.Date,
                    bb_due_date = rd.Date,
                    b_ref_num = tbRefNum.Text
                };
                db.tbl_borrowed_book.Add(borrow);
                db.SaveChanges();

                tbl_book_info book = db.tbl_book_info.FirstOrDefault(b => b.b_id == bookinfo.B_id);
                book.b_qty = book.b_qty - 1;
                db.SaveChanges();
                MessageBox.Show(this,"Book successfully borrowed.");
            }
            this.Close();
        }

        private void tmrRead_Tick(object sender, EventArgs e)
        {
            if (connectCard())
            {
                string cardUID = getcardUID();
                //this.Text = cardUID; //displaying on text block
                if (cardUID != "63000000")
                {
                    lblRFID.Text = cardUID;
                }
            }
            else if (!connectCard() && (retCode < 0 && retCode != -2146434967))
            {
                SelectDevice();
                establishContext();

                this.Text = "Reader not connected";
                tmrRead.Enabled = false;
                MessageBox.Show(this, "Please plug in device and reopen this form.", "Device not connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                this.Text = "Reader connected";
            }
        }

        /*
         * 
         * ACR 1222U 
         * 
         */

        int retCode;
        int hCard;
        int hContext;
        int Protocol;
        public bool connActive = false;
        string readername = "ACS ACR122 0";      // change depending on reader
        public byte[] SendBuff = new byte[263];
        public byte[] RecvBuff = new byte[263];
        public int SendLen, RecvLen, nBytesRet, reqType, Aprotocol, dwProtocol, cbPciLength;
        ACR122uCard.SCARD_READERSTATE RdrState;
        ACR122uCard.SCARD_IO_REQUEST pioSendRequest;
        private int id;
        private string cardno;

        public void SelectDevice()
        {
            //MessageBox.Show(this.ListReaders().Count.ToString());
            if (this.ListReaders().Count > 0)
            {
                List<string> availableReaders = this.ListReaders();
                this.RdrState = new ACR122uCard.SCARD_READERSTATE();
                readername = availableReaders[0].ToString();//selecting first device
                this.RdrState.RdrName = readername;
                if (retCode == 0)
                {
                    //MessageBox.Show("Device successfully connected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //MessageBox.Show(ACR122uCard.GetScardErrMsg(retCode).ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //MessageBox.Show(ACR122uCard.GetScardErrMsg(retCode).ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<string> ListReaders()
        {
            int ReaderCount = 0;
            List<string> AvailableReaderList = new List<string>();

            //Make sure a context has been established before 
            //retrieving the list of smartcard readers.
            retCode = ACR122uCard.SCardListReaders(hContext, null, null, ref ReaderCount);
            if (retCode != ACR122uCard.SCARD_S_SUCCESS)
            {
                //MessageBox.Show(ACR122uCard.GetScardErrMsg(retCode));
                //connActive = false;
            }

            byte[] ReadersList = new byte[ReaderCount];

            //Get the list of reader present again but this time add sReaderGroup, retData as 2rd & 3rd parameter respectively.
            retCode = ACR122uCard.SCardListReaders(hContext, null, ReadersList, ref ReaderCount);
            if (retCode != ACR122uCard.SCARD_S_SUCCESS)
            {
                //MessageBox.Show(ACR122uCard.GetScardErrMsg(retCode));
            }

            string rName = "";
            int indx = 0;
            if (ReaderCount > 0)
            {
                // Convert reader buffer to string
                while (ReadersList[indx] != 0)
                {

                    while (ReadersList[indx] != 0)
                    {
                        rName = rName + (char)ReadersList[indx];
                        indx = indx + 1;
                    }

                    //Add reader name to list
                    AvailableReaderList.Add(rName);
                    rName = "";
                    indx = indx + 1;

                }
            }
            return AvailableReaderList;

        }

        internal void establishContext()
        {
            retCode = ACR122uCard.SCardEstablishContext(ACR122uCard.SCARD_SCOPE_SYSTEM, 0, 0, ref hContext);
            if (retCode != ACR122uCard.SCARD_S_SUCCESS)
            {
                //MessageBox.Show("Check your device and please restart again", "Reader not connected");
                connActive = false;
                return;
            }
        }
        public bool connectCard()
        {

            connActive = true;

            retCode = ACR122uCard.SCardConnect(hContext, readername, ACR122uCard.SCARD_SHARE_SHARED,
                      ACR122uCard.SCARD_PROTOCOL_T0 | ACR122uCard.SCARD_PROTOCOL_T1, ref hCard, ref Protocol);


            if (retCode != ACR122uCard.SCARD_S_SUCCESS)
            {
                //MessageBox.Show(Card.GetScardErrMsg(retCode), "Card not available");
                //this.Text = ACR122uCard.GetScardErrMsg(retCode).ToString() + " " + "Card not available " + retCode.ToString();
                connActive = false;
                return false;


            }

            return true;

        }

        private string getcardUID()//only for mifare 1k cards
        {
            string cardUID = "";
            byte[] receivedUID = new byte[256];
            ACR122uCard.SCARD_IO_REQUEST request = new ACR122uCard.SCARD_IO_REQUEST();
            request.dwProtocol = ACR122uCard.SCARD_PROTOCOL_T1;
            request.cbPciLength = System.Runtime.InteropServices.Marshal.SizeOf(typeof(ACR122uCard.SCARD_IO_REQUEST));
            byte[] sendBytes = new byte[] { 0xFF, 0xCA, 0x00, 0x00, 0x00 }; //get UID command      for Mifare cards
            int outBytes = receivedUID.Length;
            int status = ACR122uCard.SCardTransmit(hCard, ref request, ref sendBytes[0], sendBytes.Length, ref request, ref receivedUID[0], ref outBytes);

            if (status != ACR122uCard.SCARD_S_SUCCESS)
            {
                //cardUID = "Error";
                cardUID = "";
            }
            else
            {
                cardUID = BitConverter.ToString(receivedUID.Take(4).ToArray()).Replace("-", string.Empty).ToLower();
            }

            return cardUID;
        }

        private void lblRFID_TextChanged(object sender, EventArgs e)
        {
            using( library_dbEntities db = new library_dbEntities())
            {
                view_students_information vstud = db.view_students_information.FirstOrDefault(s => s.rfid_tag_id == lblRFID.Text);
                lblIDNumber.Text = vstud.stud_id_number;
                lblName.Text = string.Format("{0}, {1}", vstud.stud_ln, vstud.stud_fn);
                lblYrSec.Text = string.Format("{0} {1}", vstud.yr_details, vstud.sec_details);

                //tbl_borrowed_book borrow = db.tbl_borrowed_book.FirstOrDefault(b => b.stud_id_number == lblIDNumber.Text && b.bb_status == 0);

                var borrow = from b in db.tbl_borrowed_book
                              where b.stud_id_number == lblIDNumber.Text && b.bb_status == 0
                              select b;

                if (borrow != null)
                {
                    if(borrow.Count() >= 5)
                    {
                        lblMsg.Text = "Student has borrowed book that not yet returned.";
                        btnBorrow.Enabled = false;
                    }
                    else
                    {
                        lblMsg.Text = "Available to borrow.";
                        btnBorrow.Enabled = true;
                        btnBorrow.Focus();
                    }
                }
            }
        }
    }
}
