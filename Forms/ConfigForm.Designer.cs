namespace Forms
{
    partial class ConfigForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numColumns = new System.Windows.Forms.NumericUpDown();
            this.numRows = new System.Windows.Forms.NumericUpDown();
            this.numPictures = new System.Windows.Forms.NumericUpDown();
            this.numPairs = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPictures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPairs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(127, 155);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "OK";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of columns";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of rows";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of pictures";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number of pairs";
            // 
            // numColumns
            // 
            this.numColumns.Location = new System.Drawing.Point(12, 34);
            this.numColumns.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numColumns.Name = "numColumns";
            this.numColumns.Size = new System.Drawing.Size(95, 20);
            this.numColumns.TabIndex = 9;
            this.numColumns.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // numRows
            // 
            this.numRows.Location = new System.Drawing.Point(230, 34);
            this.numRows.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRows.Name = "numRows";
            this.numRows.Size = new System.Drawing.Size(95, 20);
            this.numRows.TabIndex = 10;
            this.numRows.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numPictures
            // 
            this.numPictures.Location = new System.Drawing.Point(12, 113);
            this.numPictures.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPictures.Name = "numPictures";
            this.numPictures.Size = new System.Drawing.Size(95, 20);
            this.numPictures.TabIndex = 11;
            this.numPictures.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numPairs
            // 
            this.numPairs.Location = new System.Drawing.Point(229, 113);
            this.numPairs.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPairs.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPairs.Name = "numPairs";
            this.numPairs.Size = new System.Drawing.Size(95, 20);
            this.numPairs.TabIndex = 12;
            this.numPairs.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 181);
            this.Controls.Add(this.numPairs);
            this.Controls.Add(this.numPictures);
            this.Controls.Add(this.numRows);
            this.Controls.Add(this.numColumns);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.numColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPictures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPairs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numColumns;
        private System.Windows.Forms.NumericUpDown numRows;
        private System.Windows.Forms.NumericUpDown numPictures;
        private System.Windows.Forms.NumericUpDown numPairs;
    }
}