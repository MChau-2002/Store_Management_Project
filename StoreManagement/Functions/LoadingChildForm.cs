using System.Windows.Forms;

namespace StoreManagement.Functions
{
    class LoadingChildForm
    {
        private static LoadingChildForm instance;

        public static LoadingChildForm Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoadingChildForm();
                return instance;
            }
        }

        public void OpenChildForm(object Form,Panel pnl)
        {
            if (pnl.Controls.Count > 0)
            {
                // Dong childform hien tai
                Form CurrentChildForm = pnl.Controls[0] as Form;
                CurrentChildForm.Close();
            }

            Form NewChildForm = Form as Form;
            NewChildForm.TopLevel = false;
            NewChildForm.FormBorderStyle = FormBorderStyle.None;
            NewChildForm.Dock = DockStyle.Fill;
            pnl.Controls.Add(NewChildForm);
            pnl.Tag = NewChildForm;
            NewChildForm.BringToFront();
            NewChildForm.Show();
        }
    }
}
