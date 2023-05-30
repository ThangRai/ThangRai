using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using Size = System.Drawing.Size;
using System.IO;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace quản_lý_bán_hàng
{
    public partial class ChamCongForm : Form
    {
        NHANVIEN nv = new NHANVIEN();
        CHAMCONG chamcong = new CHAMCONG();
        public ChamCongForm()
        {
            InitializeComponent();
        }

        private void ChamCongForm_Load(object sender, EventArgs e)
        {
            StyleDatagridview();
        }
        void StyleDatagridview()
        {
            SqlCommand command = new SqlCommand("SELECT msnv as 'Mã nhân viên',hoten as 'Họ và tên',giovao as 'Giờ vào',giora as 'Giờ ra',sogio as 'Tiếng' FROM CHAMCONG");
            dataGridViewChamCong.DataSource = nv.layNV(command);
            dataGridViewChamCong.ReadOnly = true;
            dataGridViewChamCong.RowTemplate.Height = 60;
            dataGridViewChamCong.BorderStyle = BorderStyle.None;
            dataGridViewChamCong.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewChamCong.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewChamCong.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridViewChamCong.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewChamCong.BackgroundColor = Color.FromArgb(148, 184, 184);
            dataGridViewChamCong.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewChamCong.EnableHeadersVisualStyles = false;
            dataGridViewChamCong.AllowUserToAddRows = false;
            dataGridViewChamCong.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewChamCong.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12);

            //dòng tiêu đề của bảng
            dataGridViewChamCong.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 95, 95);
            dataGridViewChamCong.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //căn giữa 
            dataGridViewChamCong.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (radioButtonCo.Checked)
            {
                if (radioButtonMaNV.Checked)
                {
                    if ((textBoxTimKiem.Text.Trim() == ""))
                    {
                        SqlCommand command = new SqlCommand("SELECT msnv as 'Mã nhân viên',hoten as 'Họ và tên',giovao as 'Giờ vào',giora as 'Giờ ra',sogio as 'Tiếng' FROM CHAMCONG");
                        dataGridViewChamCong.DataSource = chamcong.laydanhsach(command);
                    }
                    else
                    {
                        try
                        {
                            int msnv = int.Parse(textBoxTimKiem.Text);
                            string giovao = dateTimePicker1.Value.ToString();
                            SqlCommand command = new SqlCommand("SELECT msnv as 'Mã nhân viên',hoten as 'Họ và tên',giovao as 'Giờ vào',giora as 'Giờ ra',sogio as 'Tiếng' FROM CHAMCONG WHERE msnv=" + msnv + "AND giovao=@gv");
                            command.Parameters.Add("@gv", SqlDbType.VarChar).Value = giovao;
                            dataGridViewChamCong.DataSource = chamcong.laydanhsach(command);
                        }
                        catch
                        {
                            MessageBox.Show("Vui lòng nhập đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (radioButtonTen.Checked)
                {
                    if ((textBoxTimKiem.Text.Trim() == ""))
                    {
                        SqlCommand command = new SqlCommand("SELECT msnv as 'Mã nhân viên',hoten as 'Họ và tên',giovao as 'Giờ vào',giora as 'Giờ ra',sogio as 'Tiếng' FROM CHAMCONG");
                        dataGridViewChamCong.DataSource = chamcong.laydanhsach(command);
                    }
                    else
                    {


                        string hoten = textBoxTimKiem.Text;
                        string giovao = dateTimePicker1.Value.ToString();
                        SqlCommand command = new SqlCommand("SELECT msnv as 'Mã nhân viên',hoten as 'Họ và tên',giovao as 'Giờ vào',giora as 'Giờ ra',sogio as 'Tiếng' FROM CHAMCONG WHERE hoten LIKE '%" + hoten + "%' AND giovao=@gv");
                        command.Parameters.Add("@gv", SqlDbType.VarChar).Value = giovao;
                        dataGridViewChamCong.DataSource = chamcong.laydanhsach(command);
                    }
                }
                else
                {
                    SqlCommand command = new SqlCommand("SELECT msnv as 'Mã nhân viên',hoten as 'Họ và tên',giovao as 'Giờ vào',giora as 'Giờ ra',sogio as 'Tiếng' FROM CHAMCONG");
                    dataGridViewChamCong.DataSource = chamcong.laydanhsach(command);
                }
            }
            else
            {
                if (radioButtonTen.Checked)
                {
                    if ((textBoxTimKiem.Text.Trim() == ""))
                    {
                        SqlCommand command = new SqlCommand("SELECT msnv as 'Mã nhân viên',hoten as 'Họ và tên',giovao as 'Giờ vào',giora as 'Giờ ra',sogio as 'Tiếng' FROM CHAMCONG");
                        dataGridViewChamCong.DataSource = chamcong.laydanhsach(command);
                    }
                    else
                    {

                        string hoten = textBoxTimKiem.Text.ToString();
                        SqlCommand command = new SqlCommand("SELECT msnv as 'Mã nhân viên',hoten as 'Họ và tên',giovao as 'Giờ vào',giora as 'Giờ ra',sogio as 'Tiếng' FROM CHAMCONG WHERE hoten LIKE '%" + hoten + "%'");
                        dataGridViewChamCong.DataSource = chamcong.laydanhsach(command);

                    }
                }
                else
                {
                    if ((textBoxTimKiem.Text.Trim() == ""))
                    {
                        SqlCommand command = new SqlCommand("SELECT msnv as 'Mã nhân viên',hoten as 'Họ và tên',giovao as 'Giờ vào',giora as 'Giờ ra',sogio as 'Tiếng' FROM CHAMCONG");
                        dataGridViewChamCong.DataSource = chamcong.laydanhsach(command);
                    }
                    else
                    {

                        try
                        {
                            int msnv = int.Parse(textBoxTimKiem.Text);
                            SqlCommand command = new SqlCommand("SELECT msnv as 'Mã nhân viên',hoten as 'Họ và tên',giovao as 'Giờ vào',giora as 'Giờ ra',sogio as 'Tiếng' FROM CHAMCONG WHERE msnv=" + msnv);
                            dataGridViewChamCong.DataSource = chamcong.laydanhsach(command);
                        }
                        catch
                        {
                            MessageBox.Show("Vui lòng nhập đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK) printDoc.Print();
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_Data_To_Word(dataGridViewChamCong, savefile.FileName);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;


                ///////   ĐÂY LÀ SAVE BÌNH THƯỜNG CHƯA CĂN CHỈNH

                /*Document oDoc = new Document();
                oDoc.Application.Visible = true;

                oDoc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;

                //dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                Object oMissing = System.Reflection.Missing.Value;
               for (int r = 0; r <= RowCount - 1; r++)
               {
                   oTemp = "";
                   for (int c = 0; c < ColumnCount - 1; c++)
                   {
                       oTemp = oTemp + DGV.Rows[r].Cells[c].Value + "\t";
                   }
                   var oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
                   oPara1.Range.Text = oTemp;
                   oPara1.Range.InsertParagraphAfter();
                   byte[] imgbyte = (byte[])dataGridViewPrint.Rows[r].Cells[7].Value;
                   MemoryStream ms = new MemoryStream(imgbyte);
                   //Image sparePicture = Image.FromStream(ms);
                   Image finalPic = (Image)new Bitmap(Image.FromStream(ms), new System.Drawing.Size(50, 50));
                   Clipboard.SetDataObject(finalPic);
                   var oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                   oPara2.Range.Paste();
                   oPara2.Range.InsertParagraphAfter();
                   //oTemp += "\n";
               }
               //save the file
               oDoc.SaveAs2(filename);*/
                //////////////////////////////////////////////////////////////////////////////////////


                //////        ĐÂY LÀ SAVE CÓ CHIA CỘT THẲNG HÀNG       

                Object[,] dataArray = new object[RowCount + 1, ColumnCount + 1];
                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        dataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    }
                }
                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;
                //page origiantion
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + dataArray[r, c] + "\t";
                    }
                }
                //table format
                oRange.Text = oTemp;
                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                       Type.Missing, Type.Missing, ref ApplyBorders,
                                       Type.Missing, Type.Missing, Type.Missing,
                                       Type.Missing, Type.Missing, Type.Missing,
                                       Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);
                oRange.Select();
                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 20;
                string ngay = "";
                ngay = "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + DateTime.Now + "";
                Object oMissing2 = System.Reflection.Missing.Value;
                var oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing2);
                oPara2.Range.Text = ngay;
                oPara2.Range.InsertParagraphAfter();
                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }
                //table sytle
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 3");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "TRUNG TÂM THƯƠNG MẠI DỊCH VỤ ABC\n"+"CHẤM CÔNG";
                    headerRange.Font.Size = 20;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }
                //save image

                //save file
                oDoc.SaveAs(filename);
            }
        }
    }
}
