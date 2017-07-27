using System;
using System.Collections.Generic;

namespace MODEL
{
    public class UserRole 
    {
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
	
	
		UserInfo userInfo;
		public UserInfo UserInfo
		{
			get { return userInfo; }
			set { userInfo = value; }
		}
		Role role;
		public Role Role
		{
			get { return role; }
			set { role = value; }
		}
	}
}












