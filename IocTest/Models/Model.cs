using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IocTest.Models
{
    /*权重：
    AddSingleton→AddTransient→AddScoped
    AddSingleton的生命周期：
    项目启动-项目关闭   相当于静态类  只会有一个  
    AddScoped的生命周期：
    请求开始-请求结束  在这次请求中获取的对象都是同一个 
    AddTransient的生命周期：
    请求获取-（GC回收-主动释放） 每一次获取的对象都不是同一个*/

    public interface ISingTest
    {
        int Age { get; set; }
        string Name { get; set; }
    }

    public class SingTest : ISingTest
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public interface ISconTest
    {
        int Age { get; set; }
        string Name { get; set; }
    }
    public class SconTest : ISconTest
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public interface ITranTest
    {
        int Age { get; set; }
        string Name { get; set; }
    }
    public class TranTest : ITranTest
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
    
    public interface IAService
    {
        void RedisTest();
    }
    public class AService : IAService
    {
        private ISingTest sing; ITranTest tran; ISconTest scon;
        public AService(ISingTest sing, ITranTest tran, ISconTest scon)
        {
            this.sing = sing;
            this.tran = tran;
            this.scon = scon;
        }

        public void RedisTest()
        {

        }
    }
}
