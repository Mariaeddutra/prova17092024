public class VeiculoRepository
{
    private readonly List<Veiculo> _veiculos;

    public VeiculoRepository()
    {
        _veiculos = new List<Veiculo>();
    }

    public void CreateVeiculo(Veiculo veiculo)
    {
        _veiculos.Add(veiculo);
    }

    public List<Veiculo> ReadVeiculos()
    {
        return _veiculos;
    }

    public Veiculo ReadVeiculo(int id)
    {
        return _veiculos.FirstOrDefault(v => v.Id == id);
    }

    public void UpdateVeiculo(Veiculo veiculo)
    {
        var veiculoExistente = ReadVeiculo(veiculo.Id);
        if (veiculoExistente != null)
        {
            veiculoExistente.Marca = veiculo.Marca;
            veiculoExistente.Modelo = veiculo.Modelo;
            veiculoExistente.Ano = veiculo.Ano;
            veiculoExistente.Acessorios = veiculo.Acessorios;
        }
    }

    public void DeleteVeiculo(int id)
    {
        var veiculoExistente = ReadVeiculo(id);
        if (veiculoExistente != null)
        {
            _veiculos.Remove(veiculoExistente);
        }
    }

    public void AddAcessorio(int veiculoId, Acessorio acessorio)
    {
        var veiculoExistente = ReadVeiculo(veiculoId);
        if (veiculoExistente != null)
        {
            veiculoExistente.Acessorios.Add(acessorio);
        }
    }

    public void RemoveAcessorio(int veiculoId, int acessorioId)
    {
        var veiculoExistente = ReadVeiculo(veiculoId);
        if (veiculoExistente != null)
        {
            var acessorioExistente = veiculoExistente.Acessorios.FirstOrDefault(a => a.Id == acessorioId);
            if (acessorioExistente != null)
            {
                veiculoExistente.Acessorios.Remove(acessorioExistente);
            }
        }
    }
}