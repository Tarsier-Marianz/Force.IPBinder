using Force.IPBinder.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tarsier.Config;
using Tarsier.Extensions;

namespace Force.IPBinder.Controllers {
    public class Configs {
        private SQLiteHelper sqlite;
        private SQLiteTable table;
        private string defaultTable = "options";

        public string CurrentTable {
            get { return defaultTable; }
            set { defaultTable = value; }
        }

        public Configs(string filename) {
            sqlite = new SQLiteHelper(filename);
            CreateTable(defaultTable);
        }
        public void SetProfile(string profileName) {
            defaultTable = profileName.RemoveNonAlphaNumeric().ToLower();
            CreateTable(defaultTable);
        }

        public void CreateTable(string tableName) {
            defaultTable = tableName.RemoveNonAlphaNumeric().ToLower();
            table = new SQLiteTable(tableName);
            table.AddColumn(new SQLiteColumn("ID", true));
            table.AddColumn(new SQLiteColumn("Property", ColType.Text));
            table.AddColumn(new SQLiteColumn("Value", ColType.Text));
            sqlite.CreateTable(table);
        }

        public bool ClearCommands() {
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

        public T Get<T>(string property) {
            T _temp = default(T);
            try {
                string dbConfig = GetValue(property);
                if(!string.IsNullOrEmpty(dbConfig)) {
                    _temp = dbConfig.DeserializeT<T>();
                }
            } catch {
                return default(T);
            }
            return _temp;
        }

        public string GetValue(string property) {
            DataTable dt = GetDataTable(false);
            if(dt != null) {
                foreach(DataRow r in dt.Rows) {
                    if(property.Equals(r["Property"].ToSafeString())) {
                        return r["Value"].ToSafeString();
                    }
                }
            }
            return string.Empty;
        }

        public bool Set<T>(string key, T value) {
            return Add(key, value.SerializeT<T>());
        }
        public void Add(Config _cfg) {
            JObject json = JObject.FromObject(_cfg);
            foreach(JProperty property in json.Properties()) {
                Add(property.Name, property.Value.ToSafeString());
            }
        }

        public bool Add(string property, string value) {
            try {
                Dictionary<string, object> data = new Dictionary<string, object>();
                //property = property.ToLower();
                data.Add("Property", property);
                data.Add("Value", value);
                if(sqlite.IsExist(defaultTable, "Property", property.ToStringType())) {
                    sqlite.Update(defaultTable, data, "Property", property);
                } else {
                    sqlite.Insert(defaultTable, data);
                }
            } catch {
                return false;
            }
            return true;
        }
    }
}