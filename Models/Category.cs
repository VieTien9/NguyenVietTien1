using NguyenVietTien1.Models;
using System.ComponentModel.DataAnnotations;

public class Category
{
    [Key]
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    //Navigation property
    public List<Product> Products { get; set; }
}