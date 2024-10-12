using Aplicacao.ManutencaoDeArquivo.Interfaces;
using Aplicacao.ManutencaoDeArquivo.Servico;
using Dominio.ManutencaoArquivos.Interface;
using Dominio.ManutencaoArquivos.Servicos;
using Infraestrutura.ManutencaoArquivos.Interfaces;
using Servico.ManutencaoArquivos;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.Services.AddScoped<IRegraExclusaoDeArquivo, RegraExclusaoDeArquivo>();
builder.Services.AddScoped<IServicoDeConfiguracao, IServicoDeConfiguracao>();
builder.Services.AddScoped<IServicoArquivoDeSistema, IServicoArquivoDeSistema>();

builder.Services.AddScoped<IServicoArquivo, ServicoArquivo>();


var host = builder.Build();
host.Run();
