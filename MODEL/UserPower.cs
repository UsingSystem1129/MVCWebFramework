using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MODEL
{
    public class UserPower 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int userPowerID;
		public int UserPowerID
		{
			get { return userPowerID; }
			set { userPowerID = value; }
		}
		int powerMaster;
		public int PowerMaster
		{
			get { return powerMaster; }
			set { powerMaster = value; }
		}
        [StringLength(200)]
        string powerMasterValue;
		public string PowerMasterValue
		{
			get { return powerMasterValue; }
			set { powerMasterValue = value; }
		}
		int powerAccess;
		public int PowerAccess
		{
			get { return powerAccess; }
			set { powerAccess = value; }
		}
        [StringLength(200)]
        string powerAccessValue;
		public string PowerAccessValue
		{
			get { return powerAccessValue; }
			set { powerAccessValue = value; }
		}
		int powerOperation;
		public int PowerOperation
		{
			get { return powerOperation; }
			set { powerOperation = value; }
		}
	
	
	}
}












