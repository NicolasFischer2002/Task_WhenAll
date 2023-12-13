using Task_WhenAll;

try
{
    string caminhoDesktop = Exemplos.GetDesktopPath();
	string nomeDiretorio = "PastasEmLoop";
    string nomeArquivo = "ArquivosEmLoop";

    List<Task> tasks =
        [
            Exemplos.CriaDiretoriosEmLoop(caminhoDesktop, nomeDiretorio),
            Exemplos.CriaArquivosEmLoop(caminhoDesktop, nomeArquivo, ".txt")
        ];

	Task task = Task.WhenAll(tasks);
	task.Wait();

    if (task.IsCompletedSuccessfully)
        Console.WriteLine("\n\nPrograma finalizado sem erros!");
    else
        Console.WriteLine("\n\nPrograma encerrado com erros!");
}
catch (Exception e)
{
    Console.WriteLine("\n\nAlgum erro inesperado ocorreu: " + e.Message);
}