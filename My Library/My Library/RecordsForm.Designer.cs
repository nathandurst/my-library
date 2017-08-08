namespace My_Library
{
    partial class RecordsForm
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
            this.records_lb = new System.Windows.Forms.ListBox();
            this.search_b = new System.Windows.Forms.Button();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.display_l = new System.Windows.Forms.Label();
            this.sort_gb = new System.Windows.Forms.GroupBox();
            this.rating_rb = new System.Windows.Forms.RadioButton();
            this.released_rb = new System.Windows.Forms.RadioButton();
            this.by_rb = new System.Windows.Forms.RadioButton();
            this.title_rb = new System.Windows.Forms.RadioButton();
            this.sort_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // records_lb
            // 
            this.records_lb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.records_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.records_lb.FormattingEnabled = true;
            this.records_lb.ItemHeight = 25;
            this.records_lb.Location = new System.Drawing.Point(0, 98);
            this.records_lb.Name = "records_lb";
            this.records_lb.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.records_lb.Size = new System.Drawing.Size(1343, 554);
            this.records_lb.TabIndex = 0;
            this.records_lb.SelectedIndexChanged += new System.EventHandler(this.records_lb_SelectedIndexChanged);
            
            // 
            // search_b
            // 
            this.search_b.Location = new System.Drawing.Point(1235, 12);
            this.search_b.Name = "search_b";
            this.search_b.Size = new System.Drawing.Size(96, 30);
            this.search_b.TabIndex = 1;
            this.search_b.Text = "Search";
            this.search_b.UseVisualStyleBackColor = true;
            this.search_b.Click += new System.EventHandler(this.search_b_Click);
            // 
            // search_tb
            // 
            this.search_tb.Location = new System.Drawing.Point(931, 16);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(298, 22);
            this.search_tb.TabIndex = 2;
            // 
            // display_l
            // 
            this.display_l.AutoSize = true;
            this.display_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_l.Location = new System.Drawing.Point(927, 59);
            this.display_l.Name = "display_l";
            this.display_l.Size = new System.Drawing.Size(93, 32);
            this.display_l.TabIndex = 3;
            this.display_l.Text = "label1";
            // 
            // sort_gb
            // 
            this.sort_gb.Controls.Add(this.rating_rb);
            this.sort_gb.Controls.Add(this.released_rb);
            this.sort_gb.Controls.Add(this.by_rb);
            this.sort_gb.Controls.Add(this.title_rb);
            this.sort_gb.Location = new System.Drawing.Point(14, 9);
            this.sort_gb.Name = "sort_gb";
            this.sort_gb.Size = new System.Drawing.Size(480, 82);
            this.sort_gb.TabIndex = 4;
            this.sort_gb.TabStop = false;
            this.sort_gb.Text = "Sort by";
            // 
            // rating_rb
            // 
            this.rating_rb.AutoSize = true;
            this.rating_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating_rb.Location = new System.Drawing.Point(373, 38);
            this.rating_rb.Name = "rating_rb";
            this.rating_rb.Size = new System.Drawing.Size(84, 28);
            this.rating_rb.TabIndex = 3;
            this.rating_rb.TabStop = true;
            this.rating_rb.Text = "Rating";
            this.rating_rb.UseVisualStyleBackColor = true;
            this.rating_rb.Click += new System.EventHandler(this.rating_rb_CheckedChanged);
            // 
            // released_rb
            // 
            this.released_rb.AutoSize = true;
            this.released_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.released_rb.Location = new System.Drawing.Point(220, 38);
            this.released_rb.Name = "released_rb";
            this.released_rb.Size = new System.Drawing.Size(141, 28);
            this.released_rb.TabIndex = 2;
            this.released_rb.TabStop = true;
            this.released_rb.Text = "Release date";
            this.released_rb.UseVisualStyleBackColor = true;
            this.released_rb.Click += new System.EventHandler(this.released_rb_CheckedChanged);
            // 
            // by_rb
            // 
            this.by_rb.AutoSize = true;
            this.by_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.by_rb.Location = new System.Drawing.Point(104, 38);
            this.by_rb.Name = "by_rb";
            this.by_rb.Size = new System.Drawing.Size(87, 28);
            this.by_rb.TabIndex = 1;
            this.by_rb.TabStop = true;
            this.by_rb.Text = "Author";
            this.by_rb.UseVisualStyleBackColor = true;
            this.by_rb.Click += new System.EventHandler(this.by_rb_CheckedChanged);
            // 
            // title_rb
            // 
            this.title_rb.AutoSize = true;
            this.title_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_rb.Location = new System.Drawing.Point(20, 38);
            this.title_rb.Name = "title_rb";
            this.title_rb.Size = new System.Drawing.Size(66, 28);
            this.title_rb.TabIndex = 0;
            this.title_rb.TabStop = true;
            this.title_rb.Text = "Title";
            this.title_rb.UseVisualStyleBackColor = true;
            this.title_rb.Click += new System.EventHandler(this.title_rb_CheckedChanged);
            // 
            // RecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 652);
            this.Controls.Add(this.sort_gb);
            this.Controls.Add(this.display_l);
            this.Controls.Add(this.search_tb);
            this.Controls.Add(this.search_b);
            this.Controls.Add(this.records_lb);
            this.Name = "RecordsForm";
            this.Text = "RecordsForm";
            this.sort_gb.ResumeLayout(false);
            this.sort_gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox records_lb;
        private System.Windows.Forms.Button search_b;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.Label display_l;
        private System.Windows.Forms.GroupBox sort_gb;
        private System.Windows.Forms.RadioButton rating_rb;
        private System.Windows.Forms.RadioButton released_rb;
        private System.Windows.Forms.RadioButton by_rb;
        private System.Windows.Forms.RadioButton title_rb;
    }
}