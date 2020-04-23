using System.Windows.Forms;

namespace areyesram
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            new WizardForm().ShowDialog();
        }
    }
}
