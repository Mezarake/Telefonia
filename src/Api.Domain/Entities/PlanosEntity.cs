
namespace Api.Domain.Entities
{
    public class PlanosEntity : BaseEntity
    {
        public int IdPlano { get; set; }
        public int Minutos { get; set; }
        public int FranqInternet { get; set; }
        public int Valor { get; set; }
        public string TipoPlano { get; set; }
        public string Operadora { get; set; }
    }
}
