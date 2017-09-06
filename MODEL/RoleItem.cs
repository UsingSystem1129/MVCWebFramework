using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MODEL
{
    /// <summary>
    /// 模块拥有的功能实体表
    /// </summary>
    public class RoleItem
    {
        
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoleItemID
        {
            get;set;
        }
        int iTemID;

        public int ITemID
        {
            get { return iTemID; }
            set { iTemID = value; }
        }
        int roleID;

        public int RoleID
        {
            get { return roleID; }
            set { roleID = value; }
        }
        
        string menuNo;
        [StringLength(200), MaxLength(200)]
        public string MenuNo
        {
            get { return menuNo; }
            set { menuNo = value; }
        }
    }
}
