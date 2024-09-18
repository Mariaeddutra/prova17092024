public class Veiculo
{
    public int Id { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public List<Acessorio> Acessorios { get; set; }
}