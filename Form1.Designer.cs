namespace Minecraft_Launcher_Skins
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			listBox1 = new ListBox();
			listBox2 = new ListBox();
			pictureBox1 = new PictureBox();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.IntegralHeight = false;
			listBox1.Location = new Point(12, 12);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(89, 426);
			listBox1.TabIndex = 0;
			listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
			// 
			// listBox2
			// 
			listBox2.FormattingEnabled = true;
			listBox2.IntegralHeight = false;
			listBox2.Location = new Point(107, 12);
			listBox2.Name = "listBox2";
			listBox2.Size = new Size(265, 426);
			listBox2.TabIndex = 1;
			listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(378, 161);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(128, 128);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(378, 143);
			label1.Name = "label1";
			label1.Size = new Size(64, 15);
			label1.TabIndex = 3;
			label1.Text = "Skin/Cape:";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(512, 450);
			Controls.Add(label1);
			Controls.Add(listBox1);
			Controls.Add(pictureBox1);
			Controls.Add(listBox2);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListBox listBox1;
		private ListBox listBox2;
		private PictureBox pictureBox1;
		private Label label1;
	}
}
