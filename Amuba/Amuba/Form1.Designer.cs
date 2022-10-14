
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
            this.label1 = new System.Windows.Forms.Label();
            this.Leiras = new System.Windows.Forms.Label();
            this.Rules.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rules
            // 
            this.Rules.Controls.Add(this.Leiras);
            this.Rules.Location = new System.Drawing.Point(537, 21);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(200, 149);
            this.Rules.TabIndex = 0;
            this.Rules.TabStop = false;
            this.Rules.Text = "Játékszabályok:";
            this.Rules.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(753, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "?";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rules);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Rules.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Rules;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Leiras;
    }
}

