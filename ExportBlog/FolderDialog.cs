using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ExportBlog
{
    public class FolderDialog : FolderNameEditor, IDisposable
    {
        FolderBrowser fDialog = new FolderBrowser();

        public FolderDialog()
        {
        }

        public DialogResult DisplayDialog()
        {
            return DisplayDialog("导出博客到...");
        }
        public DialogResult DisplayDialog(string description)
        {
            fDialog.Description = description;
            return fDialog.ShowDialog();
        }
        public string Path
        {
            get { return fDialog.DirectoryPath; }
        }
        ~FolderDialog()
        {
            // Finalizer calls Dispose(false)
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (fDialog != null)
                {
                    fDialog.Dispose();
                    fDialog = null;
                }
            }
        }

    }
}
