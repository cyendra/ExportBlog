using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using ExportBlog.Service;

namespace ExportBlog
{
    public partial class ListForm : Form
    {
        FeedService feedService = null;

        public ListForm(FeedService feedService)
        {
            this.feedService = feedService;
            InitializeComponent();
        }
        private delegate void SetItem();
        private void SetChkItem()
        {
            SetItem st = new SetItem(delegate()
            {
                var list = feedService.GetList();
                loading_lb.Invoke(new SetItem(delegate()
                {
                    loading_lb.Text = "文章列表加载完毕";
                }));
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    ckListBox.Items.Add(list[i].Title, true);
                }
            });
            ckListBox.Invoke(st);
        }

        #region events

        private void ListForm_Load(object sender, EventArgs e)
        {
            all_cbx.Checked = true;

            new Thread(() =>
            {
                Thread.Sleep(50);
                SetChkItem();
            })
            {
                IsBackground = true
            }.Start();
        }

        private void all_cbx_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ckListBox.Items.Count; i++)
            {
                ckListBox.SetItemChecked(i, all_cbx.Checked);
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            var list = feedService.GetList();
            int total = 0;
            int cnt = ckListBox.Items.Count;
            for (int i = 0; i < cnt; i++)
            {
                if (!ckListBox.GetItemChecked(i))
                {
                    list[cnt - i - 1].IsDown = false;
                    total++;
                }
            }
            if (total == ckListBox.Items.Count)
            {
                MessageBox.Show("请选择要导出的文章。");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        #endregion
    }
}
