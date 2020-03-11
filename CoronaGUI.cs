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

namespace Corona_chan_GUI
{
    public partial class CoronaGUIForm : Form
    {
        public CoronaGUIForm()
        {
            InitializeComponent();
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

        private void CoronaImage_Click(object sender, EventArgs e)
        {
            Microsoft.Msagl.Drawing.Graph graph = new
Microsoft.Msagl.Drawing.Graph("");
            graph.AddEdge("A", "B");
            graph.AddEdge("A", "B");
            graph.FindNode("A").Attr.FillColor =
            Microsoft.Msagl.Drawing.Color.Red;
            graph.FindNode("B").Attr.FillColor =
            Microsoft.Msagl.Drawing.Color.Blue;
            Microsoft.Msagl.GraphViewerGdi.GraphRenderer renderer
            = new Microsoft.Msagl.GraphViewerGdi.GraphRenderer
            (graph);
            renderer.CalculateLayout();
            int width = 50;
            Bitmap bitmap = new Bitmap(width, (int)(graph.Height *
            (width / graph.Width)), PixelFormat.Format32bppPArgb);
            renderer.Render(bitmap);
            bitmap.Save("test.png");
            CoronaImage.Load("test.png");
        }
    }
}
