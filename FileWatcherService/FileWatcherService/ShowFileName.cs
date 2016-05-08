using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileWatcherService
{
    public partial class ShowFileName : Form
    {
        public int count;
        public ShowFileName(string _op)
        {
            InitializeComponent();
            count = 0;
            kianama.Text = _op;
        }

        public void setcount(int i)
        {
            count = i;
        }
        public void show(string name)
        {

            nameing.Text = name;
            //if (count == 1)
            //    kianama.Text = "Changed";
            //else if (count == 2)
            //    kianama.Text = "Created";
            //else if (count == 3)
            //    kianama.Text = "Deleted";
        
            
        }
    }
}
