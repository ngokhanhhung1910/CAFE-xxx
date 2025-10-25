namespace GUI
{
    partial class OrderManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button24 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button24);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng ký ghế";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số ghế:";
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(81, 192);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 48);
            this.button24.TabIndex = 3;
            this.button24.Text = "Chọn";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button21);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.button20);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button19);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button18);
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.button17);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button16);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button15);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button14);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button23);
            this.groupBox2.Controls.Add(this.button22);
            this.groupBox2.Controls.Add(this.button13);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(265, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(652, 270);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khu vực quán";
            this.groupBox2.MouseCaptureChanged += new System.EventHandler(this.ButtonSeat_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 99);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(76, 74);
            this.button8.TabIndex = 0;
            this.button8.Text = "5";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.MouseCaptureChanged += new System.EventHandler(this.ButtonSeat_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(561, 179);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(76, 74);
            this.button21.TabIndex = 0;
            this.button21.Text = "21";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.MouseCaptureChanged += new System.EventHandler(this.ButtonSeat_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(252, 179);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(76, 74);
            this.button11.TabIndex = 0;
            this.button11.Text = "12";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.MouseCaptureChanged += new System.EventHandler(this.ButtonSeat_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(397, 179);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(76, 74);
            this.button20.TabIndex = 0;
            this.button20.Text = "19";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.MouseCaptureChanged += new System.EventHandler(this.ButtonSeat_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(88, 179);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(76, 74);
            this.button9.TabIndex = 0;
            this.button9.Text = "10";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.MouseCaptureChanged += new System.EventHandler(this.ButtonSeat_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 179);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(76, 74);
            this.button10.TabIndex = 0;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.MouseCaptureChanged += new System.EventHandler(this.ButtonSeat_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(397, 99);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(76, 74);
            this.button19.TabIndex = 0;
            this.button19.Text = "16";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.MouseCaptureChanged += new System.EventHandler(this.ButtonSeat_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(88, 99);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 74);
            this.button7.TabIndex = 0;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.MouseCaptureChanged += new System.EventHandler(this.ButtonSeat_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(479, 179);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(76, 74);
            this.button18.TabIndex = 0;
            this.button18.Text = "20";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.MouseCaptureChanged += new System.EventHandler(this.ButtonSeat_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(170, 179);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(76, 74);
            this.button12.TabIndex = 0;
            this.button12.Text = "11";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.MouseCaptureChanged += new System.EventHandler(this.ButtonSeat_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(479, 99);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(76, 74);
            this.button17.TabIndex = 0;
            this.button17.Text = "17";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.MouseCaptureChanged += new System.EventHandler(this.ButtonSeat_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(170, 99);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 74);
            this.button6.TabIndex = 0;
            this.button6.Text = "7";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.MouseCaptureChanged += new System.EventHandler(this.ButtonSeat_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(561, 99);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(76, 74);
            this.button16.TabIndex = 0;
            this.button16.Text = "18";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.MouseCaptureChanged += new System.EventHandler(this.ButtonSeat_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(252, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 74);
            this.button5.TabIndex = 0;
            this.button5.Text = "8";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.MouseCaptureChanged += new System.EventHandler(this.ButtonSeat_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(561, 19);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(76, 74);
            this.button15.TabIndex = 0;
            this.button15.Text = "15";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.MouseCaptureChanged += new System.EventHandler(this.ButtonSeat_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(252, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 74);
            this.button4.TabIndex = 0;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseCaptureChanged += new System.EventHandler(this.ButtonSeat_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(479, 19);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(76, 74);
            this.button14.TabIndex = 0;
            this.button14.Text = "14";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.MouseCaptureChanged += new System.EventHandler(this.ButtonSeat_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(170, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 74);
            this.button3.TabIndex = 0;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseCaptureChanged += new System.EventHandler(this.ButtonSeat_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(345, 146);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(33, 107);
            this.button23.TabIndex = 0;
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(345, 19);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(33, 107);
            this.button22.TabIndex = 0;
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(397, 19);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(76, 74);
            this.button13.TabIndex = 0;
            this.button13.Text = "13";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.MouseCaptureChanged += new System.EventHandler(this.ButtonSeat_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 74);
            this.button2.TabIndex = 0;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseCaptureChanged += new System.EventHandler(this.ButtonSeat_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseCaptureChanged += new System.EventHandler(this.ButtonSeat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.soghe});
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(905, 232);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            // 
            // soghe
            // 
            this.soghe.HeaderText = "Số ghế";
            this.soghe.Name = "soghe";
            // 
            // OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 600);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderManagement";
            this.Text = "OrderManagement";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn soghe;
    }
}