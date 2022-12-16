namespace loop_20221216
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
            this.btnResult = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.btnResult.Location = new System.Drawing.Point(218, 53);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(358, 86);
            this.btnResult.TabIndex = 0;
            this.btnResult.Text = "결과";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lblResult
            // 
            this.lblResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblResult.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(217, 209);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(359, 232);
            this.lblResult.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label lblResult;

        #endregion
    }
}