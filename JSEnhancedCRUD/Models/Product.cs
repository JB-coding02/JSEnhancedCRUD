using System.ComponentModel.DataAnnotations;

namespace JSEnhancedCRUD.Models;

/// <summary>
/// A product for sale.
/// </summary>
public class Product
{
    /// <summary>
    /// A unique identifier for the product.
    /// </summary>
    [Key]
    public required int Id { get; set; }

    /// <summary>
    /// The customer facing name of the product.
    /// </summary>
    [StringLength(30, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 30 characters.")]
    [RegularExpression("^[a-zA-Z0-9s]*$", ErrorMessage = "Name must be alphanumeric characters only.")]
    public required string Name { get; set; }

    /// <summary>
    /// Thesales price in USD for product.
    /// </summary>
    public decimal Price { get; set; }
}
