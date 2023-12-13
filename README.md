# Task_WhenAll
Como trabalhar com paralelismo em C# utilizando Task.WhenAll() para aguardar a conclusão de tarefas assíncronas (await async). Task.WhenAll() não bloqueia a Thread principal, sendo muito útil para aplicações que envolvem interação do usuário com uma interface gráfica. Recebe como parâmetro apenas List<Task>/Task[] e similares. Retorna uma única exceção ao invés de um AggregateException. 

=> Documentação: https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.whenall?view=net-8.0
