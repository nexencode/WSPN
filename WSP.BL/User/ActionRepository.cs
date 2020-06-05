using System;
using System.Collections.Generic;
using System.Text;

namespace WSP.BL
{
    public static class ActionRepository
    {
        public static Action UpdateProduct = new Action("Update Product", "This action can update product");
        public static Action CreateProduct = new Action("Create Product", "This action can create new product");
        public static Action DeleteProduct = new Action("Delete Product", "This action can delete product");
    }
}
