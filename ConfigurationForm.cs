using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lutero
{
    public partial class ConfigurationForm : Form
    {
        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            this.txAccessor.Text = Properties.Settings.Default.Accessor;
            this.txCode.Text = Properties.Settings.Default.Code;
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Code = this.txCode.Text;
            Properties.Settings.Default.Accessor = this.txAccessor.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
