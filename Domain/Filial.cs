using challenge_dotnet.Domain.MotoRepository;

namespace challenge_dotnet.Domain

public class Filial
{
    public Guid Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Endereco { get; set; } = string.Empty;
    public double TamanhoPatio { get; set; }

    public ICollection<Moto> Motos { get; set; } = new List<Moto>();

}
