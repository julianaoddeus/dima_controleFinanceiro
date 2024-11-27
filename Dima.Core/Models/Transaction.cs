using Dima.Core.Enums;

namespace Dima.Core.Models;

public class Transaction
{
    public long Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime CreateAt { get; set; } = DateTime.Now;
    public DateTime? PaidOrReceivedAt { get; set; }
    public TrasactionTypeEnum Type { get; set; }
    public decimal Amount { get; set; }
    public long CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}