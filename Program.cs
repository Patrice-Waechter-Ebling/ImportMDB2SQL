using ImportMDB;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
#pragma warning disable CS8602 // Déréférencement d'une éventuelle référence null.
#pragma warning disable CS8604	//Existence possible d'un argument de référence null 

ApplicationContext context = new ApplicationContext(new());
Console.WriteLine($"Initialisation: {DateTime.Now.ToString()} Processus:{Environment.ProcessId}\n{Environment.ProcessPath}");
Console.Title = "Application Web: GRB Solution Inc 2023 \tv:2.0.2.3";
Console.WriteLine($"(C) Patrice Waechter-Ebling 2023\nExecution sur :{Environment.MachineName}\nAssistant d'importation de bases ACCESS remanié pour GRB Solution Inc.");
Console.WriteLine($"Version retournée par le Serveur SQL: {    context.GrbConfigs.FirstOrDefault().DerniereVersion}");
