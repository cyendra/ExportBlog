namespace ExportBlog
{
    partial class ListForm
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
            this.all_cbx = new System.Windows.Forms.CheckBox();
            this.ckListBox = new System.Windows.Forms.CheckedListBox();
            this.ok_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.loading_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // all_cbx
            // 
            this.all_cbx.AutoSize = true;
            this.all_cbx.Location = new System.Drawing.Point(13, 245);
            this.all_cbx.Name = "all_cbx";
            this.all_cbx.Size = new System.Drawing.Size(48, 16);
            this.all_cbx.TabIndex = 0;
            this.all_cbx.Text = "全选";
            this.all_cbx.UseVisualStyleBackColor = true;
            this.all_cbx.CheckedChanged += new System.EventHandler(this.all_cbx_CheckedChanged);
            // 
            // ckListBox
            // 
            this.ckListBox.FormattingEnabled = true;
            this.ckListBox.Location = new System.Drawing.Point(13, 13);
            this.ckListBox.Name = "ckListBox";
            this.ckListBox.Size = new System.Drawing.Size(474, 212);
            this.ckListBox.TabIndex = 1;
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(297, 241);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 2;
            this.ok_btn.Text = "确定";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(412, 241);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 3;
            this.back_btn.Text = "取消";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // loading_lb
            // 
            this.loading_lb.AutoSize = true;
            this.loading_lb.Location = new System.Drawing.Point(114, 245);
            this.loading_lb.Name = "loading_lb";
            this.loading_lb.Size = new System.Drawing.Size(119, 12);
            this.loading_lb.TabIndex = 4;
            this.loading_lb.Text = "正在加载文章列表...";
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 273);
            this.ControlBox = false;
            this.Controls.Add(this.loading_lb);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.ckListBox);
            this.Controls.Add(this.all_cbx);
            this.Name = "ListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择要导出的文章";
            this.Load += new System.EventHandler(this.ListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox all_cbx;
        private System.Windows.Forms.CheckedListBox ckListBox;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label loading_lb;
    }
}