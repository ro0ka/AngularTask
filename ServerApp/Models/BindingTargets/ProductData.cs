using System.ComponentModel.DataAnnotations;

namespace ServerApp.Models.BindingTargets {

    public class ProductData {

        [Required]
        public long ProductId
        {
            get => Product.ProductId; set => Product.ProductId = value;
        }

        [Required]
        public string Name {
            get => Product.Name; set => Product.Name = value;
        }

        [Required]
        public string Category {
            get => Product.Category; set => Product.Category = value;
        }

        [Required]
        public string Description {
            get => Product.Description; set => Product.Description = value;
        }

        [Range(1, int.MaxValue, ErrorMessage = "Price must be at least 1")]
        public decimal Price {
            get => Product.Price; set => Product.Price = value;
        }

        

        public Product Product { get; set; } = new Product();
    }
}
