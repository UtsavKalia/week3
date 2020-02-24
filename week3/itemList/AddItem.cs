using week3.Models;

namespace itemLists
{
    internal class AddItem : CartitemList
    {
        private Product selectedProduct;
        private int v;

        public AddItem(Product selectedProduct, int v)
        {
            this.selectedProduct = selectedProduct;
            this.v = v;
        }
    }
}