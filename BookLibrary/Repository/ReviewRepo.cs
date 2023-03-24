using BookLibrary.DataAccess;
using BookLibrary.ModelDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public class ReviewRepo
    {
        private ReviewDAO reviewDAO = new ReviewDAO();
        public IEnumerable<Review> GetListReview() => reviewDAO.GetReviewList();
        public Review GetReviewByBookIdAndAccountId(int bookId, int accountId) => reviewDAO.GetReviewByID(bookId, accountId);
        public void AddReview(Review review) => reviewDAO.AddReview(review);
        public void DeleteReview(Review review) => reviewDAO.RemoveReview(review);
        public void UpdateReview(Review review) => reviewDAO.UpdateReview(review);
    }
}
