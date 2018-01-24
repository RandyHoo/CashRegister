namespace CashRegister
{
    partial class MainMenuForm
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
            this.MCInsertButton = new System.Windows.Forms.Button();
            this.MCLogViewButton = new System.Windows.Forms.Button();
            this.MCAggregateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MCInsertButton
            // 
            this.MCInsertButton.Location = new System.Drawing.Point(12, 12);
            this.MCInsertButton.Name = "MCInsertButton";
            this.MCInsertButton.Size = new System.Drawing.Size(114, 28);
            this.MCInsertButton.TabIndex = 0;
            this.MCInsertButton.Text = "売上入力";
            this.MCInsertButton.UseVisualStyleBackColor = true;
            this.MCInsertButton.Click += new System.EventHandler(this.MCInsertButton_Click);
            // 
            // MCLogViewButton
            // 
            this.MCLogViewButton.Location = new System.Drawing.Point(132, 12);
            this.MCLogViewButton.Name = "MCLogViewButton";
            this.MCLogViewButton.Size = new System.Drawing.Size(114, 28);
            this.MCLogViewButton.TabIndex = 1;
            this.MCLogViewButton.Text = "売上履歴";
            this.MCLogViewButton.UseVisualStyleBackColor = true;
            this.MCLogViewButton.Click += new System.EventHandler(this.MCLogViewButton_Click);
            // 
            // MCAggregateButton
            // 
            this.MCAggregateButton.Location = new System.Drawing.Point(12, 46);
            this.MCAggregateButton.Name = "MCAggregateButton";
            this.MCAggregateButton.Size = new System.Drawing.Size(114, 28);
            this.MCAggregateButton.TabIndex = 2;
            this.MCAggregateButton.Text = "売上集計";
            this.MCAggregateButton.UseVisualStyleBackColor = true;
            this.MCAggregateButton.Click += new System.EventHandler(this.MCAggregateButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 85);
            this.Controls.Add(this.MCAggregateButton);
            this.Controls.Add(this.MCLogViewButton);
            this.Controls.Add(this.MCInsertButton);
            this.Name = "MainMenuForm";
            this.Text = "メインメニュー";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MCInsertButton;
        private System.Windows.Forms.Button MCLogViewButton;
        private System.Windows.Forms.Button MCAggregateButton;
    }
}