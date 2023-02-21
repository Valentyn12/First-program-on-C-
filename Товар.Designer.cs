namespace Lab1
{
    partial class Товар
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxТовар = new System.Windows.Forms.TextBox();
            this.textBoxЦіна = new System.Windows.Forms.TextBox();
            this.textBoxЦіна_закупівлі = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Товар";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ціна";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ціна закупівлі";
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(190, 71);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 4;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // textBoxТовар
            // 
            this.textBoxТовар.Location = new System.Drawing.Point(190, 114);
            this.textBoxТовар.Name = "textBoxТовар";
            this.textBoxТовар.Size = new System.Drawing.Size(100, 20);
            this.textBoxТовар.TabIndex = 5;
            // 
            // textBoxЦіна
            // 
            this.textBoxЦіна.Location = new System.Drawing.Point(190, 159);
            this.textBoxЦіна.Name = "textBoxЦіна";
            this.textBoxЦіна.Size = new System.Drawing.Size(100, 20);
            this.textBoxЦіна.TabIndex = 6;
            // 
            // textBoxЦіна_закупівлі
            // 
            this.textBoxЦіна_закупівлі.Location = new System.Drawing.Point(191, 206);
            this.textBoxЦіна_закупівлі.Name = "textBoxЦіна_закупівлі";
            this.textBoxЦіна_закупівлі.Size = new System.Drawing.Size(100, 20);
            this.textBoxЦіна_закупівлі.TabIndex = 7;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(129, 249);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(136, 40);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Товар
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 351);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxЦіна_закупівлі);
            this.Controls.Add(this.textBoxЦіна);
            this.Controls.Add(this.textBoxТовар);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Товар";
            this.Text = "Техніка";
            this.Load += new System.EventHandler(this.Товар_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxТовар;
        private System.Windows.Forms.TextBox textBoxЦіна;
        private System.Windows.Forms.TextBox textBoxЦіна_закупівлі;
        private System.Windows.Forms.Button buttonSave;
    }
}