using BookLibrary.DataAccess;
using BookLibrary.ModelDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public class CategoryRepo
    {
        private CategoryDAO categoryDAO = new CategoryDAO();

        public IEnumerable<Category> GetListCategory() => categoryDAO.GetCategoryList();
        public void AddCategory(Category category) => categoryDAO.AddCategory(category);
    }
}
