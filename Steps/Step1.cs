using System;
using System.Collections.Generic;
using System.Linq;

namespace areyesram.Steps
{
    public partial class Step1 : StepPanel
    {
        public Step1()
        {
            InitializeComponent();
        }

        public override bool ValidateForm()
        {
            var errors = new List<string>();
            if (string.IsNullOrWhiteSpace(txtName.Text))
                errors.Add("Please enter your name.");
            if (errors.Count == 0) return true;
            Util.ShowError(string.Join(Environment.NewLine, errors.Select(o => "* " + o)));
            return false;
        }
    }
}
