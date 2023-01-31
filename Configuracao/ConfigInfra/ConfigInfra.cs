﻿using Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Configuracao.ConfigInfra
{
	public static class ConfigInfra 
	{
		public static IServiceCollection AddConfigInfra(this IServiceCollection services,IConfiguration config)
		{
			var connectioDataBase = config.GetConnectionString("connectionMysql");
			services.AddDbContext<ContextoAplicacao>(opt =>
				opt.UseMySql(connectioDataBase,ServerVersion.AutoDetect(connectioDataBase), 
				opt => opt.MigrationsAssembly("Infra")));

			return services;

		}

	}
}