
namespace ACM.BL
{
    public class Product : EntityBase
    {
        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId {
            get;
            private set;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public double? CurrentPrice { get; set; }

        public override bool Validate()
        {
            bool isValid = !string.IsNullOrEmpty(Name);

            if (CurrentPrice == 0) isValid = false;

            return isValid;
        }

    }
}
