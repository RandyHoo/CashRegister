namespace CashRegister
{
    partial class AggregateForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.AggregateResultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackMainMenuButton = new System.Windows.Forms.Button();
            this.GetAggregateButton = new System.Windows.Forms.Button();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "～";
            // 
            // AggregateResultLabel
            // 
            this.AggregateResultLabel.AutoSize = true;
            this.AggregateResultLabel.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.AggregateResultLabel.Location = new System.Drawing.Point(16, 101);
            this.AggregateResultLabel.Name = "AggregateResultLabel";
            this.AggregateResultLabel.Size = new System.Drawing.Size(35, 18);
            this.AggregateResultLabel.TabIndex = 11;
            this.AggregateResultLabel.Text = "￥0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "合計金額";
            // 
            // BackMainMenuButton
            // 
            this.BackMainMenuButton.Location = new System.Drawing.Point(207, 141);
            this.BackMainMenuButton.Name = "BackMainMenuButton";
            this.BackMainMenuButton.Size = new System.Drawing.Size(107, 26);
            this.BackMainMenuButton.TabIndex = 9;
            this.BackMainMenuButton.Text = "メインメニューに戻る";
            this.BackMainMenuButton.UseVisualStyleBackColor = true;
            this.BackMainMenuButton.Click += new System.EventHandler(this.BackMainMenuButton_Click);
            // 
            // GetAggregateButton
            // 
            this.GetAggregateButton.Location = new System.Drawing.Point(205, 51);
            this.GetAggregateButton.Name = "GetAggregateButton";
            this.GetAggregateButton.Size = new System.Drawing.Size(86, 23);
            this.GetAggregateButton.TabIndex = 12;
            this.GetAggregateButton.Text = "売上取得";
            this.GetAggregateButton.UseVisualStyleBackColor = true;
            this.GetAggregateButton.Click += new System.EventHandler(this.GetAggregateButton_Click);
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Location = new System.Drawing.Point(12, 24);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(125, 19);
            this.StartDateTimePicker.TabIndex = 13;
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Location = new System.Drawing.Point(166, 24);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(125, 19);
            this.EndDateTimePicker.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "期間";
            // 
            // AggregateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 179);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.StartDateTimePicker);
            this.Controls.Add(this.GetAggregateButton);
            this.Controls.Add(this.AggregateResultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackMainMenuButton);
            this.Controls.Add(this.label4);
            this.Name = "AggregateForm";
            this.Text = "売上集計";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AggregateResultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackMainMenuButton;
        private System.Windows.Forms.Button GetAggregateButton;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.Label label2;
    }
}