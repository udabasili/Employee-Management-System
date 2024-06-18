using DBProgrammingDemo9;
using System.Data;

namespace EmployeeManagamentSystem
{
    //create enum for permissions
    /** RoleID	RoleName	Description	Permission
1	Admin	Administrator with full access	ALL
2	Manager	Manager with managerial access	VIEW_EMPLOYEES, ADD_EMPLOYEE, EDIT_EMPLOYEE, DELETE_EMPLOYEE
3	Employee	Regular Employee	VIEW_SELF, EDIT_SELF
   **/
    public enum Permission
    {
        ALL,
        VIEW_EMPLOYEES,
        ADD_EMPLOYEE,
        EDIT_EMPLOYEE,
        DELETE_EMPLOYEE,
        VIEW_SELF,
        EDIT_SELF
    }
    public class Authorization
    {
        private static bool showEmployeeEditorForm = false;
        private static bool showDepartmentEditorForm = false;
        private static bool showEmployeeViewerForm = false;
        private static bool showDepartmentViewerForm = false;
        private static bool showEditProfileForm = true;
        private static bool showManagerForm = false;
        private static bool showSalaryForm = false;

        public static void SetFormAccess(Permission permission)
        {

            switch (permission)
            {
                case Permission.ALL:
                    showEmployeeEditorForm = true;
                    showDepartmentEditorForm = true;
                    showEmployeeViewerForm = true;
                    showDepartmentViewerForm = true;
                    showEditProfileForm = true;
                    showManagerForm = true;
                    showSalaryForm = true;
                    break;
                case Permission.VIEW_EMPLOYEES:
                    //show employee viewer form
                    showEmployeeViewerForm = true;

                    break;
                case Permission.ADD_EMPLOYEE:
                    //show employee editor form
                    showEmployeeEditorForm = true;
                    break;
                case Permission.EDIT_EMPLOYEE:
                    //show employee editor form
                    showEmployeeEditorForm = true;
                    break;
                case Permission.DELETE_EMPLOYEE:
                    //show employee editor form
                    showEditProfileForm = true;
                    break;
                case Permission.VIEW_SELF:
                    //show employee viewer form
                    showEditProfileForm = true;
                    break;
                case Permission.EDIT_SELF:
                    showEditProfileForm = true;
                    break;
                default:

                    break;
            }

        }


        public static string[]? GetCurrentUserPermission()
        {
            int currentUserId = UIUtilities.CurrentUserID;

            //get role from database for current user
            string currentRole = $"SELECT Role FROM Users WHERE UserID = {currentUserId}";
            //get role id value from database
            int roleIdValue = (int)DataAccess.GetValue(currentRole);

            //get role from database for roleid value
            string roleSql = $"SELECT Permission FROM Roles WHERE RoleID = {roleIdValue}";
            DataTable dtRoles = DataAccess.GetData(roleSql);

            if (dtRoles.Rows.Count > 0)
            {
                DataRow drRoles = dtRoles.Rows[0];
                string? permission = drRoles["Permission"]?.ToString();
                return permission?.Split(',');
            }
            return null;

        }

        public static void SetFormAccessCurrentUser()
        {
            string[]? permissions = GetCurrentUserPermission();
            if (permissions != null)
            {
                foreach (string permission in permissions)
                {
                    Permission currentPermission = (Permission)Enum.Parse(typeof(Permission), permission);
                    SetFormAccess(currentPermission);
                }
            }
        }

        //return all forms that should be shown
        public static bool ShowEmployeeEditorForm()
        {
            return showEmployeeEditorForm;
        }

        public static bool ShowDepartmentEditorForm()
        {
            return showDepartmentEditorForm;
        }

        public static bool ShowEmployeeViewerForm()
        {
            return showEmployeeViewerForm;
        }

        public static bool ShowDepartmentViewerForm()
        {
            return showDepartmentViewerForm;
        }

        public static bool ShowEditProfileForm()
        {
            return showEditProfileForm;
        }

        public static bool ShowManagerForm()
        {
            return showManagerForm;
        }

        public static bool ShowSalaryForm()
        {
            return showSalaryForm;
        }






    }
}
