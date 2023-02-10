namespace OpenTheSafe
{
    partial class OpenTheSafe
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
            this.numlbl3 = new System.Windows.Forms.TextBox();
            this.numlbl2 = new System.Windows.Forms.TextBox();
            this.numlbl1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cheatCheck = new System.Windows.Forms.CheckBox();
            this.cheatSheet = new System.Windows.Forms.GroupBox();
            this.answerlbl3 = new System.Windows.Forms.Label();
            this.answerlbl2 = new System.Windows.Forms.Label();
            this.answerLbl1 = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.cheatSheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            this.SuspendLayout();
            // 
            // numlbl3
            // 
            this.numlbl3.Font = new System.Drawing.Font("Sitka Heading Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numlbl3.Location = new System.Drawing.Point(453, 191);
            this.numlbl3.Name = "numlbl3";
            this.numlbl3.Size = new System.Drawing.Size(35, 41);
            this.numlbl3.TabIndex = 2;
            this.numlbl3.Text = "00";
            this.numlbl3.TextChanged += new System.EventHandler(this.numlbl3_TextChanged);
            // 
            // numlbl2
            // 
            this.numlbl2.Font = new System.Drawing.Font("Sitka Heading Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numlbl2.Location = new System.Drawing.Point(380, 191);
            this.numlbl2.Name = "numlbl2";
            this.numlbl2.Size = new System.Drawing.Size(36, 41);
            this.numlbl2.TabIndex = 1;
            this.numlbl2.Text = "00";
            this.numlbl2.TextChanged += new System.EventHandler(this.numlbl2_TextChanged);
            // 
            // numlbl1
            // 
            this.numlbl1.Font = new System.Drawing.Font("Sitka Heading Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numlbl1.Location = new System.Drawing.Point(304, 191);
            this.numlbl1.Name = "numlbl1";
            this.numlbl1.Size = new System.Drawing.Size(36, 41);
            this.numlbl1.TabIndex = 0;
            this.numlbl1.Text = "00";
            this.numlbl1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numlbl1.TextChanged += new System.EventHandler(this.numlbl1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(238, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Open the Safe!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cheatCheck
            // 
            this.cheatCheck.AutoSize = true;
            this.cheatCheck.Location = new System.Drawing.Point(19, 141);
            this.cheatCheck.Name = "cheatCheck";
            this.cheatCheck.Size = new System.Drawing.Size(89, 19);
            this.cheatCheck.TabIndex = 4;
            this.cheatCheck.Text = "Show Cheat";
            this.cheatCheck.UseVisualStyleBackColor = true;
            this.cheatCheck.CheckedChanged += new System.EventHandler(this.cheatCheck_CheckedChanged);
            // 
            // cheatSheet
            // 
            this.cheatSheet.Controls.Add(this.answerlbl3);
            this.cheatSheet.Controls.Add(this.answerlbl2);
            this.cheatSheet.Controls.Add(this.answerLbl1);
            this.cheatSheet.Location = new System.Drawing.Point(12, 35);
            this.cheatSheet.Name = "cheatSheet";
            this.cheatSheet.Size = new System.Drawing.Size(206, 100);
            this.cheatSheet.TabIndex = 5;
            this.cheatSheet.TabStop = false;
            this.cheatSheet.Text = "Answer";
            this.cheatSheet.Visible = false;
            this.cheatSheet.Enter += new System.EventHandler(this.cheatSheet_Enter);
            // 
            // answerlbl3
            // 
            this.answerlbl3.AutoSize = true;
            this.answerlbl3.Location = new System.Drawing.Point(140, 41);
            this.answerlbl3.Name = "answerlbl3";
            this.answerlbl3.Size = new System.Drawing.Size(19, 15);
            this.answerlbl3.TabIndex = 2;
            this.answerlbl3.Text = "00";
            // 
            // answerlbl2
            // 
            this.answerlbl2.AutoSize = true;
            this.answerlbl2.Location = new System.Drawing.Point(90, 41);
            this.answerlbl2.Name = "answerlbl2";
            this.answerlbl2.Size = new System.Drawing.Size(19, 15);
            this.answerlbl2.TabIndex = 1;
            this.answerlbl2.Text = "00";
            // 
            // answerLbl1
            // 
            this.answerLbl1.AutoSize = true;
            this.answerLbl1.Location = new System.Drawing.Point(39, 41);
            this.answerLbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.answerLbl1.Name = "answerLbl1";
            this.answerLbl1.Size = new System.Drawing.Size(19, 15);
            this.answerLbl1.TabIndex = 0;
            this.answerLbl1.Text = "00\r\n";
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(304, 250);
            this.pic1.Margin = new System.Windows.Forms.Padding(2);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(48, 36);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic1.TabIndex = 6;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(374, 250);
            this.pic2.Margin = new System.Windows.Forms.Padding(2);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(50, 36);
            this.pic2.TabIndex = 7;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Location = new System.Drawing.Point(441, 250);
            this.pic3.Margin = new System.Windows.Forms.Padding(2);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(47, 36);
            this.pic3.TabIndex = 8;
            this.pic3.TabStop = false;
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.SystemColors.Info;
            this.btnGuess.Location = new System.Drawing.Point(363, 321);
            this.btnGuess.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(78, 20);
            this.btnGuess.TabIndex = 9;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStart.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(0, 403);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(800, 47);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // OpenTheSafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.numlbl2);
            this.Controls.Add(this.numlbl3);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.numlbl1);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.cheatSheet);
            this.Controls.Add(this.cheatCheck);
            this.Controls.Add(this.label1);
            this.Name = "OpenTheSafe";
            this.Text = "Open The Safe!";
            this.Load += new System.EventHandler(this.OpenTheSafe_Load);
            this.cheatSheet.ResumeLayout(false);
            this.cheatSheet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox numlbl3;
        private TextBox numlbl2;
        private TextBox numlbl1;
        private Label label1;
        private CheckBox cheatCheck;
        private GroupBox cheatSheet;
        private PictureBox pic1;
        private PictureBox pic2;
        private PictureBox pic3;
        private Label answerLbl1;
        private Button btnGuess;
        private Label answerlbl3;
        private Label answerlbl2;
        private Button btnStart;
    }
}