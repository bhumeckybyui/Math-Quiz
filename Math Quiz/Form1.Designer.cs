namespace Math_Quiz
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
            this.components = new System.ComponentModel.Container();
            this.timeLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plusLeftLable = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.plusRightLable = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.minusRightLable = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.minusLeftLable = new System.Windows.Forms.Label();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.dividedRightLable = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dividedLeftLable = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.timesRightLable = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.timesLeftLable = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLable
            // 
            this.timeLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLable.Location = new System.Drawing.Point(321, 22);
            this.timeLable.Name = "timeLable";
            this.timeLable.Size = new System.Drawing.Size(200, 30);
            this.timeLable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Left";
            // 
            // plusLeftLable
            // 
            this.plusLeftLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLable.Location = new System.Drawing.Point(57, 74);
            this.plusLeftLable.Name = "plusLeftLable";
            this.plusLeftLable.Size = new System.Drawing.Size(60, 50);
            this.plusLeftLable.TabIndex = 2;
            this.plusLeftLable.Text = "?";
            this.plusLeftLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 50);
            this.label4.TabIndex = 4;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLable
            // 
            this.plusRightLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLable.Location = new System.Drawing.Point(189, 74);
            this.plusRightLable.Name = "plusRightLable";
            this.plusRightLable.Size = new System.Drawing.Size(60, 50);
            this.plusRightLable.TabIndex = 5;
            this.plusRightLable.Text = "?";
            this.plusRightLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(123, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 50);
            this.label6.TabIndex = 6;
            this.label6.Text = "+";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(321, 83);
            this.sum.MinimumSize = new System.Drawing.Size(100, 0);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 35);
            this.sum.TabIndex = 2;
            this.sum.ValueChanged += new System.EventHandler(this.sum_ValueChanged);
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difference.Location = new System.Drawing.Point(321, 137);
            this.difference.MinimumSize = new System.Drawing.Size(100, 0);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(100, 35);
            this.difference.TabIndex = 3;
            this.difference.ValueChanged += new System.EventHandler(this.difference_ValueChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 11;
            this.label3.Text = "-";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightLable
            // 
            this.minusRightLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRightLable.Location = new System.Drawing.Point(189, 128);
            this.minusRightLable.Name = "minusRightLable";
            this.minusRightLable.Size = new System.Drawing.Size(60, 50);
            this.minusRightLable.TabIndex = 10;
            this.minusRightLable.Text = "?";
            this.minusRightLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(255, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 50);
            this.label7.TabIndex = 9;
            this.label7.Text = "=";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLeftLable
            // 
            this.minusLeftLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeftLable.Location = new System.Drawing.Point(57, 128);
            this.minusLeftLable.Name = "minusLeftLable";
            this.minusLeftLable.Size = new System.Drawing.Size(60, 50);
            this.minusLeftLable.TabIndex = 8;
            this.minusLeftLable.Text = "?";
            this.minusLeftLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotient.Location = new System.Drawing.Point(321, 245);
            this.quotient.MinimumSize = new System.Drawing.Size(100, 0);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(100, 35);
            this.quotient.TabIndex = 5;
            this.quotient.ValueChanged += new System.EventHandler(this.quotient_ValueChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(123, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 50);
            this.label9.TabIndex = 21;
            this.label9.Text = "÷";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dividedRightLable
            // 
            this.dividedRightLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedRightLable.Location = new System.Drawing.Point(189, 236);
            this.dividedRightLable.Name = "dividedRightLable";
            this.dividedRightLable.Size = new System.Drawing.Size(60, 50);
            this.dividedRightLable.TabIndex = 20;
            this.dividedRightLable.Text = "?";
            this.dividedRightLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(255, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 50);
            this.label11.TabIndex = 19;
            this.label11.Text = "=";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLable
            // 
            this.dividedLeftLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedLeftLable.Location = new System.Drawing.Point(57, 236);
            this.dividedLeftLable.Name = "dividedLeftLable";
            this.dividedLeftLable.Size = new System.Drawing.Size(60, 50);
            this.dividedLeftLable.TabIndex = 18;
            this.dividedLeftLable.Text = "?";
            this.dividedLeftLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(321, 189);
            this.product.MinimumSize = new System.Drawing.Size(100, 0);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(100, 35);
            this.product.TabIndex = 4;
            this.product.ValueChanged += new System.EventHandler(this.product_ValueChanged);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(123, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 50);
            this.label13.TabIndex = 16;
            this.label13.Text = "X";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLable
            // 
            this.timesRightLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesRightLable.Location = new System.Drawing.Point(189, 180);
            this.timesRightLable.Name = "timesRightLable";
            this.timesRightLable.Size = new System.Drawing.Size(60, 50);
            this.timesRightLable.TabIndex = 15;
            this.timesRightLable.Text = "?";
            this.timesRightLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(255, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 50);
            this.label15.TabIndex = 14;
            this.label15.Text = "=";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeftLable
            // 
            this.timesLeftLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLeftLable.Location = new System.Drawing.Point(57, 180);
            this.timesLeftLable.Name = "timesLeftLable";
            this.timesLeftLable.Size = new System.Drawing.Size(60, 50);
            this.timesLeftLable.TabIndex = 13;
            this.timesLeftLable.Text = "?";
            this.timesLeftLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(154, 317);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(161, 48);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start the Quiz!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 398);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dividedRightLable);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dividedLeftLable);
            this.Controls.Add(this.product);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.timesRightLable);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.timesLeftLable);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minusRightLable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minusLeftLable);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.plusRightLable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.plusLeftLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plusLeftLable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label plusRightLable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label minusRightLable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label minusLeftLable;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label dividedRightLable;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label dividedLeftLable;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label timesRightLable;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label timesLeftLable;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

