using System.Windows.Forms;

namespace areyesram.Steps
{
    public partial class StepPanel : UserControl
    {
        public StepPanel()
        {
            InitializeComponent();
        }

        public virtual bool ValidateForm()
        {
            return true;
        }
    }
}
