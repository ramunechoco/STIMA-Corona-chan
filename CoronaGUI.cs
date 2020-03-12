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
using Coronachan;

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

        void CreateGraph(Vertex[] vertices, int T)
        {
            graphvertex gver = new graphvertex(vertices, T);
            gver.bfs();
            Graph graph = new Graph("graph");
            for (int i = 0; i < vertices.Length; i++)
            {
                List<Tuple<string,double>> list = new List<Tuple<string, double>>();
                list = gver.get_vertices()[i].get_adjlist();
                for (int k = 0; k < list.Count; k++)
                {
                    graph.AddEdge(gver.get_vertices()[i].get_name(), list[k].Item1);
                }
            }
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
                InitialDirectory = @"C:",
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
                InitialDirectory = @"C:",
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
            int value = (int) DayCounter.Value;
            string filemap = textBoxMap.Text.Replace(@"\", @"\\");
            string filepop = textBoxPop.Text.Replace(@"\", @"\\");
            string[][] mapfile = Helper.readFile(filemap);
            string[][] mappop = Helper.readFile(filepop);
            Vertex[] vertices = Helper.readGraph(mapfile, mappop);
            CreateGraph(vertices, value);
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

        private void CoronaGUIForm_Load(object sender, EventArgs e)
        {

        }
    }
}