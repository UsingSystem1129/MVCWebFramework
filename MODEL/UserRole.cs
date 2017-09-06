using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MODEL
{
    public class UserRole
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int userRoleID;
        public int UserRoleID
        {
            get { return userRoleID; }
            set { userRoleID = value; }
        }
        int userInfoID;
        public int UserInfoID
        {
            get { return userInfoID; }
            set { userInfoID = value; }
        }
        int roleID;
        public int RoleID
        {
            get { return roleID; }
            set { roleID = value; }
        }

    }
}












