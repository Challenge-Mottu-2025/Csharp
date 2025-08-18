namespace challenge_dotnet.Aplication.DTOs;

public class UpdateMotoDto
{
    public string Modelo { get; set; } = string.Empty;
    public string Placa { get; set; } = string.Empty;
    [Required]
    public Guid? FilialId { get; set; }
    [Required]
    public Guid? LocalizacaoPatioId { get; set; }
}
