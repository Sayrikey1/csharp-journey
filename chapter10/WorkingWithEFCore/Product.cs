using System.ComponentModel.DataAnnotations; // [Required], [StringLength]
using System.ComponentModel.DataAnnotations.Schema; // [Column]
namespace Packt.Shared;
public class Product
{
    public int ProductId { get; set; } // primary key
    [Required]
    [StringLength(40)]
    public string ProductName { get; set; } = null!;
    [Column("UnitPrice", TypeName = "money")]
    public decimal? Cost { get; set; } // property name != column name
    [Column("UnitsInStock")]
    public short? Stock { get; set; }
    public bool Discontinued { get; set; }
    // these two define the foreign key relationship
    // to the Categories table
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; } = null!;
}



// The two properties that relate the two entities, Category.Products and Product.Category, are both
// marked as virtual. This allows EF Core to inherit and override the properties to provide extra features, such as lazy loading.
