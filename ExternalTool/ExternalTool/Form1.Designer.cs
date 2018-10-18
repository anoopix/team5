namespace ExternalTool
{
    partial class ExternalTool
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
            this.moneyTb = new System.Windows.Forms.TextBox();
            this.strTb = new System.Windows.Forms.TextBox();
            this.intelTb = new System.Windows.Forms.TextBox();
            this.charmTb = new System.Windows.Forms.TextBox();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.strLabel = new System.Windows.Forms.Label();
            this.intelLabel = new System.Windows.Forms.Label();
            this.charmLabel = new System.Windows.Forms.Label();
            this.assignButton = new System.Windows.Forms.Button();
            this.clrButton = new System.Windows.Forms.Button();
            this.generalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // moneyTb
            // 
            this.moneyTb.Location = new System.Drawing.Point(70, 81);
            this.moneyTb.Name = "moneyTb";
            this.moneyTb.Size = new System.Drawing.Size(100, 20);
            this.moneyTb.TabIndex = 0;
            // 
            // strTb
            // 
            this.strTb.Location = new System.Drawing.Point(70, 123);
            this.strTb.Name = "strTb";
            this.strTb.Size = new System.Drawing.Size(100, 20);
            this.strTb.TabIndex = 1;
            // 
            // intelTb
            // 
            this.intelTb.Location = new System.Drawing.Point(70, 166);
            this.intelTb.Name = "intelTb";
            this.intelTb.Size = new System.Drawing.Size(100, 20);
            this.intelTb.TabIndex = 2;
            // 
            // charmTb
            // 
            this.charmTb.Location = new System.Drawing.Point(70, 210);
            this.charmTb.Name = "charmTb";
            this.charmTb.Size = new System.Drawing.Size(100, 20);
            this.charmTb.TabIndex = 3;
            this.charmTb.TextChanged += new System.EventHandler(this.charmTb_TextChanged);
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.Location = new System.Drawing.Point(22, 84);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(42, 13);
            this.MoneyLabel.TabIndex = 4;
            this.MoneyLabel.Text = "Money:";
            // 
            // strLabel
            // 
            this.strLabel.AutoSize = true;
            this.strLabel.Location = new System.Drawing.Point(14, 126);
            this.strLabel.Name = "strLabel";
            this.strLabel.Size = new System.Drawing.Size(50, 13);
            this.strLabel.TabIndex = 5;
            this.strLabel.Text = "Strength:";
            this.strLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // intelLabel
            // 
            this.intelLabel.AutoSize = true;
            this.intelLabel.Location = new System.Drawing.Point(0, 169);
            this.intelLabel.Name = "intelLabel";
            this.intelLabel.Size = new System.Drawing.Size(64, 13);
            this.intelLabel.TabIndex = 6;
            this.intelLabel.Text = "Intelligence:";
            // 
            // charmLabel
            // 
            this.charmLabel.AutoSize = true;
            this.charmLabel.Location = new System.Drawing.Point(16, 213);
            this.charmLabel.Name = "charmLabel";
            this.charmLabel.Size = new System.Drawing.Size(40, 13);
            this.charmLabel.TabIndex = 7;
            this.charmLabel.Text = "Charm:";
            // 
            // assignButton
            // 
            this.assignButton.Location = new System.Drawing.Point(262, 81);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(110, 45);
            this.assignButton.TabIndex = 8;
            this.assignButton.Text = "Assign";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // clrButton
            // 
            this.clrButton.Location = new System.Drawing.Point(262, 185);
            this.clrButton.Name = "clrButton";
            this.clrButton.Size = new System.Drawing.Size(110, 45);
            this.clrButton.TabIndex = 9;
            this.clrButton.Text = "Clear";
            this.clrButton.UseVisualStyleBackColor = true;
            this.clrButton.Click += new System.EventHandler(this.clrButton_Click);
            // 
            // generalLabel
            // 
            this.generalLabel.AutoSize = true;
            this.generalLabel.Location = new System.Drawing.Point(22, 35);
            this.generalLabel.Name = "generalLabel";
            this.generalLabel.Size = new System.Drawing.Size(80, 13);
            this.generalLabel.TabIndex = 10;
            this.generalLabel.Text = "Character Stats";
            // 
            // ExternalTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 309);
            this.Controls.Add(this.generalLabel);
            this.Controls.Add(this.clrButton);
            this.Controls.Add(this.assignButton);
            this.Controls.Add(this.charmLabel);
            this.Controls.Add(this.intelLabel);
            this.Controls.Add(this.strLabel);
            this.Controls.Add(this.MoneyLabel);
            this.Controls.Add(this.charmTb);
            this.Controls.Add(this.intelTb);
            this.Controls.Add(this.strTb);
            this.Controls.Add(this.moneyTb);
            this.Name = "ExternalTool";
            this.Text = "External Stat Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox moneyTb;
        private System.Windows.Forms.TextBox strTb;
        private System.Windows.Forms.TextBox intelTb;
        private System.Windows.Forms.TextBox charmTb;
        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.Label strLabel;
        private System.Windows.Forms.Label intelLabel;
        private System.Windows.Forms.Label charmLabel;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.Button clrButton;
        private System.Windows.Forms.Label generalLabel;
    }
}

