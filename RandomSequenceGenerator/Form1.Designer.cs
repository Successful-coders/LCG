namespace RandomSequenceGenerator
{
    partial class Form1
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
            this.infoBox = new System.Windows.Forms.TextBox();
            this.readDataButton = new System.Windows.Forms.Button();
            this.MixedCgButton = new System.Windows.Forms.Button();
            this.MultiCgButton = new System.Windows.Forms.Button();
            this.openData = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(13, 13);
            this.infoBox.Multiline = true;
            this.infoBox.Name = "infoBox";
            this.infoBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoBox.Size = new System.Drawing.Size(460, 139);
            this.infoBox.TabIndex = 0;
            // 
            // readDataButton
            // 
            this.readDataButton.Location = new System.Drawing.Point(13, 158);
            this.readDataButton.Name = "readDataButton";
            this.readDataButton.Size = new System.Drawing.Size(147, 35);
            this.readDataButton.TabIndex = 1;
            this.readDataButton.Text = "Считать данные";
            this.readDataButton.UseVisualStyleBackColor = true;
            this.readDataButton.Click += new System.EventHandler(this.readDataButton_Click);
            // 
            // MixedCgButton
            // 
            this.MixedCgButton.Location = new System.Drawing.Point(387, 158);
            this.MixedCgButton.Name = "MixedCgButton";
            this.MixedCgButton.Size = new System.Drawing.Size(86, 35);
            this.MixedCgButton.TabIndex = 3;
            this.MixedCgButton.Text = "СКГ";
            this.MixedCgButton.UseVisualStyleBackColor = true;
            this.MixedCgButton.Click += new System.EventHandler(this.MixedCgButton_Click);
            // 
            // MultiCgButton
            // 
            this.MultiCgButton.Location = new System.Drawing.Point(295, 158);
            this.MultiCgButton.Name = "MultiCgButton";
            this.MultiCgButton.Size = new System.Drawing.Size(86, 35);
            this.MultiCgButton.TabIndex = 2;
            this.MultiCgButton.Text = "МКГ";
            this.MultiCgButton.UseVisualStyleBackColor = true;
            this.MultiCgButton.Click += new System.EventHandler(this.MultiCgButton_Click);
            // 
            // openData
            // 
            this.openData.FileName = "data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 205);
            this.Controls.Add(this.MultiCgButton);
            this.Controls.Add(this.MixedCgButton);
            this.Controls.Add(this.readDataButton);
            this.Controls.Add(this.infoBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox infoBox;
        private System.Windows.Forms.Button readDataButton;
        private System.Windows.Forms.Button MixedCgButton;
        private System.Windows.Forms.Button MultiCgButton;
        private System.Windows.Forms.OpenFileDialog openData;
    }
}

