using System.ComponentModel;
using System.Data;

namespace DBProgrammingDemo9
{
    public static class UIUtilities
    {
        public static int CurrentUserID { get; set; }
        public static void BindComboBox(this ComboBox cmb, DataTable dt, string displayMember, string valueMember)
        {
            //Adding an empty DataRow in the DataTable at first index
            DataRow row = dt.NewRow();
            row[valueMember] = DBNull.Value;
            row[displayMember] = "";
            dt.Rows.InsertAt(row, 0);

            cmb.DisplayMember = displayMember;
            cmb.ValueMember = valueMember;
            cmb.DataSource = dt;
        }

        public static void Bind(this ComboBox cmb, DataTable dt, string displayMember, string valueMember)
        {
            cmb.DisplayMember = displayMember;
            cmb.ValueMember = valueMember;
            cmb.DataSource = dt;
        }

        public static void Bind(this ComboBox cmb, DataTable dt, string displayMember, string valueMember, string defaultValue)
        {
            DataRow dr = dt.NewRow();
            dr[displayMember] = defaultValue;
            dr[valueMember] = DBNull.Value;

            dt.Rows.InsertAt(dr, 0);

            cmb.DisplayMember = displayMember;
            cmb.ValueMember = valueMember;
            cmb.DataSource = dt;
        }

        public static void TextValidating(object sender, CancelEventArgs e, ErrorProvider errProvider)
        {
            TextBox txt = (TextBox)sender;
            string? txtBoxName = txt.Tag.ToString();
            string errMsg = string.Empty;
            bool failedValidation = false;

            if (txt.Text == string.Empty)
            {
                errMsg = $"{txtBoxName} is required";
                failedValidation = true;
            }

            e.Cancel = failedValidation;

            errProvider.SetError(txt, errMsg);
        }

        public static void ComboBoxValidating(object sender, CancelEventArgs e, ErrorProvider errProvider)
        {
            ComboBox cmb = (ComboBox)sender;

            string errMsg = string.Empty;
            bool failedValidation = false;

            if (cmb.SelectedIndex == -1 || String.IsNullOrEmpty(cmb.SelectedValue.ToString()))
            {
                errMsg = $"{cmb.Tag} is required";
                failedValidation = true;
            }

            e.Cancel = failedValidation;
            errProvider.SetError(cmb, errMsg);
        }

    }
}
