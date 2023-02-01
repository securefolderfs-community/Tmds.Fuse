using System;
using System.Threading.Tasks;

namespace Tmds.Fuse
{
    public interface IFuseMount : IDisposable
    {
        Task WaitForUnmountAsync();
        void LazyUnmount();
        Task<bool> UnmountAsync(int timeout = -1, bool force = false);
    }
}