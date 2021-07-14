using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace suyi_tool
{
    public partial class Form1 : Form
    {
        string file_name = "";
        string file_path = "";
        string file_path_name = "";

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_select_type.SelectedIndex = 0;
            //Console.WriteLine("---------");
        }

        //
        bool file_dialog_get_name_path(ref string io_file_name, ref string io_file_path, ref string io_file_path_name, string _i_file_format)
        {
            bool r_b = true;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = _i_file_format;// "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 檔名
                    io_file_name = openFileDialog.SafeFileName;
                    // 路徑
                    io_file_path = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
                    // 路徑+檔名
                    io_file_path_name = openFileDialog.FileName;
                    r_b = true;
                }
                else
                {
                    io_file_name = "";
                    // 路徑
                    io_file_path = "";
                    // 路徑+檔名
                    io_file_path_name = "";
                    r_b = false;
                }
            }
            return r_b;
        }


        private void button_read_excel_Click(object sender, EventArgs e)
        {
            string result_path_name = "";
            label_run_result.BeginInvoke(new Action(() =>
            {
                label_run_result.ForeColor = Color.Black;
                label_run_result.Text = "執行狀態:";
            }));
            // ----------------------------------------------------------------------------------
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory(); 
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 路徑+檔名
                    file_path_name = openFileDialog.FileName;
                    // 路徑
                    file_path = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
                    // 檔名
                    file_name = openFileDialog.SafeFileName;
                    //-----------------------------------------------------------------------------------------------------------------------------
                    // 更新 檔案路徑跟名稱
                    textBox_file_path_name.BeginInvoke(new Action(() =>
                    {
                        textBox_file_path_name.Text = file_path_name;
                    }));
                    //-----------------------------------------------------------------------------------------------------------------------------
                    // 處理輸出檔名 _diff_result 或 _same_result
                    string[] subs = file_name.Split('.');
                    if (comboBox_select_type.SelectedIndex == 0){
                         result_path_name = file_path + subs[0] + "_diff_result.csv";
                    }else{
                        result_path_name = file_path + subs[0] + "_same_result.csv";
                    }
                    // -------------------------------------------------------------------------------------------------------------------
                    // 讀出txt檔案rows的內容
                    string[] all_rows_text = File.ReadAllLines(file_path_name);
                    // -------------------------------------------------------------------------------------------------------------------
                    // 執行rows比對 :找相同或不相同， 並輸出
                    string[] write_compare_date = rows_compare(all_rows_text, comboBox_select_type.SelectedIndex);
                    // -------------------------------------------------------------------------------------------------------------------
                    // 將比對結果寫入檔案
                    using (StreamWriter file = new StreamWriter(result_path_name))
                    {
                        for (int i = 0; i < write_compare_date.Length; i++)
                        {
                            file.Write(write_compare_date[i] + ",\r\n");
                        }
                    }
                    // -------------------------------------------------------------------------------------------------------------------
                    label_run_result.BeginInvoke(new Action(() =>
                    {
                        label_run_result.ForeColor = Color.Red;
                        label_run_result.Text = "執行狀態: "+ result_path_name+" 執行完成。";
                    }));

                }
            }

            // 背景執行
            backgroundWorker1.RunWorkerAsync();
        }


        // 兩個row陣列 比對找出相同或是不相同
        public string[] rows_compare(string[] i_rows_content, int i_select_idx)
        {
            int i = 0;
            string[] return_rows_compare_result;
            string[] path_1_readText = new string[i_rows_content.Length];
            string[] path_2_readText = new string[i_rows_content.Length];

            for (i = 0; i < i_rows_content.Length; i++)
            {
                // excel轉乘txt檔案   rowA跟rowB中間有 '\t' 做分隔
                string[] subs = i_rows_content[i].Split('\t');
                if (subs[0] != null){// rowA
                    path_1_readText[i] = subs[0];
                }
                if (subs[1] != null){// rowB
                    path_2_readText[i] = subs[1];
                }
            }

            if (i_select_idx == 0){
                //兩row陣列找出不同的元素(即交集的補集)
                return_rows_compare_result = path_1_readText.Where(c => !path_2_readText.Contains(c)).ToArray();
            }else{
                //兩row陣列找出相同元素(即交集)
                return_rows_compare_result = path_1_readText.Intersect(path_2_readText).ToArray();
            }
            //回傳結果
            return return_rows_compare_result;
        }


        private void button_get_file_Click(object sender, EventArgs e)
        {
            string _current_path = "";
            if ( string.Compare(file_path,"")==0)
            { 
                MessageBox.Show("請選擇執行檔案！");
            }
            else
            {
                _current_path = file_path;
                System.Diagnostics.Process prc = new System.Diagnostics.Process();
                prc.StartInfo.FileName = _current_path;
                prc.Start();
            }
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine("----backgroundWorker1_DoWork-----");
        }


        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("----backgroundWorker1_RunWorkerCompleted-----");
        }

