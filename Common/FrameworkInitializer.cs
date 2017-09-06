using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
namespace COMMON
{
    public class FrameworkInitializer: DropCreateDatabaseIfModelChanges<FrameworkDBContext>
    {
        protected override void Seed(FrameworkDBContext context)
        {
            //var UserInfos = new List<UserInfo>()
            //{
            //    new UserInfo { LoginName="admin", LoginPassword="111111"}
            //};

            //UserInfos.ForEach(m => context.UserInfos.Add(m));
            //context.UserInfos.Add(null);
            //context.SaveChanges();//通过context写入数据库
        }



    }
}
