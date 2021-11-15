using Module2HW2.Providers;

namespace Module2HW2.Models
{
    public sealed class Cart
    {
        private static readonly Cart _instance = new Cart();

        static Cart()
        {
        }

        private Cart()
        {
        }

        public static Cart Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}