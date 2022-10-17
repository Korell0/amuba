
namespace Amuba
{
    partial class Menu
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
            this.twoplayer = new System.Windows.Forms.Button();
            this.oneplayer = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // twoplayer
            // 
            this.twoplayer.Location = new System.Drawing.Point(87, 73);
            this.twoplayer.Name = "twoplayer";
            this.twoplayer.Size = new System.Drawing.Size(161, 34);
            this.twoplayer.TabIndex = 1;
            this.twoplayer.Text = "Versus";
            this.twoplayer.UseVisualStyleBackColor = true;
            this.twoplayer.Click += new System.EventHandler(this.twoplayer_Click);
            // 
            // oneplayer
            // 
            this.oneplayer.Location = new System.Drawing.Point(87, 21);
            this.oneplayer.Name = "oneplayer";
            this.oneplayer.Size = new System.Drawing.Size(161, 34);
            this.oneplayer.TabIndex = 2;
            this.oneplayer.Text = "Singleplayer";
            this.oneplayer.UseVisualStyleBackColor = true;
            this.oneplayer.Click += new System.EventHandler(this.oneplayer_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(250, 50);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 50);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Visible = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.oneplayer);
            this.Controls.Add(this.twoplayer);
            this.MaximumSize = new System.Drawing.Size(350, 200);
            this.MinimumSize = new System.Drawing.Size(350, 200);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button twoplayer;
        private System.Windows.Forms.Button oneplayer;
        private System.Windows.Forms.Button startBtn;
    }
}