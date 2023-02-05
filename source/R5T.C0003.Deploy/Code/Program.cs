using System;
using System.Threading.Tasks;


namespace R5T.C0003.Deploy
{
    class Program
    {
        static async Task Main()
        {
            await DeployScripts.Instance.DeployToLocalCloudBinariesDirectory();
        }
    }
}
