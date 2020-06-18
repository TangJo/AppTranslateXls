using NPOI.HSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppTranslateXls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //tb_language.DataSource = mLanguageList;
        }

        private List<DataLanguage> mLanguageList = new List<DataLanguage>();

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openfiledialog.RestoreDirectory = true;
            openfiledialog.Filter = "xls files(*.xls)|*.xls";
            if (DialogResult.OK == openfiledialog.ShowDialog())
            {
                tb_language.Items.Clear();
                HSSFWorkbook wb = null;
                try
                {
                    wb = new HSSFWorkbook(new FileStream(openfiledialog.FileName, FileMode.Open));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    HSSFSheet sht = (HSSFSheet)wb.GetSheetAt(0);
                    int rowsCount = sht.PhysicalNumberOfRows;
                    int colCount = sht.GetRow(0).PhysicalNumberOfCells;
                    for (int i = 1; i < colCount; i++)
                    {
                        tb_language.Items.Add(sht.GetRow(0).GetCell(i).ToString());
                    }
                    for (int nRow = 1; nRow < rowsCount; nRow++) {
                        if (sht.GetRow(nRow) == null)
                            continue;
                        NPOI.SS.UserModel.ICell keyCell = sht.GetRow(nRow).GetCell(0);
                        if (null == keyCell)
                            continue;
                        DataLanguage language = new DataLanguage(keyCell.ToString());
                        for (int nCol = 1; nCol < colCount; nCol++)
                        {
                            NPOI.SS.UserModel.ICell valueCell = sht.GetRow(nRow).GetCell(nCol);
                            string strValue = "";
                            if (valueCell != null)
                                strValue = valueCell.ToString();
                            language.Content.Add(strValue);
                        }
                        mLanguageList.Add(language);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_translate_Click(object sender, EventArgs e)
        {
            int nIndex =  tb_language.SelectedIndex;
            if (nIndex < 0) {
                MessageBox.Show("选择一种语言");
                return;
            }
            foreach (DataLanguage lan in mLanguageList)
            {
                //转成iOS语言包
               // tb_content.Text += string.Format("\"{0}\"=\"{1}\";\r\n",lan.Key,lan.Content[nIndex]);
                //<string name="OK">OK</string>
                //转成Android语言包
                tb_content.Text += string.Format("<string name=\"{0}\">{1}</string>\r\n", lan.Key, lan.Content[nIndex]);
            }
        }

        private void tb_content_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (e.Control && e.KeyCode == Keys.A)
                t.SelectAll();
        }
    }
}
