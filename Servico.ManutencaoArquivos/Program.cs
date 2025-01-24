using Aplicacao.ManutencaoDeArquivo.Interfaces;
using Aplicacao.ManutencaoDeArquivo.Servico;
using Dominio.ManutencaoArquivos.Interface;
using Dominio.ManutencaoArquivos.Servicos;
using Infraestrutura.ManutencaoArquivos.Classes;
using Infraestrutura.ManutencaoArquivos.Interfaces;
using Servico.ManutencaoArquivos;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();
builder.Services.AddWindowsService();

builder.Services.AddSingleton<IRegraExclusaoDeArquivo, RegraExclusaoDeArquivo>();
builder.Services.AddSingleton<IServicoDeConfiguracao, ServicoDeConfiguracao>();
builder.Services.AddSingleton<IServicoArquivoDeSistema, ServicoArquivosDeSistema>();

builder.Services.AddSingleton<IServicoArquivo, ServicoArquivo>();

builder.Logging.AddEventLog(settings => settings.SourceName = "ManutencaoArquivos");

var host = builder.Build();
host.Run();
