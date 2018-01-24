namespace CashRegister
{
    partial class LogViewForm
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
            this.BackMainMenuButton = new System.Windows.Forms.Button();
            this.LogGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.LogGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BackMainMenuButton
            // 
            this.BackMainMenuButton.Location = new System.Drawing.Point(466, 320);
            this.BackMainMenuButton.Name = "BackMainMenuButton";
            this.BackMainMenuButton.Size = new System.Drawing.Size(107, 26);
            this.BackMainMenuButton.TabIndex = 1;
            this.BackMainMenuButton.Text = "メインメニューに戻る";
            this.BackMainMenuButton.UseVisualStyleBackColor = true;
            this.BackMainMenuButton.Click += new System.EventHandler(this.BackMainMenuButton_Click);
            // 
            // LogGridView
            // 
            this.LogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogGridView.Location = new System.Drawing.Point(12, 12);
            this.LogGridView.Name = "LogGridView";
            this.LogGridView.RowTemplate.Height = 21;
            this.LogGridView.Size = new System.Drawing.Size(448, 334);
            this.LogGridView.TabIndex = 2;
            // 
            // LogViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 358);
            this.Controls.Add(this.LogGridView);
            this.Controls.Add(this.BackMainMenuButton);
            this.Name = "LogViewForm";
            this.Text = "売上履歴";
            ((System.ComponentModel.ISupportInitialize)(this.LogGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackMainMenuButton;
        private System.Windows.Forms.DataGridView LogGridView;
    }
}