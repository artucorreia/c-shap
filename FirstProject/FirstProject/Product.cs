namespace FirstProject {
    internal class Product {
        public string Name { get; private set; }
        private double _price;
        private int _stock;
        
        public Product(string name, double price, int stock) { 
            Name = name;
            _price = price;
            _stock = stock;
        }

        public double Price {
            get { return _price; }
            set {
                if (
                    _price != value 
                    && value >= 0
                ) {
                    _price = value;
                }
            }
        }

        public int Stock { 
            get { return _stock; }
            private set {
                if (
                    _stock != value 
                    && value >= 0
                ) {
                    _stock = value;
                }
            }
        }

        public void RemoveProdutc(int quantity) {
            Stock -= quantity;
        }

        public void AddProduct(int quantity) {
            Stock += quantity;
        }

        public override string ToString() {
            return $"{Name}, price: {_price}, stock: {_stock}";
        }
    }
}