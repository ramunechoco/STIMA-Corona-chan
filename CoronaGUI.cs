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
        readonly ToolTip toolTip1 = new ToolTip();
        public CoronaGUIForm()
        {
            InitializeComponent();
            gViewer.AsyncLayout = true;
            toolTip1.Active = true;
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
        }

        void CreateGraph()
        {
            Graph graph = new Graph("graph");
            gViewer.BackColor = System.Drawing.Color.FromArgb(10, System.Drawing.Color.Red);
            graph.AddEdge("1", "2");
            graph.AddEdge("1", "3");
            var e = graph.AddEdge("4", "5");
            e.Attr.Color = Color.Red;
            e.Attr.LineWidth *= 2;
            graph.LayerConstraints.AddUpDownVerticalConstraint(graph.FindNode("4"), graph.FindNode("5"));
            //StraightenEdge(e, graph);
            e = graph.AddEdge("4", "6");
            e.LabelText = "Changing label";
            //labelToChange = e.Label;
            e = graph.AddEdge("7", "8");
            e.Attr.LineWidth *= 2;
            e.Attr.Color = Color.Red;
            //StraightenEdge(e, graph);
            graph.AddEdge("7", "9");
            e = graph.AddEdge("5", "7");
            e.Attr.Color = Color.Red;
            e.Attr.LineWidth *= 2;
            //StraightenEdge(e, graph);

            graph.AddEdge("2", "7");
            graph.AddEdge("10", "11");
            graph.AddEdge("10", "12");
            graph.AddEdge("2", "10");
            graph.AddEdge("8", "10");
            graph.AddEdge("5", "10");
            graph.AddEdge("13", "14");
            graph.AddEdge("13", "15");
            graph.AddEdge("8", "13");
            graph.AddEdge("2", "13");
            graph.AddEdge("5", "13");
            graph.AddEdge("16", "17");
            graph.AddEdge("16", "18");
            graph.AddEdge("19", "20");
            graph.AddEdge("19", "21");
            graph.AddEdge("17", "19");
            graph.AddEdge("2", "19");
            graph.AddEdge("22", "23");

            e = graph.AddEdge("22", "24");
            e.Attr.Color = Color.Red;
            e.Attr.LineWidth *= 2;
            //StraightenEdge(e, graph);

            e = graph.AddEdge("8", "22");
            e.Attr.Color = Color.Red;
            e.Attr.LineWidth *= 2;
            //StraightenEdge(e, graph);
            graph.AddEdge("20", "22");
            graph.AddEdge("25", "26");
            graph.AddEdge("25", "27");
            graph.AddEdge("20", "25");
            graph.AddEdge("28", "29");
            graph.AddEdge("28", "30");
            graph.AddEdge("31", "32");
            graph.AddEdge("31", "33");
            graph.AddEdge("5", "31");
            graph.AddEdge("8", "31");
            graph.AddEdge("2", "31");
            graph.AddEdge("20", "31");
            graph.AddEdge("17", "31");
            graph.AddEdge("29", "31");
            graph.AddEdge("34", "35");
            graph.AddEdge("34", "36");
            graph.AddEdge("20", "34");
            graph.AddEdge("29", "34");
            graph.AddEdge("5", "34");
            graph.AddEdge("2", "34");
            graph.AddEdge("8", "34");
            graph.AddEdge("17", "34");
            graph.AddEdge("37", "38");
            graph.AddEdge("37", "39");
            graph.AddEdge("29", "37");
            graph.AddEdge("5", "37");
            graph.AddEdge("20", "37");
            graph.AddEdge("8", "37");
            graph.AddEdge("2", "37");
            graph.AddEdge("40", "41");
            graph.AddEdge("40", "42");
            graph.AddEdge("17", "40");
            graph.AddEdge("2", "40");
            graph.AddEdge("8", "40");
            graph.AddEdge("5", "40");
            graph.AddEdge("20", "40");
            graph.AddEdge("29", "40");
            graph.AddEdge("43", "44");
            graph.AddEdge("43", "45");
            graph.AddEdge("8", "43");
            graph.AddEdge("2", "43");
            graph.AddEdge("20", "43");
            graph.AddEdge("17", "43");
            graph.AddEdge("5", "43");
            graph.AddEdge("29", "43");
            graph.AddEdge("46", "47");
            graph.AddEdge("46", "48");
            graph.AddEdge("29", "46");
            graph.AddEdge("5", "46");
            graph.AddEdge("17", "46");
            graph.AddEdge("49", "50");
            graph.AddEdge("49", "51");
            graph.AddEdge("5", "49");
            graph.AddEdge("2", "49");
            graph.AddEdge("52", "53");
            graph.AddEdge("52", "54");
            graph.AddEdge("17", "52");
            graph.AddEdge("20", "52");
            graph.AddEdge("2", "52");
            graph.AddEdge("50", "52");
            graph.AddEdge("55", "56");
            graph.AddEdge("55", "57");
            graph.AddEdge("58", "59");
            graph.AddEdge("58", "60");
            graph.AddEdge("20", "58");
            graph.AddEdge("29", "58");
            graph.AddEdge("5", "58");
            graph.AddEdge("47", "58");

            //ChangeNodeSizes(graph);

            //var sls = graph.LayoutAlgorithmSettings as SugiyamaLayoutSettings;
            //if (sls != null)
            //{
            //    sls.GridSizeByX = 30;
            //    // sls.GridSizeByY = 0;
            //}
            //layout the graph and draw it
            gViewer.Graph = graph;
            //this.propertyGrid1.SelectedObject = graph;
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
            decimal value = DayCounter.Value;
            string filemap = textBoxMap.Text;
            string filepop = textBoxPop.Text;
            CreateGraph();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}