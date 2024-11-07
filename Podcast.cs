class Podcast
{
    private List<Episodio> episodios = new();

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Este é o Podcast {Nome} apresentado por {Host}.\n");
        Console.WriteLine($"Lista de episodios do podcast: \n");
        foreach (Episodio episodio in episodios.OrderBy(episodio => episodio.Ordem))
        {
            Console.WriteLine($"Episódio: {episodio.Resumo}\n");
        }
        Console.WriteLine($"Total de episódios do podcast: {TotalEpisodios}");
    }
}