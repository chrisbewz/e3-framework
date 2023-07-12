using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using e3;
using E3Framework.BaseTypes.E3ContentHandlers;
using E3Framework.Ioc;

namespace E3Framework.ConsoleTests
{
    internal class Program
    {
        
        private static HostingContainer _provider;
        public static async Task Main(string[] args)
        {
            _provider = HostingContainer.Build();
            await Test();
        }

        protected static async Task Test()
        {
            var _app = _provider.Require<IApplicationInterface>();
            var job = (IJobInterface)_app.CreateJobObject();
            Job j = Job.FromId(0, job);
            object devId = default;
            var devCount = job.GetAllDeviceIds(ref devId);
            var id = (int)(devId as object[]).Skip(1).First();
        }
    }
}