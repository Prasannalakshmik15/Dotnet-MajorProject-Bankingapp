﻿namespace BankingAppCS
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtName = new TextBox();
            txtAdd = new TextBox();
            txtBalance = new TextBox();
            txtAcc = new TextBox();
            dtDate = new DateTimePicker();
            btnDeposit = new Button();
            btnWithd = new Button();
            btnShow = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(166, 69);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(166, 150);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(166, 247);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 2;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(166, 349);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 3;
            label4.Text = "Balance";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(166, 436);
            label5.Name = "label5";
            label5.Size = new Size(51, 25);
            label5.TabIndex = 4;
            label5.Text = "Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(166, 516);
            label6.Name = "label6";
            label6.Size = new Size(155, 25);
            label6.TabIndex = 5;
            label6.Text = "Account Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(336, 69);
            label7.Name = "label7";
            label7.Size = new Size(233, 25);
            label7.TabIndex = 6;
            label7.Text = "Auto Generated by System";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(333, 142);
            txtName.Name = "txtName";
            txtName.Size = new Size(285, 33);
            txtName.TabIndex = 7;
            // 
            // txtAdd
            // 
            txtAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdd.Location = new Point(336, 247);
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(277, 33);
            txtAdd.TabIndex = 8;
            // 
            // txtBalance
            // 
            txtBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBalance.Location = new Point(336, 341);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(277, 33);
            txtBalance.TabIndex = 9;
            // 
            // txtAcc
            // 
            txtAcc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAcc.Location = new Point(336, 516);
            txtAcc.Name = "txtAcc";
            txtAcc.Size = new Size(277, 33);
            txtAcc.TabIndex = 10;
            txtAcc.Text = "Auto Generated by System";
            // 
            // dtDate
            // 
            dtDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtDate.Location = new Point(336, 436);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(277, 33);
            dtDate.TabIndex = 11;
            // 
            // btnDeposit
            // 
            btnDeposit.BackColor = Color.FromArgb(0, 192, 0);
            btnDeposit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeposit.ForeColor = SystemColors.Control;
            btnDeposit.Location = new Point(187, 641);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(96, 48);
            btnDeposit.TabIndex = 12;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = false;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithd
            // 
            btnWithd.BackColor = Color.Red;
            btnWithd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnWithd.ForeColor = SystemColors.ButtonFace;
            btnWithd.Location = new Point(362, 641);
            btnWithd.Name = "btnWithd";
            btnWithd.Size = new Size(106, 48);
            btnWithd.TabIndex = 13;
            btnWithd.Text = "Withdraw";
            btnWithd.UseVisualStyleBackColor = false;
            btnWithd.Click += btnWithd_Click;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.Cyan;
            btnShow.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnShow.Location = new Point(531, 641);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(87, 48);
            btnShow.TabIndex = 14;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(770, 748);
            Controls.Add(btnShow);
            Controls.Add(btnWithd);
            Controls.Add(btnDeposit);
            Controls.Add(dtDate);
            Controls.Add(txtAcc);
            Controls.Add(txtBalance);
            Controls.Add(txtAdd);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Banking App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtName;
        private TextBox txtAdd;
        private TextBox txtBalance;
        private TextBox txtAcc;
        private DateTimePicker dtDate;
        private Button btnDeposit;
        private Button btnWithd;
        private Button btnShow;
    }
}
