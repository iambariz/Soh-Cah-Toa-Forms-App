
namespace Soh_Cah_Toa_Forms_App
{
    partial class window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window));
            this.calculateBtn = new System.Windows.Forms.Button();
            this.inputA = new System.Windows.Forms.TextBox();
            this.yAngle = new System.Windows.Forms.TextBox();
            this.inputB = new System.Windows.Forms.TextBox();
            this.inputC = new System.Windows.Forms.TextBox();
            this.xAngle = new System.Windows.Forms.TextBox();
            this.outputField = new System.Windows.Forms.TextBox();
            this.LabelSideA = new System.Windows.Forms.Label();
            this.LabelSideC = new System.Windows.Forms.Label();
            this.LabelSideB = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.yAngleLabel = new System.Windows.Forms.Label();
            this.xAngelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.AccessibleName = "";
            this.calculateBtn.Location = new System.Drawing.Point(658, 415);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(107, 23);
            this.calculateBtn.TabIndex = 0;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // inputA
            // 
            this.inputA.Location = new System.Drawing.Point(46, 217);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(60, 23);
            this.inputA.TabIndex = 2;
            this.inputA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputA_KeyPress);
            // 
            // yAngle
            // 
            this.yAngle.Location = new System.Drawing.Point(123, 105);
            this.yAngle.Name = "yAngle";
            this.yAngle.Size = new System.Drawing.Size(60, 23);
            this.yAngle.TabIndex = 3;
            // 
            // inputB
            // 
            this.inputB.Location = new System.Drawing.Point(307, 416);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(60, 23);
            this.inputB.TabIndex = 4;
            this.inputB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputB_KeyPress);
            // 
            // inputC
            // 
            this.inputC.Location = new System.Drawing.Point(335, 169);
            this.inputC.Name = "inputC";
            this.inputC.Size = new System.Drawing.Size(60, 23);
            this.inputC.TabIndex = 5;
            this.inputC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputC_KeyPress);
            // 
            // xAngle
            // 
            this.xAngle.Location = new System.Drawing.Point(446, 368);
            this.xAngle.Name = "xAngle";
            this.xAngle.Size = new System.Drawing.Size(60, 23);
            this.xAngle.TabIndex = 6;
            // 
            // outputField
            // 
            this.outputField.Location = new System.Drawing.Point(584, 48);
            this.outputField.Multiline = true;
            this.outputField.Name = "outputField";
            this.outputField.ReadOnly = true;
            this.outputField.Size = new System.Drawing.Size(181, 343);
            this.outputField.TabIndex = 7;
            this.outputField.Text = "asd";
            // 
            // LabelSideA
            // 
            this.LabelSideA.AutoSize = true;
            this.LabelSideA.Location = new System.Drawing.Point(57, 247);
            this.LabelSideA.Name = "LabelSideA";
            this.LabelSideA.Size = new System.Drawing.Size(40, 15);
            this.LabelSideA.TabIndex = 8;
            this.LabelSideA.Text = "A Side";
            // 
            // LabelSideC
            // 
            this.LabelSideC.AutoSize = true;
            this.LabelSideC.Location = new System.Drawing.Point(344, 195);
            this.LabelSideC.Name = "LabelSideC";
            this.LabelSideC.Size = new System.Drawing.Size(40, 15);
            this.LabelSideC.TabIndex = 9;
            this.LabelSideC.Text = "C Side";
            // 
            // LabelSideB
            // 
            this.LabelSideB.AutoSize = true;
            this.LabelSideB.Location = new System.Drawing.Point(262, 419);
            this.LabelSideB.Name = "LabelSideB";
            this.LabelSideB.Size = new System.Drawing.Size(39, 15);
            this.LabelSideB.TabIndex = 10;
            this.LabelSideB.Text = "B Side";
            // 
            // picture
            // 
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(105, 35);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(454, 374);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 1;
            this.picture.TabStop = false;
            // 
            // yAngleLabel
            // 
            this.yAngleLabel.AutoSize = true;
            this.yAngleLabel.Location = new System.Drawing.Point(135, 131);
            this.yAngleLabel.Name = "yAngleLabel";
            this.yAngleLabel.Size = new System.Drawing.Size(48, 15);
            this.yAngleLabel.TabIndex = 11;
            this.yAngleLabel.Text = "Y Angle";
            // 
            // xAngelLabel
            // 
            this.xAngelLabel.AutoSize = true;
            this.xAngelLabel.Location = new System.Drawing.Point(402, 350);
            this.xAngelLabel.Name = "xAngelLabel";
            this.xAngelLabel.Size = new System.Drawing.Size(48, 15);
            this.xAngelLabel.TabIndex = 12;
            this.xAngelLabel.Text = "X Angle";
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xAngelLabel);
            this.Controls.Add(this.yAngleLabel);
            this.Controls.Add(this.LabelSideB);
            this.Controls.Add(this.LabelSideC);
            this.Controls.Add(this.LabelSideA);
            this.Controls.Add(this.outputField);
            this.Controls.Add(this.xAngle);
            this.Controls.Add(this.inputC);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.yAngle);
            this.Controls.Add(this.inputA);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.calculateBtn);
            this.Name = "window";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox inputA;
        private System.Windows.Forms.TextBox yAngle;
        private System.Windows.Forms.TextBox inputB;
        private System.Windows.Forms.TextBox inputC;
        private System.Windows.Forms.TextBox xAngle;
        private System.Windows.Forms.TextBox outputField;
        private System.Windows.Forms.Label LabelSideA;
        private System.Windows.Forms.Label LabelSideC;
        private System.Windows.Forms.Label LabelB;
        private System.Windows.Forms.Label LabelSideB;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label yAngleLabel;
        private System.Windows.Forms.Label xAngelLabel;
    }
}

