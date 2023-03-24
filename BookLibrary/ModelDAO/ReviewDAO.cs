using BookLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.ModelDAO
{
    public class ReviewDAO
    {
        public IEnumerable<Review> GetReviewList()
        {
            var reviews = new List<Review>();
            try
            {
                using var context = new ProjectBookContext();
                reviews = context.Reviews.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return reviews;
        }

        public Review GetReviewByID(int bookID, int cusID)
        {
            Review review = null;
            try
            {
                using var context = new ProjectBookContext();
                review = context.Reviews.FirstOrDefault(c => c.BookId == bookID && c.AccountId == cusID);
            }
            catch (Exception)
            {
                throw;
            }
            return review;
        }

        public void AddReview(Review review)
        {
            try
            {
                Review _review = GetReviewByID(review.BookId, review.AccountId);
                if (_review == null)
                {
                    using var context = new ProjectBookContext();
                    context.Reviews.Add(review);
                    context.SaveChanges();
                }
                else
                    throw new Exception("The review is already exists");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateReview(Review review)
        {
            try
            {
                Review _review = GetReviewByID(review.BookId, review.AccountId);
                if (_review != null)
                {
                    using var context = new ProjectBookContext();
                    context.Reviews.Update(review);
                    context.SaveChanges();
                }
                else
                    throw new Exception("The review does not already exists");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RemoveReview(Review review1)
        {
            try
            {
                Review review = GetReviewByID(review1.BookId, review1.AccountId);
                if (review != null)
                {
                    using var context = new ProjectBookContext();
                    context.Reviews.Remove(review);
                    context.SaveChanges();
                }
                else
                    throw new Exception("The review does not already exists");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}