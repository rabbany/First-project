namespace BookInformationAPP.UI
{
    partial class BookCatagorieUI
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
            this.bookCatagoriesaveButton = new System.Windows.Forms.Button();
            this.bookCatagorieTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bookCatagoriesaveButton
            // 
            this.bookCatagoriesaveButton.Location = new System.Drawing.Point(381, 118);
            this.bookCatagoriesaveButton.Name = "bookCatagoriesaveButton";
            this.bookCatagoriesaveButton.Size = new System.Drawing.Size(75, 23);
            this.bookCatagoriesaveButton.TabIndex = 10;
            this.bookCatagoriesaveButton.Text = "Save";
            this.bookCatagoriesaveButton.UseVisualStyleBackColor = true;
            this.bookCatagoriesaveButton.Click += new System.EventHandler(this.bookCatagoriesaveButton_Click);
            // 
            // bookCatagorieTextBox
            // 
            this.bookCatagorieTextBox.Location = new System.Drawing.Point(164, 72);
            this.bookCatagorieTextBox.Name = "bookCatagorieTextBox";
            this.bookCatagorieTextBox.Size = new System.Drawing.Size(282, 20);
            this.bookCatagorieTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Book Catagorie";
            // 
            // BookCatagorieUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 164);
            this.Controls.Add(this.bookCatagoriesaveButton);
            this.Controls.Add(this.bookCatagorieTextBox);
            this.Controls.Add(this.label1);
            this.Name = "BookCatagorieUI";
            this.Text = "BookCatagorieUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bookCatagoriesaveButton;
        private System.Windows.Forms.TextBox bookCatagorieTextBox;
        private System.Windows.Forms.Label label1;
    }
}