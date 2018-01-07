using GEV.UMP.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleExecutable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ControlNode controlNode = new ControlNode(null);
            controlNode.StartComputeNodes();
        }
    }
}
