using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace COMMON
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]//MYSQl EF配置
    public  class FrameworkDBContext: DbContext
    {

        public FrameworkDBContext() : base("FrameworkDBContext")
        {
            Database.SetInitializer<FrameworkDBContext>(new FrameworkInitializer());//初始化数据器 初始化基础数据
        }
        static FrameworkDBContext()//MYSQl EF配置
        {
            DbConfiguration.SetConfiguration(new MySql.Data.Entity.MySqlEFConfiguration());
        }


        public DbSet<UserInfo> UserInfos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//指定生成单数表名
        }
    }
}
