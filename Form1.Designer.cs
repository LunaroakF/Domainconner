﻿namespace Domainconner
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
            this.HelpButton = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.reaaddbutton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.readelbutton = new System.Windows.Forms.Button();
            this.RealmBox = new System.Windows.Forms.TextBox();
            this.RealmComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.HostsBox = new System.Windows.Forms.TextBox();
            this.hostsButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hostsButton);
            this.groupBox1.Controls.Add(this.HelpButton);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.reaaddbutton);
            this.groupBox1.Controls.Add(this.StartButton);
            this.groupBox1.Controls.Add(this.readelbutton);
            this.groupBox1.Controls.Add(this.RealmBox);
            this.groupBox1.Controls.Add(this.RealmComboBox);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(268, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "域名输入";
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(9, 168);
            this.HelpButton.Margin = new System.Windows.Forms.Padding(4);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(79, 46);
            this.HelpButton.TabIndex = 7;
            this.HelpButton.Text = "教程";
            this.HelpButton.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(9, 285);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(227, 32);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "处理完毕后声音提醒";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(9, 248);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(245, 32);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "IP域名一对一 (优先级)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // reaaddbutton
            // 
            this.reaaddbutton.Location = new System.Drawing.Point(9, 119);
            this.reaaddbutton.Margin = new System.Windows.Forms.Padding(4);
            this.reaaddbutton.Name = "reaaddbutton";
            this.reaaddbutton.Size = new System.Drawing.Size(79, 46);
            this.reaaddbutton.TabIndex = 4;
            this.reaaddbutton.Text = "添加";
            this.reaaddbutton.UseVisualStyleBackColor = true;
            this.reaaddbutton.Click += new System.EventHandler(this.reaaddbutton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(172, 119);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(79, 46);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "开始";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // readelbutton
            // 
            this.readelbutton.Enabled = false;
            this.readelbutton.Location = new System.Drawing.Point(90, 119);
            this.readelbutton.Margin = new System.Windows.Forms.Padding(4);
            this.readelbutton.Name = "readelbutton";
            this.readelbutton.Size = new System.Drawing.Size(79, 46);
            this.readelbutton.TabIndex = 2;
            this.readelbutton.Text = "删除";
            this.readelbutton.UseVisualStyleBackColor = true;
            this.readelbutton.Click += new System.EventHandler(this.readelbutton_Click);
            // 
            // RealmBox
            // 
            this.RealmBox.Location = new System.Drawing.Point(9, 75);
            this.RealmBox.Margin = new System.Windows.Forms.Padding(4);
            this.RealmBox.Name = "RealmBox";
            this.RealmBox.Size = new System.Drawing.Size(242, 35);
            this.RealmBox.TabIndex = 1;
            this.RealmBox.TextChanged += new System.EventHandler(this.RealmBox_TextChanged);
            // 
            // RealmComboBox
            // 
            this.RealmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RealmComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RealmComboBox.FormattingEnabled = true;
            this.RealmComboBox.Location = new System.Drawing.Point(9, 32);
            this.RealmComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.RealmComboBox.Name = "RealmComboBox";
            this.RealmComboBox.Size = new System.Drawing.Size(242, 36);
            this.RealmComboBox.TabIndex = 2;
            this.RealmComboBox.Tag = "";
            this.RealmComboBox.SelectedIndexChanged += new System.EventHandler(this.RealmComboBox_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IPBox);
            this.groupBox2.Location = new System.Drawing.Point(4, 331);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(268, 282);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "可用IP";
            // 
            // IPBox
            // 
            this.IPBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IPBox.Location = new System.Drawing.Point(4, 32);
            this.IPBox.Margin = new System.Windows.Forms.Padding(4);
            this.IPBox.Multiline = true;
            this.IPBox.Name = "IPBox";
            this.IPBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.IPBox.Size = new System.Drawing.Size(260, 246);
            this.IPBox.TabIndex = 1;
            this.IPBox.TextChanged += new System.EventHandler(this.IPBox_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LogBox);
            this.groupBox3.Location = new System.Drawing.Point(276, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(370, 312);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "日志";
            // 
            // LogBox
            // 
            this.LogBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogBox.Location = new System.Drawing.Point(4, 32);
            this.LogBox.Margin = new System.Windows.Forms.Padding(4);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogBox.Size = new System.Drawing.Size(362, 276);
            this.LogBox.TabIndex = 1;
            this.LogBox.WordWrap = false;
            this.LogBox.TextChanged += new System.EventHandler(this.LogBox_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.HostsBox);
            this.groupBox4.Location = new System.Drawing.Point(276, 331);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(369, 282);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hosts输出";
            // 
            // HostsBox
            // 
            this.HostsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HostsBox.Location = new System.Drawing.Point(4, 32);
            this.HostsBox.Margin = new System.Windows.Forms.Padding(4);
            this.HostsBox.Multiline = true;
            this.HostsBox.Name = "HostsBox";
            this.HostsBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.HostsBox.Size = new System.Drawing.Size(361, 246);
            this.HostsBox.TabIndex = 1;
            this.HostsBox.TextChanged += new System.EventHandler(this.HostsBox_TextChanged);
            // 
            // hostsButton
            // 
            this.hostsButton.Location = new System.Drawing.Point(172, 168);
            this.hostsButton.Margin = new System.Windows.Forms.Padding(4);
            this.hostsButton.Name = "hostsButton";
            this.hostsButton.Size = new System.Drawing.Size(79, 46);
            this.hostsButton.TabIndex = 8;
            this.hostsButton.Text = "Hosts";
            this.hostsButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(658, 625);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nepeta cataria";
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
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button hostsButton;
    }
}

