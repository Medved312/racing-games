namespace игра
{
    partial class Save
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
            this.save1 = new System.Windows.Forms.Button();
            this.Download1 = new System.Windows.Forms.Button();
            this.save2 = new System.Windows.Forms.Button();
            this.Download2 = new System.Windows.Forms.Button();
            this.save3 = new System.Windows.Forms.Button();
            this.Download3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // save1
            // 
            this.save1.Location = new System.Drawing.Point(167, 56);
            this.save1.Name = "save1";
            this.save1.Size = new System.Drawing.Size(85, 23);
            this.save1.TabIndex = 0;
            this.save1.Text = "Сохранение 1";
            this.save1.UseVisualStyleBackColor = true;
            this.save1.Click += new System.EventHandler(this.save1_Click);
            // 
            // Download1
            // 
            this.Download1.Location = new System.Drawing.Point(449, 56);
            this.Download1.Name = "Download1";
            this.Download1.Size = new System.Drawing.Size(75, 23);
            this.Download1.TabIndex = 1;
            this.Download1.Text = "Загрузить";
            this.Download1.UseVisualStyleBackColor = true;
            // 
            // save2
            // 
            this.save2.Location = new System.Drawing.Point(167, 106);
            this.save2.Name = "save2";
            this.save2.Size = new System.Drawing.Size(85, 23);
            this.save2.TabIndex = 2;
            this.save2.Text = "Сохранение 2";
            this.save2.UseVisualStyleBackColor = true;
            // 
            // Download2
            // 
            this.Download2.Location = new System.Drawing.Point(449, 106);
            this.Download2.Name = "Download2";
            this.Download2.Size = new System.Drawing.Size(75, 23);
            this.Download2.TabIndex = 3;
            this.Download2.Text = "Загрузить";
            this.Download2.UseVisualStyleBackColor = true;
            // 
            // save3
            // 
            this.save3.Location = new System.Drawing.Point(167, 158);
            this.save3.Name = "save3";
            this.save3.Size = new System.Drawing.Size(85, 23);
            this.save3.TabIndex = 4;
            this.save3.Text = "Сохранение 3";
            this.save3.UseVisualStyleBackColor = true;
            // 
            // Download3
            // 
            this.Download3.Location = new System.Drawing.Point(449, 158);
            this.Download3.Name = "Download3";
            this.Download3.Size = new System.Drawing.Size(75, 23);
            this.Download3.TabIndex = 5;
            this.Download3.Text = "Загрузить";
            this.Download3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(565, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(258, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(565, 109);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(258, 161);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(565, 161);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Пароль должен содержать только цифры";
            // 
            // Save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Download3);
            this.Controls.Add(this.save3);
            this.Controls.Add(this.Download2);
            this.Controls.Add(this.save2);
            this.Controls.Add(this.Download1);
            this.Controls.Add(this.save1);
            this.Name = "Save";
            this.Text = "Save";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save1;
        private System.Windows.Forms.Button Download1;
        private System.Windows.Forms.Button save2;
        private System.Windows.Forms.Button Download2;
        private System.Windows.Forms.Button save3;
        private System.Windows.Forms.Button Download3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
    }
}