using System;
using System.Collections.Generic;
using System.Linq;

namespace areyesram.Steps
{
    public partial class Step2 : StepPanel
    {
        public Step2()
        {
            InitializeComponent();
        }

        public override bool ValidateForm()
        {
            var errors = new List<string>();
            if (dateTimeDOB.Value > DateTime.Now)
                errors.Add("Are you from the future? How is that even possible?");
            else if (Util.CalculateAge(dateTimeDOB.Value) < 13)
                errors.Add("Sorry, you have to be at least 13 to be here.");
            if (errors.Count == 0) return true;
            Util.ShowError(string.Join(Environment.NewLine, errors.Select(o => "* " + o)));
            return false;
        }
    }
}
