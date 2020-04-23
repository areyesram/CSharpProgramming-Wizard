using System;
using System.Windows.Forms;
using areyesram.Steps;

namespace areyesram
{
    public partial class WizardForm : Form
    {
        private readonly StepPanel[] _steps = { new Intro(), new Step1(), new Step2(), new Outro() };
        private int _current;

        public WizardForm()
        {
            InitializeComponent();
        }

        private void WizardForm_Load(object sender, EventArgs e)
        {
            LoadStep();
        }

        private void cmdFinish_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (IsLastStep())
            {
                Util.ShowWarning("How did you get here?");
                return;
            }
            if (!_steps[_current].ValidateForm()) return;
            _current++;
            LoadStep();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (IsFirstStep())
            {
                Util.ShowWarning("How did you get here?");
                return;
            }
            _current--;
            LoadStep();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Util.Confirm("Are you sure you want to exit?"))
                Close();
        }

        private void LoadStep()
        {
            if (panelStep.Controls.Count != 0)
                panelStep.Controls.Clear();
            panelStep.Controls.Add(_steps[_current]);

            btnNext.Enabled = !IsLastStep();
            btnBack.Enabled = !IsFirstStep();
            btnFinish.Enabled = IsLastStep();
        }

        private bool IsFirstStep()
        {
            return _current == 0;
        }

        private bool IsLastStep()
        {
            return _current == _steps.Length - 1;
        }
    }
}
