using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tarsier.Config;
using Tarsier.Extensions;

namespace Force.IPBinder.Controllers {
    public class Commands {
        private SQLiteHelper sqlite;
        private SQLiteTable table;
        private string defaultTable = "commands";

        public string CurrentTable {
            get { return defaultTable; }
            set { defaultTable = value; }
        }

        public Commands(string filename, bool encrypted = true) {
            sqlite = new SQLiteHelper(filename);
            CreateTable(defaultTable);
        }

        public void CreateTable(string tableName) {
            defaultTable = tableName.RemoveNonAlphaNumeric().ToLower();
            table = new SQLiteTable(tableName);
            table.AddColumn(new SQLiteColumn("ID", true));
            table.AddColumn(new SQLiteColumn("Command", ColType.Text));
            table.AddColumn(new SQLiteColumn("Code", ColType.Text));
            sqlite.CreateTable(table);
        }

        public bool ClearAll() {
            try {
                if(sqlite.IsTableExist(defaultTable)) {
                    sqlite.DropTable(defaultTable);
                    return true;
                }
            } catch {
            }
            return false;

        }
        public DataTable GetDataTable(bool orderDesc) {
            if(string.IsNullOrEmpty(defaultTable)) {
                return null;
            }
            if(orderDesc) {
                return sqlite.Select(string.Format(Queries.SELECT_TABLE_DESC, defaultTable, "ID"));
            }
            return sqlite.GetDataTable(defaultTable);
        }

        public List<string> GetCommands() {
            DataTable dt = sqlite.Select(string.Format(Queries.SELECT_TABLE_DESC, defaultTable, "ID"));

            List<string> cmds = new List<string>();
            if(dt.Rows.Count > 0) {
                foreach(DataRow dr in dt.Rows) {
                    string cmd = dr["Command"].ToSafeString();
                    if(!string.IsNullOrEmpty(cmd)) {
                        cmds.Add(cmd);
                    }
                }
            }
            return cmds;
        }

        public AutoCompleteStringCollection GetAutoCompleteSource() {
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            List<string> cmds = GetCommands();
            foreach(string c in cmds) {
                autoComplete.Add(c);
            }
            return autoComplete;
        }
        public void Add(string cmd) {
            Dictionary<string, object> data = new Dictionary<string, object>();
            string code = (cmd).RemoveNonAlphaNumeric().ToLower();
            data.Add("Command", cmd);
            data.Add("Code", code);
            if(sqlite.IsExist(defaultTable, "Code", code.ToStringType())) {
                sqlite.Update(defaultTable, data, "Code", code);
            } else {
                sqlite.Insert(defaultTable, data);
            }
        }
    }
}
