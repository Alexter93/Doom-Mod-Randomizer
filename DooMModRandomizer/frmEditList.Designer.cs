namespace WindowsFormsApplication1
{
    partial class frmEditList
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
            this.cboMods = new System.Windows.Forms.ComboBox();
            this.lblEditIntructions = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboMods
            // 
            this.cboMods.FormattingEnabled = true;
            this.cboMods.Location = new System.Drawing.Point(15, 29);
            this.cboMods.Name = "cboMods";
            this.cboMods.Size = new System.Drawing.Size(121, 24);
            this.cboMods.TabIndex = 0;
            // 
            // lblEditIntructions
            // 
            this.lblEditIntructions.AutoSize = true;
            this.lblEditIntructions.Location = new System.Drawing.Point(12, 9);
            this.lblEditIntructions.Name = "lblEditIntructions";
            this.lblEditIntructions.Size = new System.Drawing.Size(244, 17);
            this.lblEditIntructions.TabIndex = 1;
            this.lblEditIntructions.Text = "Select a Mod to Remove from the List";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(181, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmEditList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 99);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblEditIntructions);
            this.Controls.Add(this.cboMods);
            this.Name = "frmEditList";
            this.Text = "frmEditList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMods;
        private System.Windows.Forms.Label lblEditIntructions;
        private System.Windows.Forms.Button btnDelete;
    }
}