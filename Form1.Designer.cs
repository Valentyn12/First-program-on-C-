namespace Lab1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonВидалитиБд = new System.Windows.Forms.Button();
            this.buttonСтворитиБд = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonЗмінитиТовари = new System.Windows.Forms.Button();
            this.buttonЗаповнитиТовари = new System.Windows.Forms.Button();
            this.buttonДобавитиТовари = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonВидалитиБд);
            this.groupBox1.Controls.Add(this.buttonСтворитиБд);
            this.groupBox1.Location = new System.Drawing.Point(28, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "База Даних";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonВидалитиБд
            // 
            this.buttonВидалитиБд.Location = new System.Drawing.Point(334, 82);
            this.buttonВидалитиБд.Name = "buttonВидалитиБд";
            this.buttonВидалитиБд.Size = new System.Drawing.Size(102, 23);
            this.buttonВидалитиБд.TabIndex = 2;
            this.buttonВидалитиБд.Text = "Видалити";
            this.buttonВидалитиБд.UseVisualStyleBackColor = true;
            this.buttonВидалитиБд.Click += new System.EventHandler(this.buttonВидалитиБд_Click);
            // 
            // buttonСтворитиБд
            // 
            this.buttonСтворитиБд.Location = new System.Drawing.Point(55, 82);
            this.buttonСтворитиБд.Name = "buttonСтворитиБд";
            this.buttonСтворитиБд.Size = new System.Drawing.Size(105, 23);
            this.buttonСтворитиБд.TabIndex = 1;
            this.buttonСтворитиБд.Text = "Створити";
            this.buttonСтворитиБд.UseVisualStyleBackColor = true;
            this.buttonСтворитиБд.Click += new System.EventHandler(this.buttonСтворитиБд_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonЗмінитиТовари);
            this.groupBox2.Controls.Add(this.buttonЗаповнитиТовари);
            this.groupBox2.Controls.Add(this.buttonДобавитиТовари);
            this.groupBox2.Location = new System.Drawing.Point(28, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 241);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Техніка";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // buttonЗмінитиТовари
            // 
            this.buttonЗмінитиТовари.Location = new System.Drawing.Point(21, 164);
            this.buttonЗмінитиТовари.Name = "buttonЗмінитиТовари";
            this.buttonЗмінитиТовари.Size = new System.Drawing.Size(75, 23);
            this.buttonЗмінитиТовари.TabIndex = 2;
            this.buttonЗмінитиТовари.Text = "Змінити";
            this.buttonЗмінитиТовари.UseVisualStyleBackColor = true;
            this.buttonЗмінитиТовари.Click += new System.EventHandler(this.buttonЗмінитиТовари_Click);
            // 
            // buttonЗаповнитиТовари
            // 
            this.buttonЗаповнитиТовари.Location = new System.Drawing.Point(21, 109);
            this.buttonЗаповнитиТовари.Name = "buttonЗаповнитиТовари";
            this.buttonЗаповнитиТовари.Size = new System.Drawing.Size(75, 23);
            this.buttonЗаповнитиТовари.TabIndex = 1;
            this.buttonЗаповнитиТовари.Text = "Заповнити";
            this.buttonЗаповнитиТовари.UseVisualStyleBackColor = true;
            this.buttonЗаповнитиТовари.Click += new System.EventHandler(this.buttonЗаповнитиТовари_Click);
            // 
            // buttonДобавитиТовари
            // 
            this.buttonДобавитиТовари.Location = new System.Drawing.Point(21, 57);
            this.buttonДобавитиТовари.Name = "buttonДобавитиТовари";
            this.buttonДобавитиТовари.Size = new System.Drawing.Size(75, 23);
            this.buttonДобавитиТовари.TabIndex = 0;
            this.buttonДобавитиТовари.Text = "Добавити";
            this.buttonДобавитиТовари.UseVisualStyleBackColor = true;
            this.buttonДобавитиТовари.Click += new System.EventHandler(this.buttonДобавитиТовари_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Побутова Техніка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonСтворитиБд;
        private System.Windows.Forms.Button buttonВидалитиБд;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonЗмінитиТовари;
        private System.Windows.Forms.Button buttonЗаповнитиТовари;
        private System.Windows.Forms.Button buttonДобавитиТовари;
    }
}

