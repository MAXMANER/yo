namespace WindowsFormsApp2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.Receiver_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Receiver_Phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Receiver_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Purchaser_Address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Puchaser_Phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Purchaser_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Purchaser = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(696, 417);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btn_Purchaser);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.Receiver_Address);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Receiver_Phone);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.Receiver_Name);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.Purchaser_Address);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Puchaser_Phone);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Purchaser_Name);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(688, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "新增訂單";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(25, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "購買人資料";
            // 
            // Receiver_Address
            // 
            this.Receiver_Address.Location = new System.Drawing.Point(123, 236);
            this.Receiver_Address.Name = "Receiver_Address";
            this.Receiver_Address.Size = new System.Drawing.Size(307, 25);
            this.Receiver_Address.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "收件人地址: ";
            // 
            // Receiver_Phone
            // 
            this.Receiver_Phone.Location = new System.Drawing.Point(330, 185);
            this.Receiver_Phone.Name = "Receiver_Phone";
            this.Receiver_Phone.Size = new System.Drawing.Size(100, 25);
            this.Receiver_Phone.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "收件人電話: ";
            // 
            // Receiver_Name
            // 
            this.Receiver_Name.Location = new System.Drawing.Point(123, 185);
            this.Receiver_Name.Name = "Receiver_Name";
            this.Receiver_Name.Size = new System.Drawing.Size(100, 25);
            this.Receiver_Name.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "收件人姓名: ";
            // 
            // Purchaser_Address
            // 
            this.Purchaser_Address.Location = new System.Drawing.Point(123, 107);
            this.Purchaser_Address.Name = "Purchaser_Address";
            this.Purchaser_Address.Size = new System.Drawing.Size(307, 25);
            this.Purchaser_Address.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "購買人地址: ";
            // 
            // Puchaser_Phone
            // 
            this.Puchaser_Phone.Location = new System.Drawing.Point(330, 56);
            this.Puchaser_Phone.Name = "Puchaser_Phone";
            this.Puchaser_Phone.Size = new System.Drawing.Size(100, 25);
            this.Puchaser_Phone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "購買人電話: ";
            // 
            // Purchaser_Name
            // 
            this.Purchaser_Name.Location = new System.Drawing.Point(123, 56);
            this.Purchaser_Name.Name = "Purchaser_Name";
            this.Purchaser_Name.Size = new System.Drawing.Size(100, 25);
            this.Purchaser_Name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "購買人姓名: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(688, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_Purchaser
            // 
            this.btn_Purchaser.Location = new System.Drawing.Point(355, 289);
            this.btn_Purchaser.Name = "btn_Purchaser";
            this.btn_Purchaser.Size = new System.Drawing.Size(75, 29);
            this.btn_Purchaser.TabIndex = 13;
            this.btn_Purchaser.Text = "新增";
            this.btn_Purchaser.UseVisualStyleBackColor = true;
            this.btn_Purchaser.Click += new System.EventHandler(this.btn_Purchaser_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(25, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "收貨人資料";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(449, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Receiver_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Receiver_Phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Receiver_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Purchaser_Address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Puchaser_Phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Purchaser_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Purchaser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

