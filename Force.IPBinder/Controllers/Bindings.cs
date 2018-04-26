using Force.IPBinder.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tarsier.Config;
using Tarsier.Extensions;
using Tarsier.Security;
using Tarsier.UI.Icons;

namespace Force.IPBinder.Controllers {
    public class Bindings {
        private SQLiteHelper sqlite;
        private SQLiteTable table;
        private string defaultTable = "bindings";

        public string CurrentTable {
            get { return defaultTable; }
            set { defaultTable = value; }
        }

        public Bindings(string filename, bool encrypted = true) {
            sqlite = new SQLiteHelper(filename);
            CreateTable(defaultTable);
        }

        public void CreateTable(string tableName) {
            defaultTable = tableName.RemoveNonAlphaNumeric().ToLower();
            table = new SQLiteTable(tableName);
            table.AddColumn(new SQLiteColumn("ID", true));
            table.AddColumn(new SQLiteColumn("Description", ColType.Text));
            table.AddColumn(new SQLiteColumn("IPAddress", ColType.Text));
            table.AddColumn(new SQLiteColumn("Path", ColType.Text));
            table.AddColumn(new SQLiteColumn("AutoBind", ColType.Integer));
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

        public string GetIPAddress (string id) {
            if(string.IsNullOrEmpty(id)) {
                return null;
            }
            BindingIP bind = GetBinding(id);
            if(bind != null) {
                if(!string.IsNullOrEmpty(bind.IPAddress)) {
                    return bind.IPAddress;
                }
            }
            return string.Empty;
        }
        public BindingIP GetBinding(string id) {
            if(string.IsNullOrEmpty(id)) {
                return null;
            }
            DataTable dt = sqlite.Select(string.Format(Queries.SELECT_TABLE_WHERE, defaultTable, "ID=" + id));
            BindingIP b = new BindingIP();
            if(dt != null) {
                foreach(DataRow dr in dt.Rows) {
                    try {
                        b = new BindingIP() {
                            ID = dr["ID"].ToSafeInteger(),
                            IPAddress = SimpleEncryption.Decrypt(dr["IPAddress"].ToSafeString()),
                            Description = SimpleEncryption.Decrypt(dr["Description"].ToSafeString()),
                            Path = SimpleEncryption.Decrypt(dr["Path"].ToSafeString()),
                            AutoBind = dr["AutoBind"].ToSafeInteger(),
                            Code = dr["Code"].ToSafeString()
                        };
                    } catch { /*@Ignore exception*/}
                }
            }
            return b;
        }

        public List<BindingIP> GetBindings() {
            DataTable dt = sqlite.Select(string.Format(Queries.SELECT_TABLE_DESC, defaultTable, "ID"));

            List<BindingIP> pwds = new List<BindingIP>();
            if(dt.Rows.Count > 0) {
                foreach(DataRow dr in dt.Rows) {
                    BindingIP cmd = new BindingIP() {
                        ID = dr["ID"].ToSafeInteger(),
                        IPAddress = SimpleEncryption.Decrypt(dr["IPAddress"].ToSafeString()),
                        Description = SimpleEncryption.Decrypt(dr["Description"].ToSafeString()),
                        Path = SimpleEncryption.Decrypt(dr["Path"].ToSafeString()),
                        AutoBind = dr["AutoBind"].ToSafeInteger(),
                        Code = dr["Code"].ToSafeString()
                    };
                    pwds.Add(cmd);
                }
            }
            return pwds;
        }
      
        public void Add(BindingIP c) {
            Dictionary<string, object> data = new Dictionary<string, object>();
            string code = (c.Path + c.Description).RemoveNonAlphaNumeric().ToLower();
            data.Add("Description", SimpleEncryption.Encrypt(c.Description));
            data.Add("IPAddress", SimpleEncryption.Encrypt(c.IPAddress));
            data.Add("Path", SimpleEncryption.Encrypt(c.Path));
            data.Add("AutoBind", c.AutoBind);
            data.Add("Code", code);
            if(sqlite.IsExist(defaultTable, "Code", code.ToStringType())) {
                sqlite.Update(defaultTable, data, "Code", code);
            } else {
                sqlite.Insert(defaultTable, data);
            }
        }
        public void SetAutoBind(string id, bool autoBind) {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("AutoBind", autoBind ? "1":"0");
            if(sqlite.IsExist(defaultTable, "ID", id)) {
                sqlite.Update(defaultTable, data, "id", id);
            }
        }
        public void DeleteCode(string code) {
            sqlite.Delete(defaultTable, string.Format("Code ='{0}'", code));
        }
        public void Delete(string id) {
            sqlite.Delete(defaultTable, string.Format("ID ={0}", id));
        }

        public void Initialize(ListView list, IconListManager _iconListManager) {
            List<BindingIP> pwds = GetBindings();
            if(pwds.Count > 0) {
                list.Items.Clear();
                foreach(BindingIP b in pwds) {
                    ListViewItem item = new ListViewItem(b.ID.ToSafeString(), _iconListManager.AddFileIcon(b.Path));
                    item.UseItemStyleForSubItems = false;
                    item.SubItems.Add(b.Description);
                    item.SubItems.Add(b.Path);
                    item.SubItems.Add(b.AutoBind==1? "Yes": "No");
                    item.SubItems[0].ForeColor = Color.White;
                    item.SubItems[1].Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
                    item.SubItems[2].ForeColor = Color.DarkGreen;
                    item.SubItems[3].ForeColor = b.AutoBind == 1 ? Color.Blue : Color.Gray;
                    if(list.InvokeRequired) {
                        list.Invoke((MethodInvoker)delegate () {
                            list.Items.Add(item);
                        });
                    } else {
                        list.Items.Add(item);
                    }
                }
            }
        }
    }
}
