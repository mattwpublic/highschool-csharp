
namespace WidemanCalculator
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
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.muliplyButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.powerButton = new System.Windows.Forms.Button();
            this.Number1Box = new System.Windows.Forms.Label();
            this.NumberBox1 = new System.Windows.Forms.TextBox();
            this.NumberBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(256, 101);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(94, 29);
            this.plusButton.TabIndex = 0;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click_1);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(256, 153);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(94, 29);
            this.minusButton.TabIndex = 1;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click_1);
            // 
            // muliplyButton
            // 
            this.muliplyButton.Location = new System.Drawing.Point(256, 205);
            this.muliplyButton.Name = "muliplyButton";
            this.muliplyButton.Size = new System.Drawing.Size(94, 29);
            this.muliplyButton.TabIndex = 2;
            this.muliplyButton.Text = "x";
            this.muliplyButton.UseVisualStyleBackColor = true;
            this.muliplyButton.Click += new System.EventHandler(this.muliplyButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.Location = new System.Drawing.Point(256, 257);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(94, 29);
            this.divisionButton.TabIndex = 3;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // powerButton
            // 
            this.powerButton.Location = new System.Drawing.Point(256, 307);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(94, 29);
            this.powerButton.TabIndex = 4;
            this.powerButton.Text = "^";
            this.powerButton.UseVisualStyleBackColor = true;
            this.powerButton.Click += new System.EventHandler(this.powerButton_Click);
            // 
            // Number1Box
            // 
            this.Number1Box.AutoSize = true;
            this.Number1Box.Location = new System.Drawing.Point(79, 104);
            this.Number1Box.Name = "Number1Box";
            this.Number1Box.Size = new System.Drawing.Size(55, 20);
            this.Number1Box.TabIndex = 5;
            this.Number1Box.Text = "Output";
            // 
            // NumberBox1
            // 
            this.NumberBox1.Location = new System.Drawing.Point(42, 34);
            this.NumberBox1.Name = "NumberBox1";
            this.NumberBox1.Size = new System.Drawing.Size(125, 27);
            this.NumberBox1.TabIndex = 7;
            // 
            // NumberBox2
            // 
            this.NumberBox2.Location = new System.Drawing.Point(210, 34);
            this.NumberBox2.Name = "NumberBox2";
            this.NumberBox2.Size = new System.Drawing.Size(125, 27);
            this.NumberBox2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 553);
            this.Controls.Add(this.NumberBox2);
            this.Controls.Add(this.NumberBox1);
            this.Controls.Add(this.Number1Box);
            this.Controls.Add(this.powerButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.muliplyButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button muliplyButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.Label Number1Box;
        private System.Windows.Forms.TextBox NumberBox1;
        private System.Windows.Forms.TextBox NumberBox2;
    }
}

