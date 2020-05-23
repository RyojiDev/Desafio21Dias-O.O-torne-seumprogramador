using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Desafio21DiasOO.Dia13
{
    public class Configuration
    {
       
        public static IConfigurationRoot configuration { get; set; }

       public Configuration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            configuration = builder.Build();
        }


        
    }
}
