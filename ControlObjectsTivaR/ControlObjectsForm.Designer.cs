namespace ControlObjectsTivaR
{
    partial class frmControlObjects
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
            this.lblText = new System.Windows.Forms.Label();
            this.btnChangeColour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(128, 114);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(77, 13);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Change Colour";
            // 
            // btnChangeColour
            // 
            this.btnChangeColour.Location = new System.Drawing.Point(119, 65);
            this.btnChangeColour.Name = "btnChangeColour";
            this.btnChangeColour.Size = new System.Drawing.Size(95, 23);
            this.btnChangeColour.TabIndex = 1;
            this.btnChangeColour.Text = "Change Colour";
            this.btnChangeColour.UseVisualStyleBackColor = true;
            this.btnChangeColour.Click += new System.EventHandler(this.btnChangeColour_Click);
            // 
            // frmControlObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 255);
            this.Controls.Add(this.btnChangeColour);
            this.Controls.Add(this.lblText);
            this.Name = "frmControlObjects";
            this.Text = "Control Objects By Tiva Rait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnChangeColour;
    }
}

