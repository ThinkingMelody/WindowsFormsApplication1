using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication1
{
    class CComboBox
    {
        private string _name;
        private string _value;

        public CComboBox(string name, string value)
        {
            this._name = name;
            this._value = value;
        }

        public string Name
        {
            get;
        }

        public string Value
        {
            get;
        }
        public static void CombBox_Binding(ComboBox cbxItem, ArrayList alstDatasource)
        {
            cbxItem.DataSource = alstDatasource;
            cbxItem.DisplayMember = "Name";
            cbxItem.ValueMember = "Value";
        }
    }
}
