namespace Corona_chan_GUI
{
    partial class CoronaGUIForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation planeTransformation1 = new Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation();
            this.uploadmap = new System.Windows.Forms.Button();
            this.textBoxPop = new System.Windows.Forms.TextBox();
            this.uploadpop = new System.Windows.Forms.Button();
            this.textBoxMap = new System.Windows.Forms.TextBox();
            this.Calculator = new System.Windows.Forms.Button();
            this.DayCounter = new System.Windows.Forms.NumericUpDown();
            this.DayCounterLabel = new System.Windows.Forms.Label();
            this.LargeLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.smallLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.smallerLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.gViewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DayCounter)).BeginInit();
            this.LargeLayoutTable.SuspendLayout();
            this.smallLayoutTable.SuspendLayout();
            this.smallerLayoutTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // uploadmap
            // 
            this.uploadmap.Location = new System.Drawing.Point(642, 3);
            this.uploadmap.Name = "uploadmap";
            this.uploadmap.Size = new System.Drawing.Size(161, 32);
            this.uploadmap.TabIndex = 0;
            this.uploadmap.Text = "Upload map file...";
            this.uploadmap.UseVisualStyleBackColor = true;
            this.uploadmap.Click += new System.EventHandler(this.uploadmap_Click);
            // 
            // textBoxPop
            // 
            this.textBoxPop.Location = new System.Drawing.Point(3, 41);
            this.textBoxPop.Name = "textBoxPop";
            this.textBoxPop.ReadOnly = true;
            this.textBoxPop.Size = new System.Drawing.Size(633, 26);
            this.textBoxPop.TabIndex = 3;
            this.textBoxPop.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // uploadpop
            // 
            this.uploadpop.Location = new System.Drawing.Point(642, 41);
            this.uploadpop.Name = "uploadpop";
            this.uploadpop.Size = new System.Drawing.Size(161, 32);
            this.uploadpop.TabIndex = 1;
            this.uploadpop.Text = "Upload pop file...";
            this.uploadpop.UseVisualStyleBackColor = true;
            this.uploadpop.Click += new System.EventHandler(this.uploadpop_Click);
            // 
            // textBoxMap
            // 
            this.textBoxMap.Location = new System.Drawing.Point(3, 3);
            this.textBoxMap.Name = "textBoxMap";
            this.textBoxMap.ReadOnly = true;
            this.textBoxMap.Size = new System.Drawing.Size(633, 26);
            this.textBoxMap.TabIndex = 2;
            this.textBoxMap.TextChanged += new System.EventHandler(this.textBoxMap_TextChanged);
            // 
            // Calculator
            // 
            this.Calculator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Calculator.Location = new System.Drawing.Point(817, 386);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(155, 81);
            this.Calculator.TabIndex = 4;
            this.Calculator.Text = "Calculate!";
            this.Calculator.UseVisualStyleBackColor = true;
            this.Calculator.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // DayCounter
            // 
            this.DayCounter.Location = new System.Drawing.Point(3, 54);
            this.DayCounter.Name = "DayCounter";
            this.DayCounter.Size = new System.Drawing.Size(149, 26);
            this.DayCounter.TabIndex = 5;
            // 
            // DayCounterLabel
            // 
            this.DayCounterLabel.AutoSize = true;
            this.DayCounterLabel.Location = new System.Drawing.Point(3, 0);
            this.DayCounterLabel.Name = "DayCounterLabel";
            this.DayCounterLabel.Size = new System.Drawing.Size(145, 20);
            this.DayCounterLabel.TabIndex = 6;
            this.DayCounterLabel.Text = "Day since outbreak";
            // 
            // LargeLayoutTable
            // 
            this.LargeLayoutTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LargeLayoutTable.ColumnCount = 2;
            this.LargeLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.5729F));
            this.LargeLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.4271F));
            this.LargeLayoutTable.Controls.Add(this.smallLayoutTable, 1, 0);
            this.LargeLayoutTable.Controls.Add(this.smallerLayoutTable, 0, 1);
            this.LargeLayoutTable.Controls.Add(this.Calculator, 1, 1);
            this.LargeLayoutTable.Controls.Add(this.gViewer, 0, 0);
            this.LargeLayoutTable.Location = new System.Drawing.Point(0, 0);
            this.LargeLayoutTable.Name = "LargeLayoutTable";
            this.LargeLayoutTable.RowCount = 2;
            this.LargeLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.63717F));
            this.LargeLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.36283F));
            this.LargeLayoutTable.Size = new System.Drawing.Size(975, 470);
            this.LargeLayoutTable.TabIndex = 7;
            this.LargeLayoutTable.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // smallLayoutTable
            // 
            this.smallLayoutTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smallLayoutTable.ColumnCount = 1;
            this.smallLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.smallLayoutTable.Controls.Add(this.DayCounter, 0, 1);
            this.smallLayoutTable.Controls.Add(this.DayCounterLabel, 0, 0);
            this.smallLayoutTable.Location = new System.Drawing.Point(817, 3);
            this.smallLayoutTable.Name = "smallLayoutTable";
            this.smallLayoutTable.RowCount = 2;
            this.smallLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.60947F));
            this.smallLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.39053F));
            this.smallLayoutTable.Size = new System.Drawing.Size(155, 377);
            this.smallLayoutTable.TabIndex = 8;
            // 
            // smallerLayoutTable
            // 
            this.smallerLayoutTable.ColumnCount = 2;
            this.smallerLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.08416F));
            this.smallerLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.91584F));
            this.smallerLayoutTable.Controls.Add(this.textBoxMap, 0, 0);
            this.smallerLayoutTable.Controls.Add(this.uploadpop, 1, 1);
            this.smallerLayoutTable.Controls.Add(this.uploadmap, 1, 0);
            this.smallerLayoutTable.Controls.Add(this.textBoxPop, 0, 1);
            this.smallerLayoutTable.Location = new System.Drawing.Point(3, 386);
            this.smallerLayoutTable.Name = "smallerLayoutTable";
            this.smallerLayoutTable.RowCount = 2;
            this.smallerLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.smallerLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.smallerLayoutTable.Size = new System.Drawing.Size(808, 77);
            this.smallerLayoutTable.TabIndex = 8;
            this.smallerLayoutTable.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // gViewer
            // 
            this.gViewer.ArrowheadLength = 10D;
            this.gViewer.AsyncLayout = false;
            this.gViewer.AutoScroll = true;
            this.gViewer.BackwardEnabled = false;
            this.gViewer.BuildHitTree = true;
            this.gViewer.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.gViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gViewer.EdgeInsertButtonVisible = true;
            this.gViewer.FileName = "";
            this.gViewer.ForwardEnabled = false;
            this.gViewer.Graph = null;
            this.gViewer.InsertingEdge = false;
            this.gViewer.LayoutAlgorithmSettingsButtonVisible = true;
            this.gViewer.LayoutEditingEnabled = true;
            this.gViewer.Location = new System.Drawing.Point(3, 3);
            this.gViewer.LooseOffsetForRouting = 0.25D;
            this.gViewer.MouseHitDistance = 0.05D;
            this.gViewer.Name = "gViewer";
            this.gViewer.NavigationVisible = true;
            this.gViewer.NeedToCalculateLayout = true;
            this.gViewer.OffsetForRelaxingInRouting = 0.6D;
            this.gViewer.PaddingForEdgeRouting = 8D;
            this.gViewer.PanButtonPressed = false;
            this.gViewer.SaveAsImageEnabled = true;
            this.gViewer.SaveAsMsaglEnabled = true;
            this.gViewer.SaveButtonVisible = true;
            this.gViewer.SaveGraphButtonVisible = true;
            this.gViewer.SaveInVectorFormatEnabled = true;
            this.gViewer.Size = new System.Drawing.Size(808, 377);
            this.gViewer.TabIndex = 3;
            this.gViewer.TightOffsetForRouting = 0.125D;
            this.gViewer.ToolBarIsVisible = true;
            this.gViewer.Transform = planeTransformation1;
            this.gViewer.UndoRedoButtonsVisible = true;
            this.gViewer.WindowZoomButtonPressed = false;
            this.gViewer.ZoomF = 1D;
            this.gViewer.ZoomWindowThreshold = 0.05D;
            // 
            // CoronaGUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 468);
            this.Controls.Add(this.LargeLayoutTable);
            this.Name = "CoronaGUIForm";
            this.Text = "Corona-chan Simulation Project 発生プロジェクト";
            this.Load += new System.EventHandler(this.CoronaGUIForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DayCounter)).EndInit();
            this.LargeLayoutTable.ResumeLayout(false);
            this.smallLayoutTable.ResumeLayout(false);
            this.smallLayoutTable.PerformLayout();
            this.smallerLayoutTable.ResumeLayout(false);
            this.smallerLayoutTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uploadmap;
        private System.Windows.Forms.TextBox textBoxPop;
        private System.Windows.Forms.Button uploadpop;
        private System.Windows.Forms.TextBox textBoxMap;
        private System.Windows.Forms.Button Calculator;
        private System.Windows.Forms.NumericUpDown DayCounter;
        private System.Windows.Forms.Label DayCounterLabel;
        private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer;
        private System.Windows.Forms.TableLayoutPanel LargeLayoutTable;
        private System.Windows.Forms.TableLayoutPanel smallerLayoutTable;
        private System.Windows.Forms.TableLayoutPanel smallLayoutTable;
    }
}