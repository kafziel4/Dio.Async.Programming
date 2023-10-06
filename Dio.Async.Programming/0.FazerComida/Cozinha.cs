namespace Dio.Async.Programming;

internal class Cozinha
{
    public void FazerComida()
    {
        FritarOvo();
        CozinharArroz();
    }

    private void FritarOvo()
    {
        Console.WriteLine("Fritando o ovo");
        Thread.Sleep(5000);
        Console.WriteLine("Ovo frito");
    }

    private void CozinharArroz()
    {
        Console.WriteLine("Cozinhando o arroz");
        Thread.Sleep(10000);
        Console.WriteLine("Arroz cozido");
    }

    public async Task FazerComidaAsync()
    {
        await Task.WhenAll(FritarOvoAsync(), CozinharArrozAsync());
    }

    private async Task CozinharArrozAsync()
    {
        await Console.Out.WriteLineAsync("Cozinhando o arroz");
        await Task.Delay(10000);
        await Console.Out.WriteLineAsync("Arroz cozido");
    }

    private async Task FritarOvoAsync()
    {
        await Console.Out.WriteLineAsync("Fritando o ovo");
        await Task.Delay(5000);
        await Console.Out.WriteLineAsync("Ovo frito");
    }
}
