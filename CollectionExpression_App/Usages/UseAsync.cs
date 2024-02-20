namespace CollectionExpression_App.Usages;

public class UseAsyncBase
{
}

public class UseAsync : UseAsyncBase
{
    public async Task<Task<int>[]> Test(Task<int> initialTask)
    {
        int[] s =
        [
            await Task.Run(() => 1),
            await initialTask,
            await new Task<int>(() => 1, CancellationToken.None)
        ];

        foreach (var i in (Task<int>[])[initialTask])
        {
            await i;
        }
        await Task.Run(() => { });
        await Task.Run(() => { });

        return [initialTask];
    }
}