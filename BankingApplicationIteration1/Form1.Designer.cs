
namespace BankingApplicationIteration1
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
            this.listBoxWithAccounts = new System.Windows.Forms.ListBox();
            this.getAccountInfo = new System.Windows.Forms.Button();
            this.displayForAccountInfo = new System.Windows.Forms.Label();
            this.withdrawlMoneyButton = new System.Windows.Forms.Button();
            this.depositMoneyButton = new System.Windows.Forms.Button();
            this.addIntrestButton = new System.Windows.Forms.Button();
            this.moneyEntryBox = new System.Windows.Forms.TextBox();
            this.newBalanceOutput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxWithAccounts
            // 
            this.listBoxWithAccounts.FormattingEnabled = true;
            this.listBoxWithAccounts.ItemHeight = 20;
            this.listBoxWithAccounts.Location = new System.Drawing.Point(282, 12);
            this.listBoxWithAccounts.Name = "listBoxWithAccounts";
            this.listBoxWithAccounts.Size = new System.Drawing.Size(591, 104);
            this.listBoxWithAccounts.TabIndex = 0;
            this.listBoxWithAccounts.SelectedIndexChanged += new System.EventHandler(this.listBoxWithAccounts_SelectedIndexChanged);
            // 
            // getAccountInfo
            // 
            this.getAccountInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.getAccountInfo.Location = new System.Drawing.Point(13, 13);
            this.getAccountInfo.Name = "getAccountInfo";
            this.getAccountInfo.Size = new System.Drawing.Size(250, 50);
            this.getAccountInfo.TabIndex = 1;
            this.getAccountInfo.Text = "Get Info about Selected Account";
            this.getAccountInfo.UseVisualStyleBackColor = true;
            this.getAccountInfo.Click += new System.EventHandler(this.getAccountInfo_Click);
            // 
            // displayForAccountInfo
            // 
            this.displayForAccountInfo.AutoSize = true;
            this.displayForAccountInfo.Location = new System.Drawing.Point(282, 122);
            this.displayForAccountInfo.Name = "displayForAccountInfo";
            this.displayForAccountInfo.Size = new System.Drawing.Size(0, 20);
            this.displayForAccountInfo.TabIndex = 3;
            // 
            // withdrawlMoneyButton
            // 
            this.withdrawlMoneyButton.Location = new System.Drawing.Point(13, 85);
            this.withdrawlMoneyButton.Name = "withdrawlMoneyButton";
            this.withdrawlMoneyButton.Size = new System.Drawing.Size(250, 50);
            this.withdrawlMoneyButton.TabIndex = 4;
            this.withdrawlMoneyButton.Text = "Withdraw Money";
            this.withdrawlMoneyButton.UseVisualStyleBackColor = true;
            this.withdrawlMoneyButton.Click += new System.EventHandler(this.withdrawlMoneyButton_Click);
            // 
            // depositMoneyButton
            // 
            this.depositMoneyButton.Location = new System.Drawing.Point(13, 141);
            this.depositMoneyButton.Name = "depositMoneyButton";
            this.depositMoneyButton.Size = new System.Drawing.Size(250, 50);
            this.depositMoneyButton.TabIndex = 5;
            this.depositMoneyButton.Text = "Deposit Money";
            this.depositMoneyButton.UseVisualStyleBackColor = true;
            this.depositMoneyButton.Click += new System.EventHandler(this.depositMoneyButton_Click);
            // 
            // addIntrestButton
            // 
            this.addIntrestButton.Location = new System.Drawing.Point(13, 197);
            this.addIntrestButton.Name = "addIntrestButton";
            this.addIntrestButton.Size = new System.Drawing.Size(250, 50);
            this.addIntrestButton.TabIndex = 6;
            this.addIntrestButton.Text = "Add Interest";
            this.addIntrestButton.UseVisualStyleBackColor = true;
            this.addIntrestButton.Click += new System.EventHandler(this.addIntrestButton_Click);
            // 
            // moneyEntryBox
            // 
            this.moneyEntryBox.Location = new System.Drawing.Point(282, 179);
            this.moneyEntryBox.Name = "moneyEntryBox";
            this.moneyEntryBox.Size = new System.Drawing.Size(154, 27);
            this.moneyEntryBox.TabIndex = 9;
            // 
            // newBalanceOutput
            // 
            this.newBalanceOutput.AutoSize = true;
            this.newBalanceOutput.Location = new System.Drawing.Point(406, 212);
            this.newBalanceOutput.Name = "newBalanceOutput";
            this.newBalanceOutput.Size = new System.Drawing.Size(0, 20);
            this.newBalanceOutput.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(282, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enter Dollar Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(282, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "New Balance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 265);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newBalanceOutput);
            this.Controls.Add(this.moneyEntryBox);
            this.Controls.Add(this.addIntrestButton);
            this.Controls.Add(this.depositMoneyButton);
            this.Controls.Add(this.withdrawlMoneyButton);
            this.Controls.Add(this.displayForAccountInfo);
            this.Controls.Add(this.getAccountInfo);
            this.Controls.Add(this.listBoxWithAccounts);
            this.Name = "Form1";
            this.Text = "Banking Application Interation 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWithAccounts;
        private System.Windows.Forms.Button getAccountInfo;
        private System.Windows.Forms.Label displayForAccountInfo;
        private System.Windows.Forms.Button withdrawlMoneyButton;
        private System.Windows.Forms.Button depositMoneyButton;
        private System.Windows.Forms.Button addIntrestButton;
        private System.Windows.Forms.TextBox moneyEntryBox;
        private System.Windows.Forms.Label newBalanceOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

