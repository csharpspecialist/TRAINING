namespace TextBoxApp
{
    partial class DUDE
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
            this.btnAction = new System.Windows.Forms.Button();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtBox4 = new System.Windows.Forms.TextBox();
            this.btn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(161, 195);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(159, 23);
            this.btnAction.TabIndex = 0;
            this.btnAction.Text = "ACTION";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(162, 35);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(158, 20);
            this.txtBox1.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(199, 280);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(58, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "LABEL111";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(155, 150);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(159, 23);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "RUN";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(195, 110);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(102, 37);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(190, 359);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(23, 13);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "lbl4";
            // 
            // txtBox4
            // 
            this.txtBox4.Location = new System.Drawing.Point(161, 87);
            this.txtBox4.Name = "txtBox4";
            this.txtBox4.Size = new System.Drawing.Size(153, 20);
            this.txtBox4.TabIndex = 8;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(162, 241);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(158, 23);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "do 4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // DUDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 420);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.txtBox4);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.btnAction);
            this.Name = "DUDE";
            this.Text = "DUDE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtBox4;
        private System.Windows.Forms.Button btn4;
    }
}

