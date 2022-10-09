namespace RealmconnerNet4._7._2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RealmComboBox = new System.Windows.Forms.ComboBox();
            this.RealmBox = new System.Windows.Forms.TextBox();
            this.readelbutton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.reaaddbutton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.HostsBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.reaaddbutton);
            this.groupBox1.Controls.Add(this.StartButton);
            this.groupBox1.Controls.Add(this.readelbutton);
            this.groupBox1.Controls.Add(this.RealmBox);
            this.groupBox1.Controls.Add(this.RealmComboBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "域名输入";
            // 
            // RealmComboBox
            // 
            this.RealmComboBox.FormattingEnabled = true;
            this.RealmComboBox.Location = new System.Drawing.Point(8, 22);
            this.RealmComboBox.Name = "RealmComboBox";
            this.RealmComboBox.Size = new System.Drawing.Size(210, 25);
            this.RealmComboBox.TabIndex = 0;
            this.RealmComboBox.SelectedIndexChanged += new System.EventHandler(this.RealmComboBox_SelectedValueChanged);
            // 
            // RealmBox
            // 
            this.RealmBox.Location = new System.Drawing.Point(8, 53);
            this.RealmBox.Name = "RealmBox";
            this.RealmBox.Size = new System.Drawing.Size(210, 23);
            this.RealmBox.TabIndex = 1;
            // 
            // readelbutton
            // 
            this.readelbutton.Location = new System.Drawing.Point(8, 81);
            this.readelbutton.Name = "readelbutton";
            this.readelbutton.Size = new System.Drawing.Size(53, 24);
            this.readelbutton.TabIndex = 2;
            this.readelbutton.Text = "删除";
            this.readelbutton.UseVisualStyleBackColor = true;
            this.readelbutton.Click += new System.EventHandler(this.readelbutton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(66, 81);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(93, 24);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "开始";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // reaaddbutton
            // 
            this.reaaddbutton.Location = new System.Drawing.Point(165, 81);
            this.reaaddbutton.Name = "reaaddbutton";
            this.reaaddbutton.Size = new System.Drawing.Size(53, 24);
            this.reaaddbutton.TabIndex = 4;
            this.reaaddbutton.Text = "添加";
            this.reaaddbutton.UseVisualStyleBackColor = true;
            this.reaaddbutton.Click += new System.EventHandler(this.reaaddbutton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 109);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(146, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "一个域名仅对应一个IP";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IPBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 313);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "可用IP";
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(8, 24);
            this.IPBox.Multiline = true;
            this.IPBox.Name = "IPBox";
            this.IPBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.IPBox.Size = new System.Drawing.Size(210, 283);
            this.IPBox.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LogBox);
            this.groupBox3.Location = new System.Drawing.Point(245, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 237);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "日志";
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(6, 24);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogBox.Size = new System.Drawing.Size(338, 207);
            this.LogBox.TabIndex = 1;
            this.LogBox.TextChanged += new System.EventHandler(this.LogBox_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.HostsBox);
            this.groupBox4.Location = new System.Drawing.Point(242, 255);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 199);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hosts输出";
            // 
            // HostsBox
            // 
            this.HostsBox.Location = new System.Drawing.Point(6, 24);
            this.HostsBox.Multiline = true;
            this.HostsBox.Name = "HostsBox";
            this.HostsBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.HostsBox.Size = new System.Drawing.Size(338, 169);
            this.HostsBox.TabIndex = 1;
            this.HostsBox.TextChanged += new System.EventHandler(this.HostsBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 472);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RealmconnerNet4.7.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button reaaddbutton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button readelbutton;
        private System.Windows.Forms.TextBox RealmBox;
        private System.Windows.Forms.ComboBox RealmComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox HostsBox;
    }
}

