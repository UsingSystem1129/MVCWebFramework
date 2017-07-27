using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MODEL
{
    /// <summary>
    /// 模块拥有的功能实体表
    /// </summary>
  public class RoleItem
    {
        int rItemID;

        public int RItemID
        {
            get { return rItemID; }
            set { rItemID = value; }
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

        public string MenuNo
        {
            get { return menuNo; }
            set { menuNo = value; }
        }
    }
}
