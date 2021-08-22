
namespace InquiryPerformanceProgram
{
    partial class SelectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.facilyareacombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CostCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lentalcombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NumberCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.presalecombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.valuecombo = new System.Windows.Forms.ComboBox();
            this.citycombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.yearcombo = new System.Windows.Forms.ComboBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(858, 48);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 72);
            this.button1.TabIndex = 16;
            this.button1.Text = "CHECK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Select_Button_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ClearButton.Location = new System.Drawing.Point(858, 143);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(186, 75);
            this.ClearButton.TabIndex = 17;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 268);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 539);
            this.dataGridView1.TabIndex = 18;
            // 
            // facilyareacombo
            // 
            this.facilyareacombo.FormattingEnabled = true;
            this.facilyareacombo.Location = new System.Drawing.Point(703, 129);
            this.facilyareacombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.facilyareacombo.Name = "facilyareacombo";
            this.facilyareacombo.Size = new System.Drawing.Size(102, 23);
            this.facilyareacombo.TabIndex = 32;
            this.facilyareacombo.SelectedIndexChanged += new System.EventHandler(this.facilyareacombo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(618, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "사업면적";
            // 
            // CostCombo
            // 
            this.CostCombo.FormattingEnabled = true;
            this.CostCombo.Location = new System.Drawing.Point(88, 129);
            this.CostCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CostCombo.Name = "CostCombo";
            this.CostCombo.Size = new System.Drawing.Size(102, 23);
            this.CostCombo.TabIndex = 30;
            this.CostCombo.SelectedIndexChanged += new System.EventHandler(this.CostCombo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "사업비";
            // 
            // lentalcombo
            // 
            this.lentalcombo.FormattingEnabled = true;
            this.lentalcombo.Location = new System.Drawing.Point(497, 126);
            this.lentalcombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lentalcombo.Name = "lentalcombo";
            this.lentalcombo.Size = new System.Drawing.Size(102, 23);
            this.lentalcombo.TabIndex = 28;
            this.lentalcombo.SelectedIndexChanged += new System.EventHandler(this.lentalcombo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "임대매출";
            // 
            // NumberCombo
            // 
            this.NumberCombo.FormattingEnabled = true;
            this.NumberCombo.Location = new System.Drawing.Point(703, 72);
            this.NumberCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumberCombo.Name = "NumberCombo";
            this.NumberCombo.Size = new System.Drawing.Size(102, 23);
            this.NumberCombo.TabIndex = 26;
            this.NumberCombo.SelectedIndexChanged += new System.EventHandler(this.NumberCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "사업건수";
            // 
            // presalecombo
            // 
            this.presalecombo.FormattingEnabled = true;
            this.presalecombo.Location = new System.Drawing.Point(288, 126);
            this.presalecombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.presalecombo.Name = "presalecombo";
            this.presalecombo.Size = new System.Drawing.Size(102, 23);
            this.presalecombo.TabIndex = 24;
            this.presalecombo.SelectedIndexChanged += new System.EventHandler(this.presalecombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "분양매출";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "참여유형";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "도시";
            // 
            // valuecombo
            // 
            this.valuecombo.FormattingEnabled = true;
            this.valuecombo.Location = new System.Drawing.Point(494, 72);
            this.valuecombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valuecombo.Name = "valuecombo";
            this.valuecombo.Size = new System.Drawing.Size(102, 23);
            this.valuecombo.TabIndex = 20;
            this.valuecombo.SelectedIndexChanged += new System.EventHandler(this.valuecombo_SelectedIndexChanged);
            // 
            // citycombo
            // 
            this.citycombo.FormattingEnabled = true;
            this.citycombo.Location = new System.Drawing.Point(288, 72);
            this.citycombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.citycombo.Name = "citycombo";
            this.citycombo.Size = new System.Drawing.Size(102, 23);
            this.citycombo.TabIndex = 19;
            this.citycombo.SelectedIndexChanged += new System.EventHandler(this.citycombo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "연도";
            // 
            // yearcombo
            // 
            this.yearcombo.FormattingEnabled = true;
            this.yearcombo.Location = new System.Drawing.Point(91, 72);
            this.yearcombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yearcombo.Name = "yearcombo";
            this.yearcombo.Size = new System.Drawing.Size(102, 23);
            this.yearcombo.TabIndex = 34;
            this.yearcombo.SelectedIndexChanged += new System.EventHandler(this.ChangeCheckBox);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(607, 214);
            this.checkBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(89, 19);
            this.checkBox9.TabIndex = 41;
            this.checkBox9.Text = "사업면적";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(518, 214);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(89, 19);
            this.checkBox7.TabIndex = 40;
            this.checkBox7.Text = "임대매출";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(429, 214);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(89, 19);
            this.checkBox6.TabIndex = 39;
            this.checkBox6.Text = "분양매출";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(353, 214);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(74, 19);
            this.checkBox5.TabIndex = 38;
            this.checkBox5.Text = "사업비";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(264, 214);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(89, 19);
            this.checkBox4.TabIndex = 37;
            this.checkBox4.Text = "사업건수";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(175, 214);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(89, 19);
            this.checkBox3.TabIndex = 36;
            this.checkBox3.Text = "참여유형";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(113, 214);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(59, 19);
            this.checkBox2.TabIndex = 35;
            this.checkBox2.Text = "도시";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(46, 214);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 19);
            this.checkBox1.TabIndex = 42;
            this.checkBox1.Text = "연도";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 846);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.yearcombo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.facilyareacombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CostCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lentalcombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumberCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.presalecombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valuecombo);
            this.Controls.Add(this.citycombo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SelectForm";
            this.Text = "SelectForm";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox facilyareacombo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CostCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox lentalcombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox NumberCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox presalecombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox valuecombo;
        private System.Windows.Forms.ComboBox citycombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox yearcombo;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}