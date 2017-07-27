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
        public int UserInfoID { get; set; }

        [MaxLength(200)]
        public string LoginName { get; set; }

        [MaxLength(200)]
        public string LoginPassword { get; set; }

        [MaxLength(200)]
        public string RealName { get; set; }
        
    }

}
