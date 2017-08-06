using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Library
{
    [Serializable]
    public class Record
    {
        private string title;
        private string by;
        private int released;
        private int rating;

        public Record(string t, string b, int d, int r)
        {
            title = t;
            by = b;
            released = d;
            rating = r;
        }

        public Record()
        {
            title = "";
            by = "";
            released = 0;
            rating = 0;
        }

        public string getTitle()
        {
            return title;
        }

        public string getBy()
        {
            return by;
        }

        public int getReleased()
        {
            return released;
        }

        public int getRating()
        {
            return rating;
        }

        public string ToString()
        {
            string rat;
            if (rating < 1 || rating > 10)
                rat = "N/A";
            else
                rat = rating.ToString();
            return String.Format("{0, -50}{1,-25}{2,-10}{3,10}", title, by, released.ToString(), rat);
        }
    }
}
