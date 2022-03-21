namespace CS311_Project2_AMR
{
    partial class frmCraps
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
            this.lblDie1 = new System.Windows.Forms.Label();
            this.lblDie2 = new System.Windows.Forms.Label();
            this.lblBankBalance = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDie1
            // 
            this.lblDie1.AutoSize = true;
            this.lblDie1.Location = new System.Drawing.Point(35, 40);
            this.lblDie1.Name = "lblDie1";
            this.lblDie1.Size = new System.Drawing.Size(57, 25);
            this.lblDie1.TabIndex = 0;
            this.lblDie1.Text = "Die 1:";
            // 
            // lblDie2
            // 
            this.lblDie2.AutoSize = true;
            this.lblDie2.Location = new System.Drawing.Point(35, 92);
            this.lblDie2.Name = "lblDie2";
            this.lblDie2.Size = new System.Drawing.Size(57, 25);
            this.lblDie2.TabIndex = 1;
            this.lblDie2.Text = "Die 2:";
            // 
            // lblBankBalance
            // 
            this.lblBankBalance.AutoSize = true;
            this.lblBankBalance.Location = new System.Drawing.Point(35, 246);
            this.lblBankBalance.Name = "lblBankBalance";
            this.lblBankBalance.Size = new System.Drawing.Size(80, 25);
            this.lblBankBalance.TabIndex = 2;
            this.lblBankBalance.Text = "Balance: ";
            this.lblBankBalance.TextChanged += new System.EventHandler(this.btnRoll_Click);
            // 
            // txtBet
            // 
            this.txtBet.Location = new System.Drawing.Point(35, 294);
            this.txtBet.Name = "txtBet";
            this.txtBet.PlaceholderText = "Enter your bet!";
            this.txtBet.Size = new System.Drawing.Size(150, 31);
            this.txtBet.TabIndex = 3;
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRoll.Location = new System.Drawing.Point(35, 348);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(266, 64);
            this.btnRoll.TabIndex = 4;
            this.btnRoll.Text = "Roll the Dice!";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(557, 151);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(53, 25);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "You...";
            // 
            // frmCraps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.lblBankBalance);
            this.Controls.Add(this.lblDie2);
            this.Controls.Add(this.lblDie1);
            this.Name = "frmCraps";
            this.Text = "Craps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDie1;
        private Label lblDie2;
        private Label lblBankBalance;
        private TextBox txtBet;
        private Button btnRoll;
        private Label lblResult;
    }
}