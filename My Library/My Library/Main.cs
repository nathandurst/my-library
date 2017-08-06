using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace My_Library
{
    public partial class Main : Form
    {
        public string media = "";
        private BinaryFormatter bf = new BinaryFormatter();
        private FileStream read, write;
        private List<Record> Records = new List<Record>();
        
        public Main()
        {
            InitializeComponent();
        }

        /********************************************************************
         *  Event handler for file>Open>Books menu item.
         *        will set the media type to books and call the loadRecords method
         **********************************************************************/
        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            media = "books";
            loadRecords();
        }
        /********************************************************************
         *  Event handler for the File>Open>Movies menu item.
         *      will seth the media type to movies and call the loadRecords method
         **********************************************************************/
        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            media = "movies";
            loadRecords();
        }

        /********************************************************************
         *  Loads the records into the Records variable. Does not return or require any variables
         *      Using FileStream and BinaryFormatter, this function reads from the specified file
         *      and loads the records from that file into the Records variable where they
         *      can then be used throughout the program. 
         **********************************************************************/
        private void loadRecords()
        {
            //Gets the active child form to determine if it is already opened or not
            RecordsForm R = this.ActiveMdiChild as RecordsForm;
            int numChildren = this.MdiChildren.Length;
            if (R != null || numChildren == 2)
                MessageBox.Show("Only one form at a time, please.", "Error");
            //Since it is not already openened, the function will read the records from the file and
            //  display them on a new RecordsForm
            else
            {
                //Shows a new records form (blank)
                R = new RecordsForm(Records, media);
                R.MdiParent = this;
                R.Show();
                
                //Determines which media we are wanting and reads form the corresponding file
                string file = R.getMedia() + ".inv";
                Records.Clear(); //Clears the records in case we are using a different media
                read = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Read);
                if (read.Length > 0)
                    Records = bf.Deserialize(read) as List<Record>;

                //Calls the refresh function which displays the records on the RecordsForm
                R.refresh(Records);
                read.Close();
            }
        }

        /********************************************************************
         *  Event handler for the File>Save menu item
         *      will take the records that are currently being accessed and write them
         *      to the file with the name of the media.
         **********************************************************************/
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Gets the active child form to determine if it is already opened or not
            RecordsForm R = this.ActiveMdiChild as RecordsForm;
            if (R == null)
                MessageBox.Show("No form is currently displayed.", "Error");
            
            //Since there is a form open, we can now write the records to a file 
            else
            {
                //Define variables needed for writing
                string file;
                media = R.getMedia();
                file = media + ".inv";
                Records = R.getRecords();
                
                //Write to file
                write = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);
                if (Records.Count > 0)
                    bf.Serialize(write, Records);
                write.Close();
                MessageBox.Show("Records have been saved to " + file, "Done!");
            }
        }

        /*********************************************************************************
         *  Event handler for the File>Exit menu item
         *      will close the entire application(main form)
         *********************************************************************************/
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*********************************************************************************
         *  Event Handler for the Edit>Insert menu item
         *      will allow the user to insert(Add) records to the list of records
         *
         *********************************************************************************/
        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Checks to make sure a form is available
            RecordsForm R = this.ActiveMdiChild as RecordsForm;
            if (R == null)
                MessageBox.Show("No form available.", "Error");
            //Since ther is an active form, we can now insert to the list
            else
            {
                //Gets the records that are already displayed on the Records Form
                Records = R.getRecords();
                //Creates and displays an insert form, which allows the user to enter record data
                InsertForm I = new InsertForm(media);
                I.ShowDialog();
                
                //If the user pressed cancel instead of ok on the insert form, we will not add data.
                //In the insert method, mismatch is set to true if the number of titles, ratings, released are not consistent.
                //  so if mismatch is true, nothing will be added to the list
                if(I.canceled == false && I.mismatch == false)
                {
                    //Gets the list of records created from the InsertForm(list is used for several 
                    //  entries with common author/director) and adds them to the records we recieved
                    //  from the RecordsForm a few instructions ago.
                    Records.AddRange(I.getRecs());
                    R.refresh(Records);     //Refresh method displays the new list of records to the RecordsForm
                    MessageBox.Show("Record has successfully been added.", "Done!");
                }
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RecordsForm R = this.ActiveMdiChild as RecordsForm;
            List<int> selected = new List<int>();
            bool deleted = false;
            DialogResult prompt;
            if (R == null)
                MessageBox.Show("You need an active form to delete records.", "Error");
            else
            {
                prompt = MessageBox.Show("Are you sure you would like to permanently delete these records?",
                    "Delete?", MessageBoxButtons.YesNo);
                if (prompt == DialogResult.Yes)
                {
                    Records = R.getRecords();
                    selected = R.findIndex();
                    foreach (int index in selected.OrderByDescending(i => i))
                    {
                        if (index > 1)
                        {
                            Records.RemoveAt(index - 2);
                            R.refresh(Records);
                            deleted = true;
                        }
                    }
                    if (deleted)
                        MessageBox.Show("Record has successfully been removed from your library.", "Done!");
                    else
                        MessageBox.Show("Please make a proper selection before deleting", "Error");
                }
                else
                    MessageBox.Show("Records were NOT deleted!", "Done!");
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecordsForm R = this.ActiveMdiChild as RecordsForm;
            List<int> selected = new List<int>();
            if (R == null)
                MessageBox.Show("You need an active form to update records.", "Error");
            else
            {
                Records = R.getRecords();
                selected = R.findIndex();
                foreach(int index in selected.OrderByDescending(i => i))
                {
                    if(index > 1)
                    {
                        InsertForm I = new InsertForm(media);
                        I.setText(Records[index - 2]);
                        I.ShowDialog();
                        if (I.canceled == false && I.mismatch == false){
                            List<Record> temp = I.getRecs();
                            Records[index - 2] = temp[0];
                            MessageBox.Show("Record has successfully been updated.", "Done!"); }
                        R.refresh(Records);
                    }
                }
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This applications purpose is to store a collection of owned\n" +
                "media, in this case books or movies. You, the user, may insert, update, or delete\n" +
                "records where they will be saved. You may also sort and serach our items if desired.\n",
                "About");
        }

        
    }
}
