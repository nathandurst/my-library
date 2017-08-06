using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Text.RegularExpressions.Regex;

namespace My_Library
{
    public partial class RecordsForm : Form
    {
        private string media;
        private List<Record> records = new List<Record>();
        bool tb, bb, reb, rab;
        
        public RecordsForm(List<Record> list, String m)
        {
            InitializeComponent();
            records = list;
            media = m;
            this.Text = m.ToUpper();
            records_lb.Font = new Font(FontFamily.GenericMonospace, records_lb.Font.Size);
        }

        public void refresh(List<Record> list)
        {
            records = list;
            records_lb.Items.Clear();
            string by;
            if (media == "books")
                by = "Author";
            else
                by = "Director";
            records_lb.Items.Add(String.Format("{0,-50}{1,-25}{2,-10}{3, 10}", "Title",
                by, "Released", "Rating"));
            records_lb.Items.Add("---------------------------------------------"
                + "-----------------------------------------------------------------");
            if(records != null)
            {
                foreach (Record r in records)
                    records_lb.Items.Add(r.ToString());
            }

            display_l.Text = String.Format("{0} out of {1} {2} selected", 
                records_lb.SelectedIndices.Count, records.Count, media);
            by_rb.Text = by;
            
        }

        public List<int> findIndex()
        {
            List<int> selected = new List<int>();

            for(int i = 0; i < records_lb.SelectedItems.Count; i++)
            {
                selected.Add(records_lb.SelectedIndices[i]);
            }

            return selected;
        }

        public string getMedia()
        {
            return media;
        }

        public List<Record> getRecords()
        {
            return records;
        }

        private void title_rb_CheckedChanged(object sender, EventArgs e)
        {
            //records.Sort((x, y) => x.getTitle().CompareTo(y.getTitle()));
            records = records.OrderBy(x => (x.getTitle().StartsWith("The ")) ? x.getTitle().Remove(0, 4) : x.getTitle()).ToList<Record>();
            if (tb == true)
                records = records.OrderByDescending(x => (x.getTitle().StartsWith("The ")) ? x.getTitle().Remove(0, 4) : x.getTitle()).ToList<Record>();
            refresh(records);
            tb = !tb;
        }

        private void by_rb_CheckedChanged(object sender, EventArgs e)
        {
            //records.Sort((x, y) => x.getBy().CompareTo(y.getBy()));
            records = records.OrderBy(x => x.getBy()).ThenBy(x => x.getReleased()).ToList<Record>();
            if (bb)
                records = records.OrderByDescending(x => x.getBy()).ThenByDescending(x => x.getReleased()).ToList<Record>();
            refresh(records);
            bb = !bb;
        }

        private void released_rb_CheckedChanged(object sender, EventArgs e)
        {
            //records.Sort((x, y) => x.getReleased().CompareTo(y.getReleased()));
            records = records.OrderBy(x => x.getReleased()).ToList<Record>();
            if (reb == true)
                records = records.OrderByDescending(x => x.getReleased()).ToList<Record>();
            refresh(records);
            reb = !reb;
        }

        private void rating_rb_CheckedChanged(object sender, EventArgs e)
        {
            //records.Sort((x, y) => x.getRating().CompareTo(y.getRating()));
            records = records.OrderBy(x => x.getRating()).ThenBy(x => x.getBy()).ToList<Record>();
            if (rab == true)
                records = records.OrderByDescending(x => x.getRating()).ThenByDescending(x => x.getBy()).ToList<Record>();
            refresh(records);
            rab = !rab;
        }

        private void search_b_Click(object sender, EventArgs e)
        {
            string pattern = search_tb.Text;
            records_lb.ClearSelected();
            int count = 0;
            if(pattern == "")
            {
                MessageBox.Show("Please enter desired search word.", "Error");
            }
            else
            {
                foreach(Record r in records)
                {
                    if(System.Text.RegularExpressions.Regex.IsMatch(r.getTitle(), 
                        pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                        || System.Text.RegularExpressions.Regex.IsMatch(r.getBy(),
                        pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                    {
                        count++;
                        records_lb.SetSelected(records.IndexOf(r) + 2, true);
                    }
                }

                MessageBox.Show(String.Format("{0} items match your search.", count));
            }

        }

        private void records_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(records_lb.SelectedIndex != 0 && records_lb.SelectedIndex != 1)
                display_l.Text = String.Format("{0} out of {1} {2} selected", 
                    records_lb.SelectedIndices.Count, records.Count, media);
        }        

    }
}
