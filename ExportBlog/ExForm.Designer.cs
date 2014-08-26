namespace ExportBlog
{
    partial class ExForm
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
            this.blog_tabControl = new System.Windows.Forms.TabControl();
            this.exTabPage = new System.Windows.Forms.TabPage();
            this.blog_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.column_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbColumn = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.url_btn = new System.Windows.Forms.Button();
            this.url_label = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.logBox = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.blog_tabControl.SuspendLayout();
            this.exTabPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // blog_tabControl
            // 
            this.blog_tabControl.Controls.Add(this.exTabPage);
            this.blog_tabControl.Controls.Add(this.tabPage2);
            this.blog_tabControl.Controls.Add(this.tabPage3);
            this.blog_tabControl.Location = new System.Drawing.Point(12, 25);
            this.blog_tabControl.Name = "blog_tabControl";
            this.blog_tabControl.SelectedIndex = 0;
            this.blog_tabControl.Size = new System.Drawing.Size(640, 138);
            this.blog_tabControl.TabIndex = 8;
            this.blog_tabControl.SelectedIndexChanged += new System.EventHandler(this.blog_tabControl_SelectedIndexChanged);
            // 
            // exTabPage
            // 
            this.exTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exTabPage.Controls.Add(this.blog_btn);
            this.exTabPage.Controls.Add(this.label1);
            this.exTabPage.Controls.Add(this.tbUser);
            this.exTabPage.Location = new System.Drawing.Point(4, 22);
            this.exTabPage.Name = "exTabPage";
            this.exTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.exTabPage.Size = new System.Drawing.Size(632, 112);
            this.exTabPage.TabIndex = 0;
            this.exTabPage.Text = "整个博客";
            // 
            // blog_btn
            // 
            this.blog_btn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blog_btn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.blog_btn.Location = new System.Drawing.Point(489, 25);
            this.blog_btn.Name = "blog_btn";
            this.blog_btn.Size = new System.Drawing.Size(126, 36);
            this.blog_btn.TabIndex = 2;
            this.blog_btn.Text = "导 出";
            this.blog_btn.UseVisualStyleBackColor = true;
            this.blog_btn.Click += new System.EventHandler(this.blog_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "http://blog.csdn.net/";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(166, 35);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(96, 21);
            this.tbUser.TabIndex = 1;
            this.tbUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUser_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.column_btn);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbColumn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(632, 112);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "博客专栏";
            // 
            // column_btn
            // 
            this.column_btn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.column_btn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.column_btn.Location = new System.Drawing.Point(489, 25);
            this.column_btn.Name = "column_btn";
            this.column_btn.Size = new System.Drawing.Size(126, 36);
            this.column_btn.TabIndex = 5;
            this.column_btn.Text = "导 出";
            this.column_btn.UseVisualStyleBackColor = true;
            this.column_btn.Click += new System.EventHandler(this.column_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F);
            this.label4.Location = new System.Drawing.Point(368, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = ".html";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F);
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "http://blog.csdn.net/column/details/";
            // 
            // tbColumn
            // 
            this.tbColumn.Location = new System.Drawing.Point(271, 36);
            this.tbColumn.Name = "tbColumn";
            this.tbColumn.Size = new System.Drawing.Size(93, 21);
            this.tbColumn.TabIndex = 3;
            this.tbColumn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbColumn_KeyPress);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.url_btn);
            this.tabPage3.Controls.Add(this.url_label);
            this.tabPage3.Controls.Add(this.tbUrl);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(632, 112);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "指定文章";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "回车分割多个URL";
            // 
            // url_btn
            // 
            this.url_btn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.url_btn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.url_btn.Location = new System.Drawing.Point(489, 25);
            this.url_btn.Name = "url_btn";
            this.url_btn.Size = new System.Drawing.Size(126, 36);
            this.url_btn.TabIndex = 8;
            this.url_btn.Text = "导 出";
            this.url_btn.UseVisualStyleBackColor = true;
            this.url_btn.Click += new System.EventHandler(this.url_btn_Click);
            // 
            // url_label
            // 
            this.url_label.AutoSize = true;
            this.url_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.url_label.Location = new System.Drawing.Point(12, 9);
            this.url_label.Name = "url_label";
            this.url_label.Size = new System.Drawing.Size(40, 16);
            this.url_label.TabIndex = 6;
            this.url_label.Text = "url:";
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(58, 10);
            this.tbUrl.Multiline = true;
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbUrl.Size = new System.Drawing.Size(400, 84);
            this.tbUrl.TabIndex = 7;
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(12, 169);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(640, 215);
            this.logBox.TabIndex = 7;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(557, 406);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 9;
            this.save_btn.Text = "保存日志";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // ExForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 441);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.blog_tabControl);
            this.Controls.Add(this.logBox);
            this.MaximizeBox = false;
            this.Name = "ExForm";
            this.Text = "简易CSDN博客导出器";
            this.Load += new System.EventHandler(this.ExForm_Load);
            this.blog_tabControl.ResumeLayout(false);
            this.exTabPage.ResumeLayout(false);
            this.exTabPage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl blog_tabControl;
        private System.Windows.Forms.TabPage exTabPage;
        private System.Windows.Forms.Button blog_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button url_btn;
        private System.Windows.Forms.Label url_label;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button column_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbColumn;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button save_btn;


    }
}