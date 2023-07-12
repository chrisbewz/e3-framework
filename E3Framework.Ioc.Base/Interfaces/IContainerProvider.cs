using Microsoft.Extensions.Hosting;

namespace E3Framework.Ioc.Base.Interfaces;

public interface IHostingProvider
{
    IHost Host { get;}
}