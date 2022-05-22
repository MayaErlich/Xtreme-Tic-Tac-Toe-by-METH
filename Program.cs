using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Xtreme_Tic_Tac_Toe_by_METH
{
    public class Program

        //entire game is called board
        //9 parent tiles that each contain 9 childs tiles within
        //each child tile will have a value to represent x/o/unselected
        //make gamemanager that dictates whether game has won or lost
        //start with parent tile containing individual tic tac toe game, then create multiple, then create code that allows them to interact
        //board will check which parent tiles won to decide who won game
        //make abstract game manager that each tile can be implemented elsewhere using that implement within each parent tile and within the board
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}
