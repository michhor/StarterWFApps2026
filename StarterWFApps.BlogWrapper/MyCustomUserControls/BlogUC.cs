using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarterWFApps.BlogWrapper.MyCustomUserControls
{
    public partial class BlogUC : UserControl
    {
        public string Author { get; set; }
        public BlogUC()
        {
            InitializeComponent();

            InitUser();
        }

        private void InitUser()
        {
            try
            {
                this.button1.Text = Properties.Settings.Default.ButtonText;
                
            } catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( !string.IsNullOrWhiteSpace( this.textBox1.Text))
            {
                StringBuilder sb = new StringBuilder();

                sb.Append(Author).Append(", ").Append(DateTime.Now).AppendLine(":")
                    .AppendLine(this.textBox1.Text);

                this.textBox2.Text = $"{sb.ToString()}{Environment.NewLine}{this.textBox2.Text}";

            }
        }
    }
}
