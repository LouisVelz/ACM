
using System.Net;
using System.Reflection;
using Acme.Common;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId {
            get;
            private set;
        }

        private string _productName;

        public string ProductName
        {
            get => _productName.InsertSpaces();
            set => _productName = value;
        }
        public string ProductDescription { get; set; }
        public double? CurrentPrice { get; set; }

        public override bool Validate()
        {
            bool isValid = !string.IsNullOrEmpty(ProductName);

            if (CurrentPrice == 0) isValid = false;

            return isValid;
        }

        public string Log() =>  $"{ProductId}: {ProductName} Detail: {ProductDescription} Status: { EntityState.ToString()}";
    }
}
