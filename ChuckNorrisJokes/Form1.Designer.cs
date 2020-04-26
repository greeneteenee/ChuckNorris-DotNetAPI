namespace ChuckNorrisJokes
{
    partial class Form1
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
            this.btnJoke = new System.Windows.Forms.Button();
            this.txtJoke = new System.Windows.Forms.TextBox();
            this.cboBoxCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnJoke
            // 
            this.btnJoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoke.Location = new System.Drawing.Point(286, 161);
            this.btnJoke.Name = "btnJoke";
            this.btnJoke.Size = new System.Drawing.Size(253, 146);
            this.btnJoke.TabIndex = 0;
            this.btnJoke.Text = "Get random joke";
            this.btnJoke.UseVisualStyleBackColor = true;
            this.btnJoke.Click += new System.EventHandler(this.btnJoke_Click);
            // 
            // txtJoke
            // 
            this.txtJoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJoke.Location = new System.Drawing.Point(286, 12);
            this.txtJoke.Multiline = true;
            this.txtJoke.Name = "txtJoke";
            this.txtJoke.Size = new System.Drawing.Size(253, 143);
            this.txtJoke.TabIndex = 1;
            // 
            // cboBoxCategory
            // 
            this.cboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxCategory.FormattingEnabled = true;
            this.cboBoxCategory.Location = new System.Drawing.Point(286, 323);
            this.cboBoxCategory.Name = "cboBoxCategory";
            this.cboBoxCategory.Size = new System.Drawing.Size(253, 21);
            this.cboBoxCategory.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboBoxCategory);
            this.Controls.Add(this.txtJoke);
            this.Controls.Add(this.btnJoke);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJoke;
        private System.Windows.Forms.TextBox txtJoke;
        private System.Windows.Forms.ComboBox cboBoxCategory;
    }
}

