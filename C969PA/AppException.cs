﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace C969PA
{
    class AppException : ApplicationException
    {
        public void BusinessHours()
        {
            MessageBox.Show("Appointments cannot be placed outside of normal business house", "Error");
        }

        public void AppTimeConflict()
        {
            MessageBox.Show("This appointment conflicts with another appointment, please change appointment time.",
                "Error");
        }
    }
}
