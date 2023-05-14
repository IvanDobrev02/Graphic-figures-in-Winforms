
namespace OOP_proekt
{
    partial class FormScene
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScene));
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonSquare = new System.Windows.Forms.RadioButton();
            this.radioButtonTriangle = new System.Windows.Forms.RadioButton();
            this.radioButtonCircle = new System.Windows.Forms.RadioButton();
            this.buttonCanvasSettings = new System.Windows.Forms.Button();
            this.statusStripSurface = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStripSurface.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.AutoSize = true;
            this.radioButtonRectangle.Checked = true;
            this.radioButtonRectangle.Location = new System.Drawing.Point(123, 5);
            this.radioButtonRectangle.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(87, 19);
            this.radioButtonRectangle.TabIndex = 0;
            this.radioButtonRectangle.TabStop = true;
            this.radioButtonRectangle.Text = "Rectangle";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            // 
            // radioButtonSquare
            // 
            this.radioButtonSquare.AutoSize = true;
            this.radioButtonSquare.Location = new System.Drawing.Point(224, 5);
            this.radioButtonSquare.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonSquare.Name = "radioButtonSquare";
            this.radioButtonSquare.Size = new System.Drawing.Size(68, 19);
            this.radioButtonSquare.TabIndex = 1;
            this.radioButtonSquare.Text = "Square";
            this.radioButtonSquare.UseVisualStyleBackColor = true;
            // 
            // radioButtonTriangle
            // 
            this.radioButtonTriangle.AutoSize = true;
            this.radioButtonTriangle.Location = new System.Drawing.Point(304, 5);
            this.radioButtonTriangle.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTriangle.Name = "radioButtonTriangle";
            this.radioButtonTriangle.Size = new System.Drawing.Size(79, 19);
            this.radioButtonTriangle.TabIndex = 2;
            this.radioButtonTriangle.Text = "Triangle";
            this.radioButtonTriangle.UseVisualStyleBackColor = true;
            // 
            // radioButtonCircle
            // 
            this.radioButtonCircle.AutoSize = true;
            this.radioButtonCircle.Location = new System.Drawing.Point(387, 5);
            this.radioButtonCircle.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonCircle.Name = "radioButtonCircle";
            this.radioButtonCircle.Size = new System.Drawing.Size(60, 19);
            this.radioButtonCircle.TabIndex = 3;
            this.radioButtonCircle.Text = "Circle";
            this.radioButtonCircle.UseVisualStyleBackColor = true;
            // 
            // buttonCanvasSettings
            // 
            this.buttonCanvasSettings.Location = new System.Drawing.Point(0, -1);
            this.buttonCanvasSettings.Name = "buttonCanvasSettings";
            this.buttonCanvasSettings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonCanvasSettings.Size = new System.Drawing.Size(117, 27);
            this.buttonCanvasSettings.TabIndex = 4;
            this.buttonCanvasSettings.Text = "Canvas Settings";
            this.buttonCanvasSettings.UseVisualStyleBackColor = true;
            this.buttonCanvasSettings.Click += new System.EventHandler(this.canvasSettings_Click);
            // 
            // statusStripSurface
            // 
            this.statusStripSurface.BackColor = System.Drawing.Color.Transparent;
            this.statusStripSurface.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStripSurface.Location = new System.Drawing.Point(0, 516);
            this.statusStripSurface.Name = "statusStripSurface";
            this.statusStripSurface.Padding = new System.Windows.Forms.Padding(2, 0, 16, 0);
            this.statusStripSurface.Size = new System.Drawing.Size(828, 22);
            this.statusStripSurface.TabIndex = 5;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 29);
            this.panel1.TabIndex = 6;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(699, 5);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(117, 23);
            this.buttonOpen.TabIndex = 7;
            this.buttonOpen.Text = "Open file";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 501);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 37);
            this.panel2.TabIndex = 8;
            // 
            // FormScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(828, 538);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonCanvasSettings);
            this.Controls.Add(this.radioButtonCircle);
            this.Controls.Add(this.radioButtonTriangle);
            this.Controls.Add(this.radioButtonSquare);
            this.Controls.Add(this.radioButtonRectangle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStripSurface);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormScene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Canvas";
            this.SizeChanged += new System.EventHandler(this.FormScene_SizeChanged);
            this.DoubleClick += new System.EventHandler(this.FormScene_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormScene_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseUp);
            this.statusStripSurface.ResumeLayout(false);
            this.statusStripSurface.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.RadioButton radioButtonSquare;
        private System.Windows.Forms.RadioButton radioButtonTriangle;
        private System.Windows.Forms.RadioButton radioButtonCircle;
        private System.Windows.Forms.Button buttonCanvasSettings;
        private System.Windows.Forms.StatusStrip statusStripSurface;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Panel panel2;
    }
}

