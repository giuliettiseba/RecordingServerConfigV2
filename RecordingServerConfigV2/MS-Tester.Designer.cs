﻿namespace RecordingServerConfigV2
{
    partial class MS_Tester
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
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.buttonRetryTest = new System.Windows.Forms.Button();
            this.key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.AllowUserToAddRows = false;
            this.dataGridViewResults.AllowUserToDeleteRows = false;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.key,
            this.value});
            this.dataGridViewResults.Location = new System.Drawing.Point(12, 24);
            this.dataGridViewResults.MultiSelect = false;
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.ReadOnly = true;
            this.dataGridViewResults.RowHeadersVisible = false;
            this.dataGridViewResults.ShowEditingIcon = false;
            this.dataGridViewResults.Size = new System.Drawing.Size(773, 347);
            this.dataGridViewResults.TabIndex = 0;
           // 
            // buttonRetryTest
            // 
            this.buttonRetryTest.Location = new System.Drawing.Point(572, 377);
            this.buttonRetryTest.Name = "buttonRetryTest";
            this.buttonRetryTest.Size = new System.Drawing.Size(213, 61);
            this.buttonRetryTest.TabIndex = 1;
            this.buttonRetryTest.Text = "Retry Test";
            this.buttonRetryTest.UseVisualStyleBackColor = true;
            this.buttonRetryTest.Click += new System.EventHandler(this.buttonRetryTest_ClickAsync);
            // 
            // key
            // 
            this.key.HeaderText = "key";
            this.key.Name = "key";
            this.key.ReadOnly = true;
            this.key.Width = 200;
            // 
            // value
            // 
            this.value.HeaderText = "value";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            this.value.Width = 560;
            // 
            // MS_Tester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRetryTest);
            this.Controls.Add(this.dataGridViewResults);
            this.Name = "MS_Tester";
            this.Text = "MS_Tester";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.Button buttonRetryTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn key;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
    }
}