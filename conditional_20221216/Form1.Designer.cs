namespace conditional_20221216
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKuk = new System.Windows.Forms.TextBox();
            this.tbEng = new System.Windows.Forms.TextBox();
            this.tbMath = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.lblAvg = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "국어 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "영어 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "수학 :";
            // 
            // tbKuk
            // 
            this.tbKuk.Location = new System.Drawing.Point(132, 37);
            this.tbKuk.Name = "tbKuk";
            this.tbKuk.Size = new System.Drawing.Size(138, 28);
            this.tbKuk.TabIndex = 3;
            this.tbKuk.Enter += new System.EventHandler(this.tbKuk_Enter);
            // 
            // tbEng
            // 
            this.tbEng.Location = new System.Drawing.Point(353, 37);
            this.tbEng.Name = "tbEng";
            this.tbEng.Size = new System.Drawing.Size(123, 28);
            this.tbEng.TabIndex = 4;
            this.tbEng.Enter += new System.EventHandler(this.tbEng_Enter);
            // 
            // tbMath
            // 
            this.tbMath.Location = new System.Drawing.Point(577, 37);
            this.tbMath.Name = "tbMath";
            this.tbMath.Size = new System.Drawing.Size(161, 28);
            this.tbMath.TabIndex = 5;
            this.tbMath.Enter += new System.EventHandler(this.tbMath_Enter);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(61, 103);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(676, 76);
            this.btnResult.TabIndex = 6;
            this.btnResult.Text = "결과";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lblAvg
            // 
            this.lblAvg.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvg.Location = new System.Drawing.Point(148, 197);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(199, 63);
            this.lblAvg.TabIndex = 7;
            this.lblAvg.Text = "평균값";
            this.lblAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(430, 197);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(199, 63);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "학점";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 305);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.tbMath);
            this.Controls.Add(this.tbEng);
            this.Controls.Add(this.tbKuk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblResult;

        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label lblAvg;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKuk;
        private System.Windows.Forms.TextBox tbEng;
        private System.Windows.Forms.TextBox tbMath;

        #endregion
    }
}