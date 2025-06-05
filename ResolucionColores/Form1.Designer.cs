namespace ResolucionColores
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
            ColorObjetivo = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            SuspendLayout();
            // 
            // ColorObjetivo
            // 
            ColorObjetivo.AutoSize = true;
            ColorObjetivo.Location = new Point(109, 46);
            ColorObjetivo.Name = "ColorObjetivo";
            ColorObjetivo.Size = new Size(83, 19);
            ColorObjetivo.TabIndex = 0;
            ColorObjetivo.Text = "checkBox1";
            ColorObjetivo.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(109, 182);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(359, 182);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(83, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(601, 182);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(83, 19);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(109, 305);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(83, 19);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(359, 305);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(83, 19);
            checkBox5.TabIndex = 5;
            checkBox5.Text = "checkBox5";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(601, 305);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(83, 19);
            checkBox6.TabIndex = 6;
            checkBox6.Text = "checkBox6";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(ColorObjetivo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ColorObjetivo;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
    }
}
