using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Library
{
    public partial class InsertForm : Form
    {
        private string media;
        List<Record> recs;
        public bool canceled, mismatch;

        public InsertForm(String m)
        {
            InitializeComponent();
            media = m;
            if (m == "books")
                by_l.Text = "Author:";
            else
                by_l.Text = "Director:";
            textBox1.Select();
            canceled = mismatch = false;
        }

        public void setText(Record r)
        {
            textBox1.Text = r.getTitle();
            textBox2.Text = r.getBy();
            textBox3.Text = r.getReleased().ToString();
            textBox4.Text = r.getRating().ToString();
        }

        private void ok_b_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == ""
                || textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("Please enter all data.");
            else
            {
                try
                {
                    recs = new List<Record>();
                    string b;
                    string[] ts = textBox1.Text.Split(new string[] { ", " }, StringSplitOptions.None);
                    string[] res = textBox3.Text.Split(new string[] { ", " }, StringSplitOptions.None);
                    string[] ras = textBox4.Text.Split(new string[] { ", " }, StringSplitOptions.None);
                    if (textBox2.Text.Contains(","))
                        b = textBox2.Text;
                    else
                    {
                        string[] bs = textBox2.Text.Split(' ');
                        b = bs[bs.Length - 1] + ", ";
                        for (int i = 0; i < bs.Length - 1; i++)
                            b += bs[i] + " ";
                    }
                    if (ts.Length == res.Length && res.Length == ras.Length)
                    {
                        for (int i = 0; i < ts.Length; i++)
                        {
                            Record r = new Record(ts[i], b, int.Parse(res[i]), int.Parse(ras[i]));
                            recs.Add(r);
                        }
                    }
                    else
                    {
                        mismatch = true;
                        MessageBox.Show("The number of entries, does not match in each field\n" +
                            "Please seperate title/released/rating with consistent ',' characters.", "Error");
                    }
                    this.Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid types");
                }
            }
        }

        private void cancel_b_Click(object sender, EventArgs e)
        {
            canceled = true;
            this.Close();
        }

        public List<Record> getRecs()
        {
            return recs;
        }
    }
}
