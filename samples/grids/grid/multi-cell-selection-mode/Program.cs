using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using IgniteUI.Blazor.Controls; // for registering Ignite UI modules

namespace Infragistics.Samples
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            // TODO update names of the following modules for the IgbGrid
            builder.Services.AddIgniteUIBlazor(
                typeof(IgbGridModule),
                typeof(IgbRadioModule),
                typeof(IgbRadioGroupModule),
                typeof(IgbSnackbarModule),
                typeof(IgbIconModule)
            );
            await builder.Build().RunAsync();
        }
    }
}
