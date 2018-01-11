using GEV.UMP.Core.Data.Geometry;
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

            Vector3 v1 = new Vector3(0, 0, 0);
            Vector2 v2 = new Vector2(2, 2);

            Vector3 v = v2 + v1;
        }
    }
}
