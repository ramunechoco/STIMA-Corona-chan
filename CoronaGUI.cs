using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Microsoft.Msagl.Core.Geometry.Curves;
using Microsoft.Msagl.Core.Routing;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using Microsoft.Msagl.Layout.Layered;
using Microsoft.Msagl.Layout.MDS;
using Color = Microsoft.Msagl.Drawing.Color;
using Label = Microsoft.Msagl.Drawing.Label;
using MouseButtons = System.Windows.Forms.MouseButtons;

namespace Corona_chan_GUI
{
    public partial class CoronaGUIForm : Form
    {
        public CoronaGUIForm()
        {
            InitializeComponent();
            Microsoft.Msagl.GraphViewerGdi.GViewer gViewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            gViewer.AsyncLayout = true;
        }

        private void uploadmap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileMap = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileMap.ShowDialog() == DialogResult.OK)
            {
                textBoxMap.Text = openFileMap.FileName;
            }
        }

        private void uploadpop_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFilePop = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFilePop.ShowDialog() == DialogResult.OK)
            {
                textBoxPop.Text = openFilePop.FileName;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMap_TextChanged(object sender, EventArgs e)
        {


        }

        private void Calculator_Click(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}