namespace CS311_Project2_PV
{
    partial class Craps
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
            txtBet = new TextBox();
            btnRoll = new Button();
            lblResult = new Label();
            lblBank = new Label();
            lblD1 = new Label();
            lblRolls = new Label();
            lblD2 = new Label();
            lblSum = new Label();
            btnReset = new Button();
            SuspendLayout();
            // 
            // txtBet
            // 
            txtBet.Location = new Point(46, 39);
            txtBet.Name = "txtBet";
            txtBet.PlaceholderText = "Enter your bet";
            txtBet.Size = new Size(114, 23);
            txtBet.TabIndex = 0;
            // 
            // btnRoll
            // 
            btnRoll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRoll.Location = new Point(46, 82);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(75, 23);
            btnRoll.TabIndex = 1;
            btnRoll.Text = "Roll";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += btnRoll_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Snow;
            lblResult.Location = new Point(138, 86);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 2;
            // 
            // lblBank
            // 
            lblBank.AutoSize = true;
            lblBank.Location = new Point(211, 86);
            lblBank.Name = "lblBank";
            lblBank.Size = new Size(93, 15);
            lblBank.TabIndex = 3;
            lblBank.Text = "Balance: $100.00";
            // 
            // lblD1
            // 
            lblD1.AutoSize = true;
            lblD1.BorderStyle = BorderStyle.FixedSingle;
            lblD1.Location = new Point(173, 42);
            lblD1.Name = "lblD1";
            lblD1.Size = new Size(15, 17);
            lblD1.TabIndex = 4;
            lblD1.Text = "  ";
            // 
            // lblRolls
            // 
            lblRolls.AutoSize = true;
            lblRolls.Location = new Point(268, 42);
            lblRolls.Name = "lblRolls";
            lblRolls.Size = new Size(44, 15);
            lblRolls.TabIndex = 5;
            lblRolls.Text = "Rolls: 0";
            // 
            // lblD2
            // 
            lblD2.AutoSize = true;
            lblD2.BorderStyle = BorderStyle.FixedSingle;
            lblD2.Location = new Point(202, 42);
            lblD2.Name = "lblD2";
            lblD2.Size = new Size(15, 17);
            lblD2.TabIndex = 6;
            lblD2.Text = "  ";
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.BackColor = SystemColors.ActiveCaptionText;
            lblSum.BorderStyle = BorderStyle.FixedSingle;
            lblSum.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSum.ForeColor = SystemColors.ButtonFace;
            lblSum.Location = new Point(231, 42);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(34, 17);
            lblSum.TabIndex = 7;
            lblSum.Text = "Sum";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(46, 125);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(92, 23);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset Game";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Craps
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(lblSum);
            Controls.Add(lblD2);
            Controls.Add(lblRolls);
            Controls.Add(lblD1);
            Controls.Add(lblBank);
            Controls.Add(lblResult);
            Controls.Add(btnRoll);
            Controls.Add(txtBet);
            Name = "Craps";
            Text = "Craps";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBet;
        private Button btnRoll;
        private Label lblResult;
        private Label lblBank;
        private Label lblD1;
        private Label lblRolls;
        private Label lblD2;
        private Label lblSum;
        private Button btnReset;
    }
}