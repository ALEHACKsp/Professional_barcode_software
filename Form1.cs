using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QRCoder;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.Office.Interop.Excel;
using BarcodeLib;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Reflection;
using ExcelToPdf;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;

namespace QR
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        ExcelInteropExcelToPdfConverter etp = new ExcelInteropExcelToPdfConverter();
        DataSet ds = new DataSet();

        void SQLDBTOPDF()
        {
            try
            {
                int yPoint = 0;
                string ID = null;
                string Producer = null;
                string Total = null;
                string Note = null;
                string Encode = null;
                string Date_Time = null;

                SqlConnection cs = new SqlConnection("Data Source=" + ServerName.Text + "; Initial Catalog=" + SQLDBName.Text + "; Integrated Security=TRUE");
                cs.Open();
                if (cs.State.ToString() == "Open")
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = new SqlCommand("SELECT * FROM tablcontacts", cs);
                    da.Fill(ds);

                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = "Database to PDF";
                    PdfPage pdfPage = pdf.AddPage();
                    XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                    XFont font = new XFont("Verdana", 12, XFontStyle.Regular);

                    yPoint = yPoint + 100;

                    for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                    {
                        ID = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                        Producer = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                        Total = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                        Note = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                        Encode = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                        Date_Time = ds.Tables[0].Rows[i].ItemArray[5].ToString();

                        graph.DrawString(ID, font, XBrushes.Black, new XRect(0, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                        graph.DrawString(Producer, font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                        graph.DrawString(Total, font, XBrushes.Black, new XRect(80, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                        graph.DrawString(Note, font, XBrushes.Black, new XRect(120, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                        graph.DrawString(Encode, font, XBrushes.Black, new XRect(240, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                        graph.DrawString(Date_Time, font, XBrushes.Black, new XRect(440, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                        yPoint = yPoint + 40;
                    }


                    string pdfFilename = "SQLDB.pdf";
                    pdf.Save(pdfFilename);
                    da.SelectCommand.ExecuteNonQuery();
                    cs.Close();
                    Process.Start(pdfFilename);
                }
                else
                    MessageBox.Show("SQL Server closed");
                
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    
        void ConvertExcel2PDF(string path)
        {
                etp.ConvertToPdf(Directory.EnumerateFiles(Directory.GetCurrentDirectory(), path));
        }
        void PrintFile(string path)
        {
            try
            {
                String dtPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\" + path;
                var excelApp = new Microsoft.Office.Interop.Excel.Application();
                var workbook = excelApp.Workbooks.Open(dtPath);
                Worksheet worksheet = (Worksheet)workbook.Worksheets[1];
                worksheet.PrintOut();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                Marshal.FinalReleaseComObject(worksheet);
                workbook.Close(false);
                Marshal.FinalReleaseComObject(workbook);
                excelApp.Quit();
                Marshal.FinalReleaseComObject(excelApp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public string ReadExcel(string path ,int Sheet , int Row ,int Column)
        {
            String dtPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\" + path;
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            var workbook = excelApp.Workbooks.Open(dtPath);
            Worksheet worksheet = workbook.ActiveSheet as Worksheet;
            return worksheet.Cells[Row, Column].txt;
        }
        public void WriteExcel(string path)
        {
            try
            {
                DateTime date3 = DateTime.Now;

                String dtPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\" + path;
                var excelApp = new Microsoft.Office.Interop.Excel.Application();
                var workbook = excelApp.Workbooks.Open(dtPath);
                Worksheet worksheet = workbook.ActiveSheet as Worksheet;
                Range lastRow = worksheet.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell, Type.Missing); int lastUsedRow = lastRow.Row;
                int newRow = lastUsedRow + 1;
                if (metroComboBoxType.SelectedItem.ToString() == "Type 1")
                {
                    Range range1 = worksheet.Cells[newRow, 1] as Range;
                    range1.Value2 = textBoxQRCode0.Text;
                    Range range2 = worksheet.Cells[newRow, 2] as Range;
                    range2.Value2 = textBoxQRCode.Text;
                    Range range3 = worksheet.Cells[newRow, 3] as Range;
                    range3.Value2 = textBoxQRCode2.Text;
                    Range range5 = worksheet.Cells[newRow, 5] as Range;
                    range5.Value2 = date3.ToString();

                }
                else if (metroComboBoxType.SelectedItem.ToString() == "Type 2")
                {
                    Range range1 = worksheet.Cells[newRow, 1] as Range;
                    range1.Value2 = textBoxQRCode0.Text;
                    Range range2 = worksheet.Cells[newRow, 2] as Range;
                    range2.Value2 = textBoxQRCode.Text;
                    Range range3 = worksheet.Cells[newRow, 3] as Range;
                    range3.Value2 = textBoxQRCode2.Text;
                    Range range4 = worksheet.Cells[newRow, 4] as Range;
                    range4.Value2 = QREncoding.Text;
                    Range range5 = worksheet.Cells[newRow, 5] as Range;
                    range5.Value2 = date3.ToString();

                }
                else
                    MessageBox.Show("Erorr Save");
                excelApp.Visible = false;
                workbook.Save();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                Marshal.FinalReleaseComObject(worksheet);
                workbook.Close();
                Marshal.FinalReleaseComObject(workbook);
                excelApp.Quit();
                Marshal.FinalReleaseComObject(excelApp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        public void WriteSqlServer()
        {
            try
            {
                DateTime date3 = DateTime.Now;

                SqlConnection cs = new SqlConnection("Data Source=" + ServerName.Text + "; Initial Catalog=" + SQLDBName.Text + "; Integrated Security=TRUE");
                cs.Open();
                if (cs.State.ToString() == "Open")
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.InsertCommand = new SqlCommand("INSERT INTO tablcontacts VALUES(@Producer, @Total, @Note, @Encode , @Date_Time)", cs);
                    da.InsertCommand.Parameters.Add("@Producer", SqlDbType.VarChar).Value = textBoxQRCode0.Text;
                    da.InsertCommand.Parameters.Add("@Total", SqlDbType.VarChar).Value = textBoxQRCode.Text;
                    da.InsertCommand.Parameters.Add("@Note", SqlDbType.VarChar).Value = textBoxQRCode2.Text;
                    da.InsertCommand.Parameters.Add("@Encode", SqlDbType.VarChar).Value = QREncoding.Text;
                    da.InsertCommand.Parameters.Add("@Date_Time", SqlDbType.VarChar).Value = date3.ToString();
                    da.InsertCommand.ExecuteNonQuery();
                    cs.Close();
                }
                else
                    MessageBox.Show("SQL Server closed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }
        public void ExportToBmp(string path)
        {

        }

        private Color GetPrimaryColor()
        {
            return panelPreviewPrimaryColor.BackColor;
        }

        private Color GetBackgroundColor()
        {
            return panelPreviewBackgroundColor.BackColor;
        }

        private void RenderQrLines()
        {
            Barcode b = new Barcode();

            TYPE type = TYPE.UNSPECIFIED;
            switch (ComboBoxEncodingType.SelectedItem.ToString().Trim())
            {
                case "UPC-A": type = TYPE.UPCA; break;
                case "UPC-E": type = TYPE.UPCE; break;
                case "UPC 2 Digit Ext.": type = TYPE.UPC_SUPPLEMENTAL_2DIGIT; break;
                case "UPC 5 Digit Ext.": type = TYPE.UPC_SUPPLEMENTAL_5DIGIT; break;
                case "EAN-13": type = TYPE.EAN13; break;
                case "JAN-13": type = TYPE.JAN13; break;
                case "EAN-8": type = TYPE.EAN8; break;
                case "ITF-14": type = TYPE.ITF14; break;
                case "Codabar": type = TYPE.Codabar; break;
                case "PostNet": type = TYPE.PostNet; break;
                case "Bookland/ISBN": type = TYPE.BOOKLAND; break;
                case "Code 11": type = TYPE.CODE11; break;
                case "Code 39": type = TYPE.CODE39; break;
                case "Code 39 Extended": type = TYPE.CODE39Extended; break;
                case "Code 39 Mod 43": type = TYPE.CODE39_Mod43; break;
                case "Code 93": type = TYPE.CODE93; break;
                case "LOGMARS": type = TYPE.LOGMARS; break;
                case "MSI": type = TYPE.MSI_Mod10; break;
                case "Interleaved 2 of 5": type = TYPE.Interleaved2of5; break;
                case "Interleaved 2 of 5 Mod 10": type = TYPE.Interleaved2of5_Mod10; break;
                case "Standard 2 of 5": type = TYPE.Standard2of5; break;
                case "Standard 2 of 5 Mod 10": type = TYPE.Standard2of5_Mod10; break;
                case "Code 128": type = TYPE.CODE128; break;
                case "Code 128-A": type = TYPE.CODE128A; break;
                case "Code 128-B": type = TYPE.CODE128B; break;
                case "Code 128-C": type = TYPE.CODE128C; break;
                case "Telepen": type = TYPE.TELEPEN; break;
                case "FIM": type = TYPE.FIM; break;
                case "Pharmacode": type = TYPE.PHARMACODE; break;
                default: MessageBox.Show("Please specify the encoding type."); break;
            }//switch
            try
            {
                b.LabelFont = new System.Drawing.Font("Arial", 24, FontStyle.Bold);
                b.IncludeLabel = this.chkGenerateLabel.Checked;
                pictureBoxQRCode.BackgroundImage = b.Encode(type, this.QREncoding.Text.Trim(), GetPrimaryColor(), GetBackgroundColor(), 600, 300);
                this.pictureBoxQRCode.Size = new System.Drawing.Size(pictureBoxQRCode.Width, pictureBoxQRCode.Height);
                //Set the SizeMode to center the image.
                this.pictureBoxQRCode.SizeMode = PictureBoxSizeMode.CenterImage;

                this.pictureBoxQRCode.SizeMode = PictureBoxSizeMode.StretchImage;

                txtEncoded.Text = b.EncodedValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RenderQrCode()
        {
            string level = comboBoxECC.SelectedItem.ToString();
            QRCodeGenerator.ECCLevel eccLevel = (QRCodeGenerator.ECCLevel)(level == "L" ? 0 : level == "M" ? 1 : level == "Q" ? 2 : 3);
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(textBoxQRCode0.Text + textBoxQRCode.Text  + textBoxQRCode2.Text, eccLevel))
                {
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {
                        pictureBoxQRCode.BackgroundImage = qrCode.GetGraphic(20, GetPrimaryColor(), GetBackgroundColor(),
                            GetIconBitmap(), (int)iconSize.Value);

                        this.pictureBoxQRCode.Size = new System.Drawing.Size(pictureBoxQRCode.Width, pictureBoxQRCode.Height);
                        //Set the SizeMode to center the image.
                        this.pictureBoxQRCode.SizeMode = PictureBoxSizeMode.CenterImage;

                        this.pictureBoxQRCode.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
        }
        private Bitmap GetIconBitmap()
        {
            Bitmap img = null;
            if (iconPath.Text.Length > 0)
            {
                try
                {
                    img = new Bitmap(iconPath.Text);
                }
                catch (Exception)
                {
                }
            }
            return img;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
            metroComboBox1.SelectedIndex = 0;
            metroComboBoxType.SelectedIndex = 0;
            comboBoxECC.SelectedIndex = 0;
            ComboBoxEncodingType.SelectedIndex = 0;
            dbtype.SelectedIndex = 0;

        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtEncoded.Clear();
            if (metroComboBoxType.SelectedItem.ToString() == "Type 1")
            {
                RenderQrCode();
            }
            else if (metroComboBoxType.SelectedItem.ToString() == "Type 2")
            {
                RenderQrLines();
            }
            else
                MessageBox.Show("Erorr Generate");


            if (dbtype.SelectedItem.ToString() == "None")
            {
                //nothing

            }
            else if (dbtype.SelectedItem.ToString() == "MS Excel")
            {
                WriteExcel(exfilename.Text);

            }
            else if (dbtype.SelectedItem.ToString() == "SQL Server")
            {

                WriteSqlServer();

            }
            else if (dbtype.SelectedItem.ToString() == "Both")
            {
                WriteExcel(exfilename.Text);
                WriteSqlServer();
            }
            else
                MessageBox.Show("Erorr");
        }

        private void selectIconBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Title = "Select icon";
            openFileDlg.Multiselect = false;
            openFileDlg.CheckFileExists = true;
            if (openFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                iconPath.Text = openFileDlg.FileName;
                if (iconSize.Value == 0)
                {
                    iconSize.Value = 15;
                }
            }
            else
            {
                iconPath.Text = "";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Bitmap Image|*.bmp|PNG Image|*.png|JPeg Image|*.jpg|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                using (FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile())
                {
                    // Saves the Image in the appropriate ImageFormat based upon the
                    // File type selected in the dialog box.
                    // NOTE that the FilterIndex property is one-based.

                    ImageFormat imageFormat = null;
                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
                            imageFormat = ImageFormat.Bmp;
                            break;
                        case 2:
                            imageFormat = ImageFormat.Png;
                            break;
                        case 3:
                            imageFormat = ImageFormat.Jpeg;
                            break;
                        case 4:
                            imageFormat = ImageFormat.Gif;
                            break;
                        default:
                            throw new NotSupportedException("File extension is not supported");
                    }

                    pictureBoxQRCode.BackgroundImage.Save(fs, imageFormat);
                    fs.Close();
                }
            }
        }

        private void panelPreviewPrimaryColor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelPreviewBackgroundColor_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelPreviewPrimaryColor_Click(object sender, EventArgs e)
        {
            if (colorDialogPrimaryColor.ShowDialog() == DialogResult.OK)
            {
                panelPreviewPrimaryColor.BackColor = colorDialogPrimaryColor.Color;
                if (metroComboBoxType.SelectedItem.ToString() == "Type 1")
                    RenderQrCode();
                else if (metroComboBoxType.SelectedItem.ToString() == "Type 2")
                    RenderQrLines();
                else
                    MessageBox.Show("Erorr Generate");
            }
        }

        private void panelPreviewBackgroundColor_Click(object sender, EventArgs e)
        {
            if (colorDialogBackgroundColor.ShowDialog() == DialogResult.OK)
            {
                panelPreviewBackgroundColor.BackColor = colorDialogBackgroundColor.Color;

                if (metroComboBoxType.SelectedItem.ToString() == "Type 1")
                    RenderQrCode();
                else if (metroComboBoxType.SelectedItem.ToString() == "Type 2")
                    RenderQrLines();
                else
                    MessageBox.Show("Erorr Generate");
            }
        }
        

    

        private void comboBoxECC_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (metroComboBoxType.SelectedItem.ToString() == "Type 1")
                RenderQrCode();
            else if (metroComboBoxType.SelectedItem.ToString() == "Type 2")
                RenderQrLines();
            else
                MessageBox.Show("Erorr Generate");

        }

        private void Form1_Close(object sender, FormClosedEventArgs e)
        {

        }

        private void metroComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBoxType.SelectedItem.ToString() == "Type 1")
            {
                textBoxQRCode0.Enabled = true;
                textBoxQRCode.Enabled = true;
                textBoxQRCode2.Enabled = true;
                comboBoxECC.Enabled = true;
                iconSize.Enabled = true;
                iconPath.Enabled = true;
                selectIconBtn.Enabled = true;
                chkGenerateLabel.Enabled = false;
                txtEncoded.Enabled = false;
                QREncoding.Enabled = false;
                ComboBoxEncodingType.Enabled = false;
                comboBoxECC.SelectedIndex = 0;
                txtEncoded.Clear();
                RenderQrCode();
            }
            else if (metroComboBoxType.SelectedItem.ToString() == "Type 2")
            {
                textBoxQRCode0.Enabled = true;
                textBoxQRCode.Enabled = true;
                textBoxQRCode2.Enabled = true;
                ComboBoxEncodingType.Enabled = true;
                chkGenerateLabel.Enabled = true;
                txtEncoded.Enabled = true;
                QREncoding.Enabled = true;
                iconSize.Enabled = false;
                iconPath.Enabled = false;
                comboBoxECC.Enabled = false;
                selectIconBtn.Enabled = false;
                QREncoding.Text = "038000356216";
                ComboBoxEncodingType.SelectedIndex = 0;
                txtEncoded.Clear();
                RenderQrLines();
            }
            else
                MessageBox.Show("No Items");


        }

        private void ComboBoxEncodingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBoxType.SelectedItem.ToString() == "Type 1")
                RenderQrCode();
            else if (metroComboBoxType.SelectedItem.ToString() == "Type 2")
                RenderQrLines();
            else
                MessageBox.Show("Erorr Generate");
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedItem.ToString() == "EN")
            {
                textBoxQRCode0.Text = "ex:Producer Name";
                textBoxQRCode.Text = "ex:Total";
                textBoxQRCode2.Text = "ex:Note";
                QREncoding.Text = "Encode";
                buttonGenerate.Text = "Generate And  Save";
                buttonSave.Text = "Save QR code";
                metroLabel1.Text = "ECC-Level:";
                metroLabel7.Text = "Encoding Type:";
                metroLabel6.Text = "File Name:";
                chkGenerateLabel.Text = "Generate label";
                metroLabel3.Text = "Primary color:";
                metroLabel2.Text = "Background color:";
                metroLabel9.Text = "Encoded Value";
                metroLabel5.Text = "Icon size: ";
                metroLabel4.Text = "Icon";
                metroLabel11.Text = "Server Name:";
                metroLabel12.Text = "SQL DB Name:";
                metroLabel10.Text = "DB-Type:";
                metroButton1.Text = "Print Excel Sheet";
                metroButton2.Text = "Convert DB To PDF";
                selectIconBtn.Text = "Select";
            }
            else if (metroComboBox1.SelectedItem.ToString() == "AR")
            {
                textBoxQRCode0.Text = "مثال:اسم منتج";
                textBoxQRCode.Text = "مثال:عدد";
                textBoxQRCode2.Text = "مثال:ملاحظة";
                QREncoding.Text = "ترميز";
                buttonGenerate.Text = "توليد مع حفظ";
                buttonSave.Text = "حفظ باركود";
                metroLabel1.Text = "ECC-مستوى:";
                metroLabel7.Text = "صيغه تشفير:";
                metroLabel6.Text = "اسم ملف:";
                chkGenerateLabel.Text = "توليد نص";
                metroLabel3.Text = "للون الاساسي:";
                metroLabel2.Text = "للون خلفية:";
                metroLabel9.Text = "قيم تشفير";
                metroLabel5.Text = "حجم ايقونه: ";
                metroLabel4.Text = "ايقونه";
                metroLabel11.Text = "اسم الخادم:";
                metroLabel12.Text = "SQL -اسم قاعده بيانات:";
                metroLabel10.Text = "نوع قاعده بيانات:";
                metroButton1.Text = "طباعة ورقة اكسيل";
                metroButton2.Text = "قاعدة بيانات الى بي دي اف";
                selectIconBtn.Text = "اختيار";
            }
            else
                MessageBox.Show("Erorr");
        }

        private void ComboBoxQRCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkGenerateLabel_CheckedChanged(object sender, EventArgs e)
        {
            RenderQrLines();
        }

        private void dbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dbtype.SelectedItem.ToString() == "None")
            {
                exfilename.Enabled = false;
                ServerName.Enabled = false;
                SQLDBName.Enabled = false;
                metroButton1.Enabled = false;

            }
            else if (dbtype.SelectedItem.ToString() == "MS Excel")
            {
                exfilename.Enabled = true;
                ServerName.Enabled = false;
                SQLDBName.Enabled = false;
                metroButton1.Enabled = true;
            }
            else if (dbtype.SelectedItem.ToString() == "SQL Server")
            {
                exfilename.Enabled = false;
                ServerName.Enabled = true;
                SQLDBName.Enabled = true;
                metroButton1.Enabled = false;
            }
            else if (dbtype.SelectedItem.ToString() == "Both")
            {
                exfilename.Enabled = true;
                ServerName.Enabled = true;
                SQLDBName.Enabled = true;
                metroButton1.Enabled = true;
            }
            else
                MessageBox.Show("Erorr");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            PrintFile(exfilename.Text);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (dbtype.SelectedItem.ToString() == "MS Excel")
            {
                ConvertExcel2PDF(exfilename.Text);

            }
            else if (dbtype.SelectedItem.ToString() == "SQL Server")
            {
                SQLDBTOPDF();
            }
            else
            {
                MessageBox.Show("Select DB Type");
            }
        }
    }
}
