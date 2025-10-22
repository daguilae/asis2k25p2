using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_MB
{
    public partial class Forms_MB : Form
    {
        public Forms_MB()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
            private void Forms_MB_Load(object sender, EventArgs e)
            {
                var bounds = Screen.FromControl(this).Bounds;
                this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
                this.WindowState = FormWindowState.Maximized;
            }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    }
