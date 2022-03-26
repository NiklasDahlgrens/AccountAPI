using System.Threading.Tasks;

namespace LoginAPI.Services
{
    public interface ILogger
    {
        Task<bool> LoggAsync(string serviceName, string loggEventType, string message);
    }
}