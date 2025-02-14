using Rhein.TicoDeGente.Domain.Entities.Base;

namespace Rhein.TicoDeGente.Domain.Entities.Payments;

public class PaymentMethod : EntityBase
{
    public enum PaymentType
    {
        Credit,
        Debit,
        Boleto,
        // ... outros tipos
    }

    public PaymentType Type { get; set; }
}

