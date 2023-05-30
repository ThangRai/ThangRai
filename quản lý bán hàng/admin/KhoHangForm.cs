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
    public partial class KhoHangForm : Form
    {
        MATHANG mh = new MATHANG();
        public KhoHangForm()
        {
            InitializeComponent();
        }

        private void KhoHangForm_Load(object sender, EventArgs e)
        {
            StyleDatagridview();
        }
        void StyleDatagridview()
        {
            SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',loaihang as 'Loại hàng',tenhang as 'Tên mặt hàng',hinh as 'Hình',gia as'Giá',soluong as 'Số lượng' FROM HANGHOA");
            dataGridViewKhoHang.DataSource = mh.layHangHoa(command);
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridViewKhoHang.Columns[3];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewKhoHang.ReadOnly = true;
            dataGridViewKhoHang.RowTemplate.Height = 60;
            dataGridViewKhoHang.BorderStyle = BorderStyle.None;
            dataGridViewKhoHang.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewKhoHang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewKhoHang.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridViewKhoHang.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewKhoHang.BackgroundColor = Color.FromArgb(148, 184, 184);
            dataGridViewKhoHang.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewKhoHang.EnableHeadersVisualStyles = false;
            dataGridViewKhoHang.AllowUserToAddRows = false;
            dataGridViewKhoHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewKhoHang.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12);

            //dòng tiêu đề của bảng
            dataGridViewKhoHang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 95, 95);
            dataGridViewKhoHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
           

        }

        private void buttonXuatDS_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_Data_To_Word(dataGridViewKhoHang, savefile.FileName);
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
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "TRUNG TÂM THƯƠNG MẠI DỊCH VỤ ABC\n" + "DANH SÁCH HÀNG HÓA";
                    headerRange.Font.Size = 20;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }
                //save image
                for (r = 0; r <= RowCount - 1; r++)
                {
                    byte[] imgbyte = (byte[])dataGridViewKhoHang.Rows[r].Cells[3].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    Image finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(70, 70)));
                    Clipboard.SetDataObject(finalPic);
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 4).Range.Paste();
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 4).Range.InsertParagraph();
                }
                //save file
                oDoc.SaveAs(filename);
            }
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if(radioButtonMaMH.Checked)
            {
                if ((textBoxTimKiem.Text.Trim() == ""))
                {
                    SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',loaihang as 'Loại hàng',tenhang as 'Tên mặt hàng',hinh as 'Hình',gia as'Giá',soluong as 'Số lượng' FROM HANGHOA");
                    dataGridViewKhoHang.DataSource = mh.layHangHoa(command);
                }
                else
                {

                    try
                    {
                        int mamh = int.Parse(textBoxTimKiem.Text);
                        SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',loaihang as 'Loại hàng',tenhang as 'Tên mặt hàng',hinh as 'Hình',gia as'Giá',soluong as 'Số lượng' FROM HANGHOA WHERE mahang=" + mamh);
                        dataGridViewKhoHang.DataSource = mh.layHangHoa(command);
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng nhập đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }   
            else
            {
                if ((textBoxTimKiem.Text.Trim() == ""))
                {
                    SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',loaihang as 'Loại hàng',tenhang as 'Tên mặt hàng',hinh as 'Hình',gia as'Giá',soluong as 'Số lượng' FROM HANGHOA");
                    dataGridViewKhoHang.DataSource = mh.layHangHoa(command);
                }
                else
                {
                    try
                    {
                        string mamh = textBoxTimKiem.Text.ToString();
                        SqlCommand command = new SqlCommand("SELECT mahang as 'Mã mặt hàng',loaihang as 'Loại hàng',tenhang as 'Tên mặt hàng',hinh as 'Hình',gia as'Giá',soluong as 'Số lượng' FROM HANGHOA WHERE tenhang LIKE '%" + mamh+"%'");
                        dataGridViewKhoHang.DataSource = mh.layHangHoa(command);
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng nhập đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void textBoxTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonTenMH_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMaMH_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewKhoHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
