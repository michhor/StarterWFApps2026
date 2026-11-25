using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarterWFApps.UselessBox.MyForms
{
    public partial class UselessBoxForm : Form
    {
        public UselessBoxForm()
        {
            InitializeComponent();
            InitUser();
        }

        private void InitUser()
        {
            this.Text = Properties.Settings.Default.TitleApp;
            this.button1.Text = Properties.Settings.Default.ButtonCaption;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy jesteś pewien że chcesz zamknąć aplikację?",
                "Ważne pytanie",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if( result == DialogResult.Yes )
                Application.Exit();
        }
    }
}
