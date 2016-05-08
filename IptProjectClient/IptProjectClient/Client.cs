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

namespace IptProjectClient
{
    public partial class Client : Form
    {
        string[] content;
        char[] delimiters = new char[] { ' ', '\r', '\n' };
        public Client()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            info inf = new info();
            
            OpenFileDialog ofd = new OpenFileDialog();
            List<string> list = new List<string>();
            ofd.Filter = "Text File|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(ofd.FileName);
                
                content = reader.ReadToEnd().Split(delimiters,StringSplitOptions.RemoveEmptyEntries);
                tbname.Text = ofd.SafeFileName;
                reader.Dispose();
                
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            info inf = new info();
            dataGridView1.DataSource = inf.getInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            info inf = new info();
            string name = string.Empty;
            string url = string.Empty;
            for(int i=0; i<content.Length;i++)
            {
                name = content[i];
                i++;
                url = content[i];
                inf.addInfo(name, url);
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            info inf = new info();
            inf.deleteInfo();
            dataGridView1.DataSource = inf.getInfo();
        }
    }
}
