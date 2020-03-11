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
            this.uploadmap = new System.Windows.Forms.Button();
            this.textBoxPop = new System.Windows.Forms.TextBox();
            this.uploadpop = new System.Windows.Forms.Button();
            this.textBoxMap = new System.Windows.Forms.TextBox();
            this.Calculator = new System.Windows.Forms.Button();
            this.DayCounter = new System.Windows.Forms.NumericUpDown();
            this.DayCounterLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DayCounter)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uploadmap
            // 
            this.uploadmap.Location = new System.Drawing.Point(550, 3);
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
            this.textBoxPop.Size = new System.Drawing.Size(541, 26);
            this.textBoxPop.TabIndex = 3;
            this.textBoxPop.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // uploadpop
            // 
            this.uploadpop.Location = new System.Drawing.Point(550, 41);
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
            this.textBoxMap.Size = new System.Drawing.Size(541, 26);
            this.textBoxMap.TabIndex = 2;
            this.textBoxMap.TextChanged += new System.EventHandler(this.textBoxMap_TextChanged);
            // 
            // Calculator
            // 
            this.Calculator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Calculator.Location = new System.Drawing.Point(829, 379);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(143, 70);
            this.Calculator.TabIndex = 4;
            this.Calculator.Text = "Calculate!";
            this.Calculator.UseVisualStyleBackColor = true;
            this.Calculator.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // DayCounter
            // 
            this.DayCounter.Location = new System.Drawing.Point(3, 87);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.5729F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.4271F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Calculator, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.63717F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.36283F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(975, 452);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.80186F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.19814F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxMap, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.uploadpop, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.uploadmap, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxPop, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 372);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(808, 77);
            this.tableLayoutPanel2.TabIndex = 8;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.DayCounter, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.DayCounterLabel, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(817, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(155, 169);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // CoronaGUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CoronaGUIForm";
            this.Text = "Corona-chan Simulation Project 発生プロジェクト";
            ((System.ComponentModel.ISupportInitialize)(this.DayCounter)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}