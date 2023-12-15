using Task_WhenAll;

try
{
    string caminhoDesktop = Exemplos.GetDesktopPath();  
	string nomeDiretorio = "PastasEmLoop";
    string nomeArquivo = "ArquivosEmLoop";

    // <===== Em versões anteriores do .NET pode ser necessário declarar as tasks desta forma dentro da lista =====> //
    // Task.Run(() => Exemplos.CriaDiretoriosEmLoop(caminhoDesktop, nomeDiretorio)),
    // Task.Run(() => Exemplos.CriaArquivosEmLoop(caminhoDesktop, nomeArquivo, ".txt"))

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