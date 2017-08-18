namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstMods = new System.Windows.Forms.ListBox();
            this.grpMods = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.grpMods.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(282, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "DooM";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(282, 199);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 42);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Mod";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstMods
            // 
            this.lstMods.FormattingEnabled = true;
            this.lstMods.ItemHeight = 16;
            this.lstMods.Location = new System.Drawing.Point(6, 21);
            this.lstMods.Name = "lstMods";
            this.lstMods.ScrollAlwaysVisible = true;
            this.lstMods.Size = new System.Drawing.Size(236, 196);
            this.lstMods.TabIndex = 2;
            // 
            // grpMods
            // 
            this.grpMods.Controls.Add(this.lstMods);
            this.grpMods.Location = new System.Drawing.Point(12, 12);
            this.grpMods.Name = "grpMods";
            this.grpMods.Size = new System.Drawing.Size(248, 229);
            this.grpMods.TabIndex = 3;
            this.grpMods.TabStop = false;
            this.grpMods.Text = "Mods";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(282, 151);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 42);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit Mod List";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 253);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.grpMods);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPlay);
            this.Name = "frmMain";
            this.Text = "DooM Mod Randomizer";
            this.grpMods.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstMods;
        private System.Windows.Forms.GroupBox grpMods;
        private System.Windows.Forms.Button btnEdit;
    }
}

