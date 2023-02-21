namespace Lab1
{
    partial class formТехніка
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
            this.listBoxТовари = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxСередня_ціна = new System.Windows.Forms.TextBox();
            this.buttonЗмінити = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxТовари
            // 
            this.listBoxТовари.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxТовари.FormattingEnabled = true;
            this.listBoxТовари.ItemHeight = 15;
            this.listBoxТовари.Location = new System.Drawing.Point(35, 23);
            this.listBoxТовари.Name = "listBoxТовари";
            this.listBoxТовари.Size = new System.Drawing.Size(379, 229);
            this.listBoxТовари.TabIndex = 0;
            this.listBoxТовари.SelectedIndexChanged += new System.EventHandler(this.listBoxТовари_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cередня ціна";
            // 
            // textBoxСередня_ціна
            // 
            this.textBoxСередня_ціна.Location = new System.Drawing.Point(188, 277);
            this.textBoxСередня_ціна.Name = "textBoxСередня_ціна";
            this.textBoxСередня_ціна.Size = new System.Drawing.Size(100, 20);
            this.textBoxСередня_ціна.TabIndex = 2;
            this.textBoxСередня_ціна.TextChanged += new System.EventHandler(this.textBoxСередня_ціна_TextChanged);
            // 
            // buttonЗмінити
            // 
            this.buttonЗмінити.Location = new System.Drawing.Point(35, 313);
            this.buttonЗмінити.Name = "buttonЗмінити";
            this.buttonЗмінити.Size = new System.Drawing.Size(75, 23);
            this.buttonЗмінити.TabIndex = 3;
            this.buttonЗмінити.Text = "Змінити";
            this.buttonЗмінити.UseVisualStyleBackColor = true;
            this.buttonЗмінити.Click += new System.EventHandler(this.buttonЗмінити_Click);
            // 
            // formТехніка
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 366);
            this.Controls.Add(this.buttonЗмінити);
            this.Controls.Add(this.textBoxСередня_ціна);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxТовари);
            this.Name = "formТехніка";
            this.Text = "Техніка";
            this.Load += new System.EventHandler(this.formТехніка_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxТовари;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxСередня_ціна;
        private System.Windows.Forms.Button buttonЗмінити;
    }
}