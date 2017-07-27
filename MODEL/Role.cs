using System;
using System.Collections.Generic;

namespace MODEL
{
    public class Role 
    {
		int roleID;
		public int RoleID
		{
			get { return roleID; }
			set { roleID = value; }
		}
		string roleName;
		public string RoleName
		{
			get { return roleName; }
			set { roleName = value; }
		}
		string roleDesc;
		public string RoleDesc
		{
			get { return roleDesc; }
			set { roleDesc = value; }
		}
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












