using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace IptProjectClient
{
    class info
    {
        DbConnector db = new DbConnector();

        public void addInfo(string name, string url)
        {
            String _querry;

            _querry = "INSERT INTO Info (Project_Name, Project_URL) VALUES ('" + name + "','" + url + "');";
            db.InsertRecord(_querry);

        }

        public List<Info_Strings> getInfo()
        {
            List<Info_Strings> list = new List<Info_Strings>();
            Info_Strings infs = new Info_Strings();
            DataTable table = new DataTable();
            string _querry = "SELECT Project_Name, Project_URL FROM Info ORDER BY Project_Name ASC;";
            table = db.tableGenerator(_querry);
            
            foreach(DataRow row in table.Rows)
            {
                infs.Project_Name = row["Project_Name"].ToString();
                infs.Project_URL = row["Project_URL"].ToString();
                list.Add(infs);
                infs = new Info_Strings();
            }
            return list;
        }

        public void deleteInfo()
        {
            string _querry = "DELETE FROM Info;";
            db.InsertRecord(_querry);
        }
    }
}
