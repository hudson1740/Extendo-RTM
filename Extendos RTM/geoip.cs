using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extendos_RTM
{
    public partial class geoip : Form
    {
        private tool tool;

        public geoip()
        {
            InitializeComponent();
        }

        public geoip(tool tool)
        {
            this.tool = tool;
        }
    }
}
