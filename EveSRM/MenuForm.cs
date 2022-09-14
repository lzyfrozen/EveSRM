namespace EveSRM
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void SRMDock_Click(object sender, EventArgs e)
        {
            SRMDockForm srmForm = GenericSingleton<SRMDockForm>.CreateInstrance();
            srmForm.Show();
        }
    }

    public class GenericSingleton<T> where T : Form, new()
    {
        private static T? t = null;
        public static T CreateInstrance()
        {
            if (t == null || t.IsDisposed)
            {
                t = new T();
            }
            else
            {
                t.Activate();
                t.WindowState = FormWindowState.Normal;
            }
            return t;
        }
    }
}