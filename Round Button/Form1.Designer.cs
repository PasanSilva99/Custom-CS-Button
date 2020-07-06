namespace Round_Button
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
            this.customButton3 = new Round_Button.CustomButton();
            this.customButton1 = new Round_Button.CustomButton();
            this.SuspendLayout();
            // 
            // customButton3
            // 
            this.customButton3.ButtonFont = new System.Drawing.Font("Century Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton3.ButtonText = "Malinga";
            this.customButton3.CornerRadius = 250F;
            this.customButton3.defaultBackColor = System.Drawing.Color.LightCoral;
            this.customButton3.defaultForeColor = System.Drawing.Color.Black;
            this.customButton3.Location = new System.Drawing.Point(253, 62);
            this.customButton3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.customButton3.Name = "customButton3";
            this.customButton3.OnClickBackColor = System.Drawing.Color.DarkViolet;
            this.customButton3.OnClickForeColor = System.Drawing.Color.Black;
            this.customButton3.OnHoverBackColor = System.Drawing.Color.Pink;
            this.customButton3.OnHoverForeColor = System.Drawing.Color.Black;
            this.customButton3.Size = new System.Drawing.Size(500, 500);
            this.customButton3.TabIndex = 3;
            this.customButton3.TextSize = 0;
            this.customButton3.Click += new System.EventHandler(this.customButton3_Click);
            // 
            // customButton1
            // 
            this.customButton1.ButtonFont = new System.Drawing.Font("Century Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ButtonText = "Malinga";
            this.customButton1.CornerRadius = 250F;
            this.customButton1.defaultBackColor = System.Drawing.Color.LightCoral;
            this.customButton1.defaultForeColor = System.Drawing.Color.Black;
            this.customButton1.Location = new System.Drawing.Point(828, 62);
            this.customButton1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.customButton1.Name = "customButton1";
            this.customButton1.OnClickBackColor = System.Drawing.Color.DarkViolet;
            this.customButton1.OnClickForeColor = System.Drawing.Color.Black;
            this.customButton1.OnHoverBackColor = System.Drawing.Color.Pink;
            this.customButton1.OnHoverForeColor = System.Drawing.Color.Black;
            this.customButton1.Size = new System.Drawing.Size(500, 500);
            this.customButton1.TabIndex = 4;
            this.customButton1.TextSize = 0;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1382, 606);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.customButton3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Round Bo";
            this.ResumeLayout(false);

        }

        #endregion
        private CustomButton customButton3;
        private CustomButton customButton1;
    }
}

