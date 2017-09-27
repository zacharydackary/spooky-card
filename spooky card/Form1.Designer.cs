namespace spooky_card
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.spookyText = new System.Windows.Forms.Label();
            this.booText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::spooky_card.Properties.Resources.spooky_scary_skeleton;
            this.pictureBox1.Location = new System.Drawing.Point(-27, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 360);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(76, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "open only if you dare.....";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "The Spooky HALLOWEEN Card";
            // 
            // spookyText
            // 
            this.spookyText.AutoSize = true;
            this.spookyText.BackColor = System.Drawing.Color.Transparent;
            this.spookyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spookyText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.spookyText.Location = new System.Drawing.Point(-5, 179);
            this.spookyText.Name = "spookyText";
            this.spookyText.Size = new System.Drawing.Size(448, 50);
            this.spookyText.TabIndex = 4;
            this.spookyText.Text = "THIS IS THE SPOOKY SCARY SKELETON....\r\nDon\'t move a muscle or he might spook you." +
    "..\r\n";
            this.spookyText.Visible = false;
            // 
            // booText
            // 
            this.booText.AutoSize = true;
            this.booText.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booText.Location = new System.Drawing.Point(58, 179);
            this.booText.Name = "booText";
            this.booText.Size = new System.Drawing.Size(340, 108);
            this.booText.TabIndex = 5;
            this.booText.Text = "BOO!!!";
            this.booText.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::spooky_card.Properties.Resources.doot_doot;
            this.ClientSize = new System.Drawing.Size(432, 378);
            this.Controls.Add(this.booText);
            this.Controls.Add(this.spookyText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label spookyText;
        private System.Windows.Forms.Label booText;
    }
}

