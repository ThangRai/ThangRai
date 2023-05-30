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
using System.Globalization;

namespace quản_lý_bán_hàng
{
    public partial class CTHDForm : Form
    {
        private int mskh;
       
        private int magiohang;
        MUAHANG muahang = new MUAHANG();
        string tenkh="";
        string tenNV = "";
        public CTHDForm()
        {
            InitializeComponent();
        }
        public CTHDForm(int mskh,int magiohang)
        {
            InitializeComponent();
            this.mskh = mskh;
            this.magiohang = magiohang;
        }
        string layten()
        {
            MY_DB mydb = new MY_DB();
            SqlCommand command2 = new SqlCommand("SELECT * FROM dbo.KHACHHANG WHERE mskh=" + mskh, mydb.getConnection);
            mydb.openConnection();
            SqlDataReader reader = command2.ExecuteReader();
            reader.Read();
            tenkh = reader["hoten"].ToString();
            reader.Close();
            //count = (Int32)command.ExecuteScalar();
            mydb.closeConnection();
            return tenkh;
            
        }
        string layten2()
        {
            MY_DB mydb = new MY_DB();
            SqlCommand command2 = new SqlCommand("SELECT * FROM dbo.NHANVIEN WHERE msnv=" + GLOBALS.GlobalUserId, mydb.getConnection);
            mydb.openConnection();
            SqlDataReader reader = command2.ExecuteReader();
            reader.Read();
            tenNV = reader["hoten"].ToString();
            reader.Close();
            //count = (Int32)command.ExecuteScalar();
            mydb.closeConnection();
            return tenNV;

        }
        private void CTHDForm_Load(object sender, EventArgs e)
        {
            tenkh = layten();
            SqlCommand command = new SqlCommand("SELECT tenhang as'Tên mặt hàng',soluong as 'Số lượng',gia as 'Giá' FROM GIOHANG WHERE thanhtoan=0 AND mskh =" + mskh+"AND magiohang="+magiohang);
            dataGridViewTT.DataSource = muahang.layHangHoa(command);
            labelMaKH.Text = "Mã khách hàng: " + mskh;
            labelTenKH.Text = "Khách hàng: " + tenkh;
            double value = Convert.ToDouble(muahang.tongtien(mskh));
            labelTongTien.Text = "Tổng tiền: " + string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", value) + " VND";
            dataGridViewTT.ReadOnly = true;
            StyleDatagridview();
        }
        void StyleDatagridview()
        {
            dataGridViewTT.ReadOnly = true;
            dataGridViewTT.RowTemplate.Height = 20;
            dataGridViewTT.BorderStyle = BorderStyle.None;
            dataGridViewTT.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewTT.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewTT.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridViewTT.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewTT.BackgroundColor = Color.FromArgb(148, 184, 184);
            dataGridViewTT.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewTT.EnableHeadersVisualStyles = false;
            dataGridViewTT.AllowUserToAddRows = false;
            dataGridViewTT.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewTT.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12);

            //dòng tiêu đề của bảng
            dataGridViewTT.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 95, 95);
            dataGridViewTT.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
           

        }
        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_Data_To_Word(dataGridViewTT, savefile.FileName);
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
                oDoc.Application.Selection.Tables[1].Rows.Height = 30;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Times New Roman";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 20;

                //tổng tiền
                oTemp = "\n\t\t\t**************************Tổng thành tiền: " + muahang.tongtien(GLOBALS.GlobalUserId) + " VND**************************";
                Object oMissing = System.Reflection.Missing.Value;
                var oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
                oPara1.Range.Text = oTemp;
                oPara1.Range.InsertParagraphAfter();
                //in nhân viên
                tenNV = layten2();
                string ten = "\t\t\t\t\t\t\t\t\t\t\t\t\t\t Nhân viên: " + tenNV + "";
                Object oMissing3 = System.Reflection.Missing.Value;
                var oPara3 = oDoc.Content.Paragraphs.Add(ref oMissing3);
                oPara3.Range.Text = ten;
                oPara3.Range.InsertParagraphAfter();

                //in ngay o cuối
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
                    headerRange.Font.Size = 20;
                    headerRange.Font.Name = "Times New Roman";
                    headerRange.Bold = 1;
                    headerRange.Text = "TRUNG TÂM THƯƠNG MẠI DỊCH VỤ ABC\n" + "HÓA ĐƠN THANH TOÁN\n" + "\nMã Khách hàng: " + mskh + " Khách hàng: " + tenkh + "\n";

                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    //hóa đơn
                }
                //tổng tiền
                //save file
                oDoc.SaveAs(filename);
            }
        }
    }
}
