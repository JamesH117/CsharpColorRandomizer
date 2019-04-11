namespace ColorSwapper
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
            this.buttonRandomizeColor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRandomizeColor
            // 
            this.buttonRandomizeColor.Location = new System.Drawing.Point(70, 165);
            this.buttonRandomizeColor.Name = "buttonRandomizeColor";
            this.buttonRandomizeColor.Size = new System.Drawing.Size(107, 65);
            this.buttonRandomizeColor.TabIndex = 0;
            this.buttonRandomizeColor.Text = "Randomize Color";
            this.buttonRandomizeColor.UseVisualStyleBackColor = true;
            this.buttonRandomizeColor.Click += new System.EventHandler(this.buttonRandomizeColor_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 103);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(251, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRandomizeColor);
            this.Name = "Form1";
            this.Text = "Color Randomizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRandomizeColor;
        private System.Windows.Forms.Button button1;
    }
}

