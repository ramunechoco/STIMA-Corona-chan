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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoronaGUIForm));
            this.uploadmap = new System.Windows.Forms.Button();
            this.uploadpop = new System.Windows.Forms.Button();
            this.textBoxMap = new System.Windows.Forms.TextBox();
            this.textBoxPop = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.CoronaImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoronaImage)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadmap
            // 
            this.uploadmap.Location = new System.Drawing.Point(602, 368);
            this.uploadmap.Name = "uploadmap";
            this.uploadmap.Size = new System.Drawing.Size(161, 32);
            this.uploadmap.TabIndex = 0;
            this.uploadmap.Text = "Upload map file...";
            this.uploadmap.UseVisualStyleBackColor = true;
            this.uploadmap.Click += new System.EventHandler(this.uploadmap_Click);
            // 
            // uploadpop
            // 
            this.uploadpop.Location = new System.Drawing.Point(602, 406);
            this.uploadpop.Name = "uploadpop";
            this.uploadpop.Size = new System.Drawing.Size(161, 32);
            this.uploadpop.TabIndex = 1;
            this.uploadpop.Text = "Upload pop file...";
            this.uploadpop.UseVisualStyleBackColor = true;
            this.uploadpop.Click += new System.EventHandler(this.uploadpop_Click);
            // 
            // textBoxMap
            // 
            this.textBoxMap.Location = new System.Drawing.Point(12, 371);
            this.textBoxMap.Name = "textBoxMap";
            this.textBoxMap.ReadOnly = true;
            this.textBoxMap.Size = new System.Drawing.Size(573, 26);
            this.textBoxMap.TabIndex = 2;
            this.textBoxMap.TextChanged += new System.EventHandler(this.textBoxMap_TextChanged);
            // 
            // textBoxPop
            // 
            this.textBoxPop.Location = new System.Drawing.Point(12, 409);
            this.textBoxPop.Name = "textBoxPop";
            this.textBoxPop.ReadOnly = true;
            this.textBoxPop.Size = new System.Drawing.Size(573, 26);
            this.textBoxPop.TabIndex = 3;
            this.textBoxPop.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(602, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(161, 26);
            this.numericUpDown1.TabIndex = 5;
            // 
            // CoronaImage
            // 
            this.CoronaImage.Location = new System.Drawing.Point(12, 44);
            this.CoronaImage.Name = "CoronaImage";
            this.CoronaImage.Size = new System.Drawing.Size(751, 321);
            this.CoronaImage.TabIndex = 6;
            this.CoronaImage.TabStop = false;
            this.CoronaImage.Click += new System.EventHandler(this.CoronaImage_Click);
            // 
            // CoronaGUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CoronaImage);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBoxMap);
            this.Controls.Add(this.textBoxPop);
            this.Controls.Add(this.uploadpop);
            this.Controls.Add(this.uploadmap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CoronaGUIForm";
            this.Text = "Corona-chan Simulation Project 発生プロジェクト";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoronaImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadmap;
        private System.Windows.Forms.Button uploadpop;
        private System.Windows.Forms.TextBox textBoxMap;
        private System.Windows.Forms.TextBox textBoxPop;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox CoronaImage;
    }
}

