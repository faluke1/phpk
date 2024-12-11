namespace phpk
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            lblResult = new Label();
            btnCircumference = new Button();
            btnCircleArea = new Button();
            txtRadius = new TextBox();
            groupBox2 = new GroupBox();
            btnOutParameter = new Button();
            txtInpuut = new TextBox();
            btnRefParameter = new Button();
            txtsize = new TextBox();
            txtLetter = new TextBox();
            btnTriangle01 = new Button();
            txtOutput = new TextBox();
            btnArrayParameter = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 54);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "รัศมีวงกลม";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Ivory;
            groupBox1.Controls.Add(lblResult);
            groupBox1.Controls.Add(btnCircumference);
            groupBox1.Controls.Add(btnCircleArea);
            groupBox1.Controls.Add(txtRadius);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(23, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 208);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "รูปวงกลม";
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.Gold;
            lblResult.Location = new Point(96, 141);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(205, 51);
            lblResult.TabIndex = 2;
            lblResult.Text = "....";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCircumference
            // 
            btnCircumference.Location = new Point(297, 54);
            btnCircumference.Name = "btnCircumference";
            btnCircumference.Size = new Size(102, 30);
            btnCircumference.TabIndex = 4;
            btnCircumference.Text = "เส้นรอบวง";
            btnCircumference.UseVisualStyleBackColor = true;
            btnCircumference.Click += btnCircumference_Click;
            // 
            // btnCircleArea
            // 
            btnCircleArea.Location = new Point(205, 54);
            btnCircleArea.Name = "btnCircleArea";
            btnCircleArea.Size = new Size(69, 30);
            btnCircleArea.TabIndex = 3;
            btnCircleArea.Text = "พื้นที่";
            btnCircleArea.UseVisualStyleBackColor = true;
            btnCircleArea.Click += btnCircleArea_Click;
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(82, 54);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(90, 27);
            txtRadius.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(btnOutParameter);
            groupBox2.Controls.Add(txtInpuut);
            groupBox2.Controls.Add(btnRefParameter);
            groupBox2.Controls.Add(txtsize);
            groupBox2.Controls.Add(txtLetter);
            groupBox2.Controls.Add(btnTriangle01);
            groupBox2.Controls.Add(txtOutput);
            groupBox2.Location = new Point(23, 270);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(458, 312);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "ทดสอบ function";
            // 
            // btnOutParameter
            // 
            btnOutParameter.Location = new Point(194, 248);
            btnOutParameter.Name = "btnOutParameter";
            btnOutParameter.Size = new Size(231, 42);
            btnOutParameter.TabIndex = 9;
            btnOutParameter.Text = "ทดสอบ output Parameter";
            btnOutParameter.UseVisualStyleBackColor = true;
            btnOutParameter.Click += btnOutParameter_Click;
            // 
            // txtInpuut
            // 
            txtInpuut.Location = new Point(194, 140);
            txtInpuut.Name = "txtInpuut";
            txtInpuut.Size = new Size(231, 27);
            txtInpuut.TabIndex = 8;
            // 
            // btnRefParameter
            // 
            btnRefParameter.Location = new Point(194, 187);
            btnRefParameter.Name = "btnRefParameter";
            btnRefParameter.Size = new Size(231, 42);
            btnRefParameter.TabIndex = 7;
            btnRefParameter.Text = "ทดสอบ  reference Parameter";
            btnRefParameter.UseVisualStyleBackColor = true;
            btnRefParameter.Click += btnRefParameter_Click;
            // 
            // txtsize
            // 
            txtsize.Location = new Point(194, 88);
            txtsize.Name = "txtsize";
            txtsize.Size = new Size(80, 27);
            txtsize.TabIndex = 6;
            txtsize.Text = "5";
            txtsize.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLetter
            // 
            txtLetter.Location = new Point(194, 34);
            txtLetter.Name = "txtLetter";
            txtLetter.Size = new Size(80, 27);
            txtLetter.TabIndex = 5;
            txtLetter.Text = "A";
            txtLetter.TextAlign = HorizontalAlignment.Center;
            // 
            // btnTriangle01
            // 
            btnTriangle01.Location = new Point(318, 26);
            btnTriangle01.Name = "btnTriangle01";
            btnTriangle01.Size = new Size(100, 43);
            btnTriangle01.TabIndex = 4;
            btnTriangle01.Text = "Triangle";
            btnTriangle01.UseVisualStyleBackColor = true;
            btnTriangle01.Click += btnTriangle01_Click;
            // 
            // txtOutput
            // 
            txtOutput.BackColor = Color.WhiteSmoke;
            txtOutput.Location = new Point(6, 26);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(166, 240);
            txtOutput.TabIndex = 3;
            // 
            // btnArrayParameter
            // 
            btnArrayParameter.Location = new Point(599, 43);
            btnArrayParameter.Name = "btnArrayParameter";
            btnArrayParameter.Size = new Size(203, 113);
            btnArrayParameter.TabIndex = 3;
            btnArrayParameter.Text = "Parameter แบบ Array";
            btnArrayParameter.UseVisualStyleBackColor = true;
            btnArrayParameter.Click += btnArrayParameter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 594);
            Controls.Add(btnArrayParameter);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = " ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnCircleArea;
        private TextBox txtRadius;
        private Label lblResult;
        private Button btnCircumference;
        private GroupBox groupBox2;
        private TextBox txtOutput;
        private Button btnTriangle01;
        private TextBox txtsize;
        private TextBox txtLetter;
        private TextBox txtInpuut;
        private Button btnRefParameter;
        private Button btnOutParameter;
        private Button btnArrayParameter;
    }
}
