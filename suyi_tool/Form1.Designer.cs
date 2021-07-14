
namespace suyi_tool
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_read_excel = new System.Windows.Forms.Button();
            this.textBox_file_path_name = new System.Windows.Forms.TextBox();
            this.button_current_file_path = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_select_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_run_result = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label_addrows_ok = new System.Windows.Forms.Label();
            this.button_rows_open_path = new System.Windows.Forms.Button();
            this.textBox_write_rows_data = new System.Windows.Forms.TextBox();
            this.button_write_rows_data = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_read_excel
            // 
            this.button_read_excel.Font = new System.Drawing.Font("新細明體", 12F);
            this.button_read_excel.Location = new System.Drawing.Point(13, 99);
            this.button_read_excel.Name = "button_read_excel";
            this.button_read_excel.Size = new System.Drawing.Size(159, 57);
            this.button_read_excel.TabIndex = 0;
            this.button_read_excel.Text = "選擇文字檔";
            this.button_read_excel.UseVisualStyleBackColor = true;
            this.button_read_excel.Click += new System.EventHandler(this.button_read_excel_Click);
            // 
            // textBox_file_path_name
            // 
            this.textBox_file_path_name.Font = new System.Drawing.Font("新細明體", 15F);
            this.textBox_file_path_name.Location = new System.Drawing.Point(108, 12);
            this.textBox_file_path_name.Name = "textBox_file_path_name";
            this.textBox_file_path_name.Size = new System.Drawing.Size(745, 31);
            this.textBox_file_path_name.TabIndex = 1;
            // 
            // button_current_file_path
            // 
            this.button_current_file_path.Font = new System.Drawing.Font("新細明體", 12F);
            this.button_current_file_path.Location = new System.Drawing.Point(251, 99);
            this.button_current_file_path.Name = "button_current_file_path";
            this.button_current_file_path.Size = new System.Drawing.Size(159, 57);
            this.button_current_file_path.TabIndex = 3;
            this.button_current_file_path.Text = "開啟輸出檔案路徑";
            this.button_current_file_path.UseVisualStyleBackColor = true;
            this.button_current_file_path.Click += new System.EventHandler(this.button_get_file_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15F);
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "檔案路徑:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("新細明體", 15F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 501);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBox_select_type);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label_run_result);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button_read_excel);
            this.tabPage1.Controls.Add(this.button_current_file_path);
            this.tabPage1.Controls.Add(this.textBox_file_path_name);
            this.tabPage1.Font = new System.Drawing.Font("新細明體", 9F);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "excel欄位比對";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 15F);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(554, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 60);
            this.label4.TabIndex = 9;
            this.label4.Text = "功能說明:\r\n1.A跟B欄位找出不相同資料\r\n2.A跟B欄位找出相同資料";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(512, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 297);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15F);
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "選擇模式:";
            // 
            // comboBox_select_type
            // 
            this.comboBox_select_type.Font = new System.Drawing.Font("新細明體", 15F);
            this.comboBox_select_type.FormattingEnabled = true;
            this.comboBox_select_type.Items.AddRange(new object[] {
            "不同",
            "相同"});
            this.comboBox_select_type.Location = new System.Drawing.Point(108, 54);
            this.comboBox_select_type.Name = "comboBox_select_type";
            this.comboBox_select_type.Size = new System.Drawing.Size(121, 28);
            this.comboBox_select_type.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(9, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 240);
            this.label2.TabIndex = 6;
            this.label2.Text = "使用說明:如下列\r\n\r\nexcel轉換成txt檔案\r\n1.檔案\r\n2.另存新檔\r\n3.存檔類型:文字檔(*.txt)\r\n\r\n本頁面功能操作\r\n4.選擇模式:相同或" +
    "不同\r\n5.按鍵:選擇文字檔\r\n6.執行完成\r\n7.按鍵:選擇開啟輸出檔案路徑\r\n";
            // 
            // label_run_result
            // 
            this.label_run_result.AutoSize = true;
            this.label_run_result.Font = new System.Drawing.Font("新細明體", 15F);
            this.label_run_result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_run_result.Location = new System.Drawing.Point(247, 58);
            this.label_run_result.Name = "label_run_result";
            this.label_run_result.Size = new System.Drawing.Size(94, 20);
            this.label_run_result.TabIndex = 5;
            this.label_run_result.Text = "執行狀態:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label_addrows_ok);
            this.tabPage2.Controls.Add(this.button_rows_open_path);
            this.tabPage2.Controls.Add(this.textBox_write_rows_data);
            this.tabPage2.Controls.Add(this.button_write_rows_data);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(876, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "新增rows資料";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label_addrows_ok
            // 
            this.label_addrows_ok.AutoSize = true;
            this.label_addrows_ok.Location = new System.Drawing.Point(8, 76);
            this.label_addrows_ok.Name = "label_addrows_ok";
            this.label_addrows_ok.Size = new System.Drawing.Size(53, 20);
            this.label_addrows_ok.TabIndex = 3;
            this.label_addrows_ok.Text = "label5";
            // 
            // button_rows_open_path
            // 
            this.button_rows_open_path.Location = new System.Drawing.Point(187, 124);
            this.button_rows_open_path.Name = "button_rows_open_path";
            this.button_rows_open_path.Size = new System.Drawing.Size(150, 45);
            this.button_rows_open_path.TabIndex = 2;
            this.button_rows_open_path.Text = "開啟路徑";
            this.button_rows_open_path.UseVisualStyleBackColor = true;
            this.button_rows_open_path.Click += new System.EventHandler(this.button_rows_open_path_Click);
            // 
            // textBox_write_rows_data
            // 
            this.textBox_write_rows_data.Location = new System.Drawing.Point(8, 25);
            this.textBox_write_rows_data.Name = "textBox_write_rows_data";
            this.textBox_write_rows_data.Size = new System.Drawing.Size(631, 31);
            this.textBox_write_rows_data.TabIndex = 1;
            this.textBox_write_rows_data.Click += new System.EventHandler(this.textBox_write_rows_data_Click);
            // 
            // button_write_rows_data
            // 
            this.button_write_rows_data.Location = new System.Drawing.Point(3, 124);
            this.button_write_rows_data.Name = "button_write_rows_data";
            this.button_write_rows_data.Size = new System.Drawing.Size(150, 45);
            this.button_write_rows_data.TabIndex = 0;
            this.button_write_rows_data.Text = "寫rows資料";
            this.button_write_rows_data.UseVisualStyleBackColor = true;
            this.button_write_rows_data.Click += new System.EventHandler(this.button_write_rows_data_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 501);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "淑怡_工具_1.0.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_read_excel;
        private System.Windows.Forms.TextBox textBox_file_path_name;
        private System.Windows.Forms.Button button_current_file_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label_run_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_select_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_write_rows_data;
        private System.Windows.Forms.TextBox textBox_write_rows_data;
        private System.Windows.Forms.Button button_rows_open_path;
        private System.Windows.Forms.Label label_addrows_ok;
    }
}

