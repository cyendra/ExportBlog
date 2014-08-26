/*
                        ::
                      :;J7, :,                        ::;7:
                      ,ivYi, ,                       ;LLLFS:
                      :iv7Yi                       :7ri;j5PL
                     ,:ivYLvr                    ,ivrrirrY2X,
                     :;r@Wwz.7r:                :ivu@kexianli.
                    :iL7::,:::iiirii:ii;::::,,irvF7rvvLujL7ur
                   ri::,:,::i:iiiiiii:i:irrv177JX7rYXqZEkvv17
                ;i:, , ::::iirrririi:i:::iiir2XXvii;L8OGJr71i
              :,, ,,:   ,::ir@mingyi.irii:i:::j1jri7ZBOS7ivv,
                 ,::,    ::rv77iiiriii:iii:i::,rvLq@huhao.Li
             ,,      ,, ,:ir7ir::,:::i;ir:::i:i::rSGGYri712:
           :::  ,v7r:: ::rrv77:, ,, ,:i7rrii:::::, ir7ri7Lri
          ,     2OBBOi,iiir;r::        ,irriiii::,, ,iv7Luur:
        ,,     i78MBBi,:,:::,:,  :7FSL: ,iriii:::i::,,:rLqXv::
        :      iuMMP: :,:::,:ii;2GY7OBB0viiii:i:iii:i:::iJqL;::
       ,     ::::i   ,,,,, ::LuBBu BBBBBErii:i:i:i:i:i:i:r77ii
      ,       :       , ,,:::rruBZ1MBBqi, :,,,:::,::::::iiriri:
     ,               ,,,,::::i:  @arqiao.       ,:,, ,:::ii;i7:
    :,       rjujLYLi   ,,:::::,:::::::::,,   ,:i,:,,,,,::i:iii
    ::      BBBBBBBBB0,    ,,::: , ,:::::: ,      ,,,, ,,:::::::
    i,  ,  ,8BMMBBBBBBi     ,,:,,     ,,, , ,   , , , :,::ii::i::
    :      iZMOMOMBBM2::::::::::,,,,     ,,,,,,:,,,::::i:irr:i:::,
    i   ,,:;u0MBMOG1L:::i::::::  ,,,::,   ,,, ::::::i:i:iirii:i:i:
    :    ,iuUuuXUkFu7i:iii:i:::, :,:,: ::::::::i:i:::::iirr7iiri::
    :     :rk@Yizero.i:::::, ,:ii:::::::i:::::i::,::::iirrriiiri::,
     :      5BMBBBBBBSr:,::rv2kuii:::iii::,:i:,, , ,,:,:i@petermu.,
          , :r50EZ8MBBBBGOBBBZP7::::i::,:::::,: :,:,::i;rrririiii::
              :jujYY7LS0ujJL7r::,::i::,::::::::::::::iirirrrrrrr:ii:
           ,:  :@kevensun.:,:,,,::::i:i:::::,,::::::iir;ii;7v77;ii;i,
           ,,,     ,,:,::::::i:iiiii:i::::,, ::::iiiir@xingjief.r;7:i,
        , , ,,,:,,::::::::iiiiiiiiii:,:,:::::::::iiir;ri7vL77rrirri::
         :,, , ::::::::i:::i:::i:i::,,,,,:,::i:i:::iir;@Secbone.ii:::
 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using ExportBlog.Service;
using ExportBlog.Package;
namespace ExportBlog
{
    public partial class ExForm : Form
    {
        public ExForm()
        {
            InitializeComponent();
        }

        private void ExForm_Load(object sender, EventArgs e)
        {
            tbUser.Select();
        }

        private void blog_tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.blog_tabControl.SelectedIndex == 0) tbUser.Select();
            if (this.blog_tabControl.SelectedIndex == 1) tbColumn.Select();
            if (this.blog_tabControl.SelectedIndex == 2) tbUrl.Select();
        }

        private void StartExport()
        {
            var put = GetInput();
            if (!put.Status) return;

            Source src = Source.csdn;
            string user = put.Text;
            if (put.Type == Type.Url) user = src.ToString();
            string title = App.GetDescription(src);

            FeedService fs = new FeedService(src, user);

            if (put.Type == Type.Blog)
            {
                ListForm frm = new ListForm(fs);
                if (frm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
            }

            this.blog_btn.Enabled = false;
            this.column_btn.Enabled = false;
            this.url_btn.Enabled = false;

            Thread thd = new Thread(() =>
            {
                string[] urls = null;
                if (put.Type == Type.Url)
                {
                    urls = put.Text.Replace("\r", "").Split(new char[] { '\n', ',', '，', ';', '；' }, StringSplitOptions.RemoveEmptyEntries);
                }
                else if (put.Type == Type.Column)
                {//抓取URL 
                    urls = GetColumnUrls(put.Text);
                }
                if ((put.Format & Format.HTML) != 0)
                {
                    SetLbText("开始生成HTML文档");
                    HtmlPackage htm = new HtmlPackage(user, title, fs, urls, SetLbText);
                    htm.Build();
                    SetLbText("HTML文档生成成功！");
                }
                MessageBox.Show("全部导出完成！");
                blog_btn.Invoke(new SetText(delegate(string s)
                {
                    blog_btn.Enabled = true;
                }), string.Empty);
                column_btn.Invoke(new SetText(delegate(string s)
                {
                    column_btn.Enabled = true;
                }), string.Empty);
                url_btn.Invoke(new SetText(delegate(string s)
                {
                    url_btn.Enabled = true;
                }), string.Empty);
            });
            thd.Start();
        }

        #region helper

        private Input GetInput()
        {
            var put = new Input();
            switch (this.blog_tabControl.SelectedIndex)
            {
                case 0:
                    put.Type = Type.Blog;
                    put.Text = tbUser.Text.Trim();
                    break;
                case 1:
                    put.Type = Type.Column;
                    put.Text = tbColumn.Text.Trim();
                    break;
                case 2:
                    put.Type = Type.Url;
                    put.Text = tbUrl.Text.Trim();
                    break;

            }

            if (put.Text == string.Empty)
            {
                string msg = string.Empty;
                if (put.Type == Type.Blog) msg = "博客用户名不能为空";
                else if (put.Type == Type.Url) msg = "博客URL不能为空";
                else if (put.Type == Type.Column) msg = "专栏别名不能为空";
                MessageBox.Show(msg);
                return put;
            }
            put.Format |= Format.HTML;

            FolderDialog fDialog = new FolderDialog();
            var re = fDialog.DisplayDialog();
            if (re != DialogResult.OK)
            {
                return put;
            }
            App.BaseDirectory = fDialog.Path + "\\";

            put.Status = true;

            return put;
        }

        private delegate void SetText(string text);
        private void SetLbText(string str)
        {
            str = "[" + DateTime.Now.ToString("HH:mm:ss") + "] " + str + "\n";

            if (logBox.InvokeRequired)
            {
                SetText st = new SetText(delegate(string text)
                {
                    logBox.AppendText(text);
                });
                logBox.Invoke(st, str);
            }
            else
            {
                logBox.AppendText(str);
            }
        }
        Regex reg_title = new Regex(@"<a name=""\d+"" href=""(.+?)"" target=""_blank"">.+?</a>", RegexOptions.Compiled);
        private string[] GetColumnUrls(string alias)
        {
            IList<string> urls = new List<string>();

            string url = "http://blog.csdn.net/column/details/" + alias + ".html?page={0}";
            int p = 0;
            WebUtility web = new WebUtility();
            web.Encode = Encoding.UTF8;
            for (int i = 1; p == 0 || i <= p; i++)
            {
                web.URL = string.Format(url, i);
                string html = web.Get();
                if (p == 0)
                {
                    var mp = Regex.Match(html, @"共(\d+)页");
                    if (mp.Success) p = App.ToInt(mp.Groups[1].Value);
                    else p = 1;
                }
                var mats = reg_title.Matches(html);
                if (mats.Count == 0) break;
                foreach (Match mat in mats)
                {
                    urls.Add(mat.Groups[1].Value);
                }
            }
            string[] ss = new string[urls.Count];
            for (int i = 0; i < urls.Count; i++)
            {
                ss[i] = urls[i];
            }
            return ss;
        }

        #endregion

        #region events
        private void blog_btn_Click(object sender, EventArgs e)
        {
            StartExport();
        }

        private void column_btn_Click(object sender, EventArgs e)
        {
            StartExport();
        }

        private void url_btn_Click(object sender, EventArgs e)
        {
            StartExport();
        }
        private void tbUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                StartExport();
            }
        }
        private void tbColumn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                StartExport();
            }
        }
        #endregion
    }
    public class Input
    {
        public Input()
        {
            Status = false;
        }
        public Type Type { get; set; }
        public string Text { get; set; }
        public Format Format { get; set; }
        public bool Status { get; set; }
    }
}
