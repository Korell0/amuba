
namespace Amuba
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
            this.Rules = new System.Windows.Forms.GroupBox();
            this.Leiras = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.JelenlegiPBox = new System.Windows.Forms.PictureBox();
            this.nextLabel = new System.Windows.Forms.Label();
            this.Rules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JelenlegiPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Rules
            // 
            this.Rules.Controls.Add(this.Leiras);
            this.Rules.Location = new System.Drawing.Point(30, 10);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(200, 149);
            this.Rules.TabIndex = 0;
            this.Rules.TabStop = false;
            this.Rules.Text = "Játékszabályok:";
            this.Rules.Visible = false;
            // 
            // Leiras
            // 
            this.Leiras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Leiras.Location = new System.Drawing.Point(6, 16);
            this.Leiras.Name = "Leiras";
            this.Leiras.Size = new System.Drawing.Size(188, 129);
            this.Leiras.TabIndex = 0;
            this.Leiras.Text = "Két játékos játszik egy 10x10-es pályán.\r\n\r\nA cél kirakni 5 egybefüggő szimbólumo" +
    "t.\r\n\r\namelyik játékos ezt előbb eléri az nyer.\r\n";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Cursor = System.Windows.Forms.Cursors.Help;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabel.ForeColor = System.Drawing.Color.Red;
            this.infoLabel.Location = new System.Drawing.Point(1150, 10);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(24, 25);
            this.infoLabel.TabIndex = 3;
            this.infoLabel.Text = "?";
            this.infoLabel.MouseEnter += new System.EventHandler(this.infoLabel_MouseEnter);
            this.infoLabel.MouseLeave += new System.EventHandler(this.infoLabel_MouseLeave);
            this.infoLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.infoLabel_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(22, 662);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // JelenlegiPBox
            // 
            this.JelenlegiPBox.Location = new System.Drawing.Point(874, 260);
            this.JelenlegiPBox.Name = "JelenlegiPBox";
            this.JelenlegiPBox.Size = new System.Drawing.Size(150, 150);
            this.JelenlegiPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.JelenlegiPBox.TabIndex = 5;
            this.JelenlegiPBox.TabStop = false;
            // 
            // nextLabel
            // 
            this.nextLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextLabel.Location = new System.Drawing.Point(874, 200);
            this.nextLabel.Name = "nextLabel";
            this.nextLabel.Size = new System.Drawing.Size(150, 57);
            this.nextLabel.TabIndex = 6;
            this.nextLabel.Text = "label1";
            this.nextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.nextLabel);
            this.Controls.Add(this.JelenlegiPBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.Rules);
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Rules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.JelenlegiPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Rules;
        private System.Windows.Forms.Label Leiras;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox JelenlegiPBox;
        private System.Windows.Forms.Label nextLabel;
    }
}

