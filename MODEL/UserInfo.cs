using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MODEL
{
    public class UserInfo 
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		int userInfoID;
		public int UserInfoID
		{
			get { return userInfoID; }
			set { userInfoID = value; }
		}
		int departmentID;
		public int DepartmentID
		{
			get { return departmentID; }
			set { departmentID = value; }
		}
        [MaxLength(200)]
		string realName;
		public string RealName
		{
			get { return realName; }
			set { realName = value; }
		}
       
        string loginName;
        [MaxLength(200)]
        public string LoginName
		{
			get { return loginName; }
			set { loginName = value; }
		}
        [MaxLength(200)]
        string loginPassword;
		public string LoginPassword
		{
			get { return loginPassword; }
			set { loginPassword = value; }
		}
		int userLead;
		public int UserLead
		{
			get { return userLead; }
			set { userLead = value; }
		}
        [MaxLength(200)]
        string userTitle;
		public string UserTitle
		{
			get { return userTitle; }
			set { userTitle = value; }
		}
        [MaxLength(200)]
        string userBusiness;
		public string UserBusiness
		{
			get { return userBusiness; }
			set { userBusiness = value; }
		}
		string userPhone;
		public string UserPhone
		{
			get { return userPhone; }
			set { userPhone = value; }
		}
        [MaxLength(200)]
        string userEmail;
		public string UserEmail
		{
			get { return userEmail; }
			set { userEmail = value; }
		}
        [MaxLength(200)]
        string subPackage;
		public string SubPackage
		{
			get { return subPackage; }
			set { subPackage = value; }
		}
		string subManage;
		public string SubManage
		{
			get { return subManage; }
			set { subManage = value; }
		}
        [MaxLength(200)]
        string userPhotoUrl;
		public string UserPhotoUrl
		{
			get { return userPhotoUrl; }
			set { userPhotoUrl = value; }
		}
        
		int userType;
		public int UserType
		{
			get { return userType; }
			set { userType = value; }
		}
		int state;
		public int State
		{
			get { return state; }
			set { state = value; }
		}
        DateTime createTime = DateTime.Now; 
		public DateTime CreateTime
		{
			get { return createTime; }
			set { createTime = value; }
		}
        [MaxLength(200)]
        string departmentName;
        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }
        string userRole;
        public string UserRole
        {
            get { return userRole; }
            set { userRole = value; }
        }
        int useState;

        public int UseState
        {
            get { return useState; }
            set { useState = value; }
        }
	
		

        int userEnterpriseAdminID;

        public int UserEnterpriseAdminID
        {
            get { return userEnterpriseAdminID; }
            set { userEnterpriseAdminID = value; }
        }

        string mobilePhone;

        public string MobilePhone
        {
            get { return mobilePhone; }
            set { mobilePhone = value; }
        }


        int isUse;

        public int IsUse
        {
            get { return isUse; }
            set { isUse = value; }
        }
        [NotMapped]
        public string UserDepartFullName { get; set; }
        [NotMapped]
        public string UserInfoString { get; set; }
        [NotMapped]
        public int OrderSecond { get; set; }
        [NotMapped]
        public int OrderThird { get; set; }
	}
}












