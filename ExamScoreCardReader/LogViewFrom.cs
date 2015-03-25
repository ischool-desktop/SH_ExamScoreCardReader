using FISCA.Presentation.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SH_ExamScoreCardReader
{
    public partial class LogViewFrom : BaseForm
    {
        public LogViewFrom(string valu)
        {
            InitializeComponent();

            textBoxX1.Text = valu;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
