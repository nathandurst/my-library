namespace My_Library
{
    partial class InsertForm
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rating_l = new System.Windows.Forms.Label();
            this.released_l = new System.Windows.Forms.Label();
            this.by_l = new System.Windows.Forms.Label();
            this.title_l = new System.Windows.Forms.Label();
            this.cancel_b = new System.Windows.Forms.Button();
            this.ok_b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(178, 196);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 22);
            this.textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(178, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 22);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(178, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 22);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(363, 22);
            this.textBox1.TabIndex = 10;
            // 
            // rating_l
            // 
            this.rating_l.AutoSize = true;
            this.rating_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating_l.Location = new System.Drawing.Point(36, 194);
            this.rating_l.Name = "rating_l";
            this.rating_l.Size = new System.Drawing.Size(68, 24);
            this.rating_l.TabIndex = 9;
            this.rating_l.Text = "Rating:";
            // 
            // released_l
            // 
            this.released_l.AutoSize = true;
            this.released_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.released_l.Location = new System.Drawing.Point(36, 142);
            this.released_l.Name = "released_l";
            this.released_l.Size = new System.Drawing.Size(132, 24);
            this.released_l.TabIndex = 8;
            this.released_l.Text = "Year released:";
            // 
            // by_l
            // 
            this.by_l.AutoSize = true;
            this.by_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.by_l.Location = new System.Drawing.Point(36, 92);
            this.by_l.Name = "by_l";
            this.by_l.Size = new System.Drawing.Size(36, 24);
            this.by_l.TabIndex = 7;
            this.by_l.Text = "By:";
            // 
            // title_l
            // 
            this.title_l.AutoSize = true;
            this.title_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_l.Location = new System.Drawing.Point(36, 40);
            this.title_l.Name = "title_l";
            this.title_l.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.title_l.Size = new System.Drawing.Size(50, 24);
            this.title_l.TabIndex = 6;
            this.title_l.Text = "Title:";
            // 
            // cancel_b
            // 
            this.cancel_b.Location = new System.Drawing.Point(334, 178);
            this.cancel_b.Name = "cancel_b";
            this.cancel_b.Size = new System.Drawing.Size(103, 40);
            this.cancel_b.TabIndex = 5;
            this.cancel_b.Text = "Cancel";
            this.cancel_b.UseVisualStyleBackColor = true;
            this.cancel_b.Click += new System.EventHandler(this.cancel_b_Click);
            // 
            // ok_b
            // 
            this.ok_b.Location = new System.Drawing.Point(444, 178);
            this.ok_b.Name = "ok_b";
            this.ok_b.Size = new System.Drawing.Size(103, 40);
            this.ok_b.TabIndex = 6;
            this.ok_b.Text = "Ok";
            this.ok_b.UseVisualStyleBackColor = true;
            this.ok_b.Click += new System.EventHandler(this.ok_b_Click);
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 246);
            this.Controls.Add(this.ok_b);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.title_l);
            this.Controls.Add(this.cancel_b);
            this.Controls.Add(this.by_l);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.released_l);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.rating_l);
            this.Controls.Add(this.textBox1);
            this.Name = "InsertForm";
            this.Text = "Insert Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label rating_l;
        private System.Windows.Forms.Label released_l;
        private System.Windows.Forms.Label by_l;
        private System.Windows.Forms.Label title_l;
        private System.Windows.Forms.Button cancel_b;
        private System.Windows.Forms.Button ok_b;
    }
}