//-------------------------------------------------------------------------------------------------------------------------
//------------------------------------------rowX寫入-------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------------------------------    
        private void textBox_write_rows_data_Click(object sender, EventArgs e)
        {
            bool g_b = file_dialog_get_name_path(ref file_name,ref  file_path,ref file_path_name, "csv files (*.csv)|*.csv|All files (*.*)|*.*");
            if (g_b == true)
            {
                textBox_write_rows_data.BeginInvoke(new Action(() =>
                {
                    textBox_write_rows_data.Text = file_path_name;
                }));
            }
        }

        private void button_write_rows_data_Click(object sender, EventArgs e)
        {
            Thread _go_run = new Thread(new ParameterizedThreadStart(add_csv_rows));
            _go_run.Start(textBox_write_rows_data.Text);
        }

        private void button_rows_open_path_Click(object sender, EventArgs e)
        {
            if (string.Compare(file_path, "") == 0)
            {
                MessageBox.Show("請選擇執行檔案！");
            }
            else
            {
                System.Diagnostics.Process prc = new System.Diagnostics.Process();
                prc.StartInfo.FileName = file_path;
                prc.Start();
            }
        }

        void add_csv_rows(object i_name_path)
        {
            double i = 0; int j = 0;
            int row_idx_6 = 6, row_idx_9=9;
            string wr_rows_c = "5555";
            string wr_rows_d = "D09";
            string _w_tmp = "";
            // 讀出中文
            string[] all_rows_text = new csv_file_chinese_WR().read_csv_file_big5((string)i_name_path);

            //------------處理row值更新--------------------------------------------------------------------------------------------------- 
            for (i = 1; i < all_rows_text.Length; i++)
            {
                // 內容
                string[] e_data = all_rows_text[(int)i].Split(',');// 用,切割row內容
                e_data[row_idx_6] = wr_rows_c; // 設定寫入row6的值
                e_data[row_idx_9] = wr_rows_d;// 設定寫入row9的值
                _w_tmp = "";
                for (j = 1; j < e_data.Length; j++)
                {
                    _w_tmp += e_data[j];
                    if (j != (e_data.Length - 1))
                    {
                        _w_tmp += ",";
                    }                        
                }
                //處理完成之後放回原資料位置
                all_rows_text[(int)i] = _w_tmp;
            }

            // ------------處理新檔名------------------------------------------------------------------------------------------------
            string[] all_name = ((string)i_name_path).Split('.');
            string w_name_path = all_name[0] + "_new_." + all_name[1];

            //----------寫入資料到csv檔----------------------------------------------------------------------------------------------------------------
            new csv_file_chinese_WR().write_csv_file_big5(w_name_path, all_rows_text);


            label_addrows_ok.BeginInvoke(new Action(() =>
            {
                label_addrows_ok.Text = "add rows data OK";
            }));          
        }

        //-------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------




    }
}
