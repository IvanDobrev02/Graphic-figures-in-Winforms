namespace OOP_proekt
{
    partial class FormSaveImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSaveImage));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSaveImage = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.radioButtonImage = new System.Windows.Forms.RadioButton();
            this.radioButtonWorkFile = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File\'s name:";
            // 
            // textBoxSaveImage
            // 
            this.textBoxSaveImage.Location = new System.Drawing.Point(3, 85);
            this.textBoxSaveImage.Name = "textBoxSaveImage";
            this.textBoxSaveImage.Size = new System.Drawing.Size(235, 20);
            this.textBoxSaveImage.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Location = new System.Drawing.Point(82, 111);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Location = new System.Drawing.Point(163, 111);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.Button2_Click);
            // 
            // radioButtonImage
            // 
            this.radioButtonImage.AutoSize = true;
            this.radioButtonImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonImage.Location = new System.Drawing.Point(3, 31);
            this.radioButtonImage.Name = "radioButtonImage";
            this.radioButtonImage.Size = new System.Drawing.Size(54, 17);
            this.radioButtonImage.TabIndex = 4;
            this.radioButtonImage.TabStop = true;
            this.radioButtonImage.Text = "Image";
            this.radioButtonImage.UseVisualStyleBackColor = true;
            // 
            // radioButtonWorkFile
            // 
            this.radioButtonWorkFile.AutoSize = true;
            this.radioButtonWorkFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonWorkFile.Location = new System.Drawing.Point(63, 31);
            this.radioButtonWorkFile.Name = "radioButtonWorkFile";
            this.radioButtonWorkFile.Size = new System.Drawing.Size(67, 17);
            this.radioButtonWorkFile.TabIndex = 5;
            this.radioButtonWorkFile.TabStop = true;
            this.radioButtonWorkFile.Text = "WorkFile";
            this.radioButtonWorkFile.UseVisualStyleBackColor = true;
            this.radioButtonWorkFile.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "File\'s type:";
            // 
            // FormSaveImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 146);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonWorkFile);
            this.Controls.Add(this.radioButtonImage);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxSaveImage);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSaveImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSaveImage;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.RadioButton radioButtonImage;
        private System.Windows.Forms.RadioButton radioButtonWorkFile;
        private System.Windows.Forms.Label label2;
    }
}