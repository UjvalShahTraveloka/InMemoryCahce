using System.Threading.Tasks;
using Orleans;

namespace HelloWorld.Interfaces
{
    public interface IHello : IGrainWithIntegerKey
    {
        Task<string> SayHello(string greeting);
    }
}
