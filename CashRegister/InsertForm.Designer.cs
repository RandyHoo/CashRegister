namespace CashRegister
{
    partial class InsertForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.BackMainMenuButton = new System.Windows.Forms.Button();
            this.InsertDataGrid = new System.Windows.Forms.DataGridView();
            this.InputLogButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InsertDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BackMainMenuButton
            // 
            this.BackMainMenuButton.Location = new System.Drawing.Point(277, 318);
            this.BackMainMenuButton.Name = "BackMainMenuButton";
            this.BackMainMenuButton.Size = new System.Drawing.Size(107, 26);
            this.BackMainMenuButton.TabIndex = 1;
            this.BackMainMenuButton.Text = "メインメニューに戻る";
            this.BackMainMenuButton.UseVisualStyleBackColor = true;
            this.BackMainMenuButton.Click += new System.EventHandler(this.BackMainMenuButton_Click);
            // 
            // InsertDataGrid
            // 
            this.InsertDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InsertDataGrid.Location = new System.Drawing.Point(12, 12);
            this.InsertDataGrid.Name = "InsertDataGrid";
            this.InsertDataGrid.RowTemplate.Height = 21;
            this.InsertDataGrid.Size = new System.Drawing.Size(372, 258);
            this.InsertDataGrid.TabIndex = 2;
            // 
            // InputLogButton
            // 
            this.InputLogButton.Location = new System.Drawing.Point(277, 276);
            this.InputLogButton.Name = "InputLogButton";
            this.InputLogButton.Size = new System.Drawing.Size(107, 26);
            this.InputLogButton.TabIndex = 3;
            this.InputLogButton.Text = "入力";
            this.InputLogButton.UseVisualStyleBackColor = true;
            this.InputLogButton.Click += new System.EventHandler(this.InputLogButton_Click);
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 355);
            this.Controls.Add(this.InputLogButton);
            this.Controls.Add(this.InsertDataGrid);
            this.Controls.Add(this.BackMainMenuButton);
            this.Name = "InsertForm";
            this.Text = "売上入力";
            ((System.ComponentModel.ISupportInitialize)(this.InsertDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackMainMenuButton;
        private System.Windows.Forms.DataGridView InsertDataGrid;
        private System.Windows.Forms.Button InputLogButton;
    }
}

