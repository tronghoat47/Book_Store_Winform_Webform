using BookLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.ModelDAO
{
    public class CategoryDAO
    {
        public IEnumerable<Category> GetCategoryList()
        {
            var categories = new List<Category>();
            try
            {
                using var context = new ProjectBookContext();
                categories = context.Categories.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return categories;
        }

        public Category GetCategoryByID(int id)
        {
            Category category = null;
            try
            {
                using var context = new ProjectBookContext();
                category = context.Categories.FirstOrDefault(c => c.CategoryId == id);
            }
            catch (Exception)
            {

                throw;
            }
            return category;
        }

        public void AddCategory(Category category)
        {
            try
            {
                Category _category = GetCategoryByID(category.CategoryId);
                if (_category == null)
                {
                    using var context = new ProjectBookContext();
                    context.Categories.Add(category);
                    context.SaveChanges();
                }
                else
                    throw new Exception("The category is already exits");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateCategory(Category category)
        {
            try
            {
                Category _category = GetCategoryByID(category.CategoryId);
                if (_category != null)
                {
                    using var context = new ProjectBookContext();
                    context.Categories.Update(category);
                    context.SaveChanges();
                }
                else
                    throw new Exception("The category does not already exits");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void RemoveCategory(int categoryId)
        {
            try
            {
                Category category = GetCategoryByID(categoryId);
                if (category != null)
                {
                    using var context = new ProjectBookContext();
                    context.Categories.Remove(category);
                    context.SaveChanges();
                }
                else
                    throw new Exception("The category does not already exits");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}