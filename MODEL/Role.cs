using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MODEL
{
    public class Role 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int roleID;
		public int RoleID
		{
			get { return roleID; }
			set { roleID = value; }
		}
        [MaxLength(200)]
		string roleName;
		public string RoleName
		{
			get { return roleName; }
			set { roleName = value; }
		}
        [MaxLength(200)]
        string roleDesc;
		public string RoleDesc
		{
			get { return roleDesc; }
			set { roleDesc = value; }
		}
        [MaxLength(200)]
        string createUserID;
		public string CreateUserID
		{
			get { return createUserID; }
			set { createUserID = value; }
		}
        DateTime createTime = DateTime.Now; 
		public DateTime CreateTime
		{
			get { return createTime; }
			set { createTime = value; }
		}
	
	
	}
}












