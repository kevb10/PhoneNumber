namespace Ksu.Cis300.MatchCalls
{
    partial class UserInterface
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
            this.uxLoadFile1 = new System.Windows.Forms.Button();
            this.uxLoadFile2 = new System.Windows.Forms.Button();
            this.uxFile1Status = new System.Windows.Forms.TextBox();
            this.uxFile2Status = new System.Windows.Forms.TextBox();
            this.uxTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxFind = new System.Windows.Forms.Button();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.uxValue)).BeginInit();
            this.SuspendLayout();
            // 
            // uxLoadFile1
            // 
            this.uxLoadFile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uxLoadFile1.Location = new System.Drawing.Point(12, 12);
            this.uxLoadFile1.Name = "uxLoadFile1";
            this.uxLoadFile1.Size = new System.Drawing.Size(91, 35);
            this.uxLoadFile1.TabIndex = 0;
            this.uxLoadFile1.Text = "Load File 1";
            this.uxLoadFile1.UseVisualStyleBackColor = true;
            this.uxLoadFile1.Click += new System.EventHandler(this.uxLoadFile1_Click);
            // 
            // uxLoadFile2
            // 
            this.uxLoadFile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uxLoadFile2.Location = new System.Drawing.Point(12, 53);
            this.uxLoadFile2.Name = "uxLoadFile2";
            this.uxLoadFile2.Size = new System.Drawing.Size(91, 34);
            this.uxLoadFile2.TabIndex = 1;
            this.uxLoadFile2.Text = "Load File 2";
            this.uxLoadFile2.UseVisualStyleBackColor = true;
            this.uxLoadFile2.Click += new System.EventHandler(this.uxLoadFile2_Click);
            // 
            // uxFile1Status
            // 
            this.uxFile1Status.Location = new System.Drawing.Point(134, 20);
            this.uxFile1Status.Name = "uxFile1Status";
            this.uxFile1Status.ReadOnly = true;
            this.uxFile1Status.Size = new System.Drawing.Size(100, 20);
            this.uxFile1Status.TabIndex = 2;
            // 
            // uxFile2Status
            // 
            this.uxFile2Status.Location = new System.Drawing.Point(134, 61);
            this.uxFile2Status.Name = "uxFile2Status";
            this.uxFile2Status.ReadOnly = true;
            this.uxFile2Status.Size = new System.Drawing.Size(100, 20);
            this.uxFile2Status.TabIndex = 3;
            // 
            // uxTextBox
            // 
            this.uxTextBox.Location = new System.Drawing.Point(261, 12);
            this.uxTextBox.Multiline = true;
            this.uxTextBox.Name = "uxTextBox";
            this.uxTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxTextBox.Size = new System.Drawing.Size(310, 359);
            this.uxTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 132);
            this.label1.MaximumSize = new System.Drawing.Size(150, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Minumum calls per number:";
            // 
            // uxFind
            // 
            this.uxFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxFind.Location = new System.Drawing.Point(70, 214);
            this.uxFind.Name = "uxFind";
            this.uxFind.Size = new System.Drawing.Size(109, 40);
            this.uxFind.TabIndex = 7;
            this.uxFind.Text = "Find Overlaps";
            this.uxFind.UseVisualStyleBackColor = true;
            this.uxFind.Click += new System.EventHandler(this.uxFind_Click);
            // 
            // uxOpenDialog
            // 
            this.uxOpenDialog.FileName = "openFileDialog";
            // 
            // uxValue
            // 
            this.uxValue.Location = new System.Drawing.Point(164, 151);
            this.uxValue.Name = "uxValue";
            this.uxValue.Size = new System.Drawing.Size(70, 20);
            this.uxValue.TabIndex = 8;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 383);
            this.Controls.Add(this.uxValue);
            this.Controls.Add(this.uxFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxTextBox);
            this.Controls.Add(this.uxFile2Status);
            this.Controls.Add(this.uxFile1Status);
            this.Controls.Add(this.uxLoadFile2);
            this.Controls.Add(this.uxLoadFile1);
            this.Name = "UserInterface";
            this.Text = "Phone Number";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxLoadFile1;
        private System.Windows.Forms.Button uxLoadFile2;
        private System.Windows.Forms.TextBox uxFile1Status;
        private System.Windows.Forms.TextBox uxFile2Status;
        private System.Windows.Forms.TextBox uxTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxFind;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
        private System.Windows.Forms.NumericUpDown uxValue;
    }
}

