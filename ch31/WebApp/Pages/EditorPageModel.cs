﻿// Listing 31.27 Adding CheckNewCategory method in the EditorPageModel.cs file in the Pages folder

namespace WebApp.Pages {

    public class EditorPageModel : PageModel {

        public EditorPageModel(DataContext dbContext) {
            DataContext = dbContext;
        }

        public DataContext DataContext { get; set; }

        public IEnumerable<Category> Categories => DataContext.Categories;
        public IEnumerable<Supplier> Suppliers => DataContext.Suppliers;

        public ProductViewModel? ViewModel { get; set; }

        protected async Task CheckNewCategory(Product product)
        {
            if (product.CategoryId == -1 && !string.IsNullOrEmpty(product.Category?.Name))
            {
                DataContext.Categories.Add(product.Category);
                await DataContext.SaveChangesAsync();
                product.CategoryId = product.Category.CategoryId;
                ModelState.Clear();
                TryValidateModel(product);
            }
        }
    }
}
