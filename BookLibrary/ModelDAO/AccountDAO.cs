using BookLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.ModelDAO
{
    public class AccountDAO
    {
        public IEnumerable<Account> GetAccountList()
        {
            var accounts = new List<Account>();
            try
            {
                using var context = new ProjectBookContext();
                accounts = context.Accounts.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return accounts;
        }

        public Account GetAccountByID(int id)
        {
            Account account = null;
            try
            {
                using var context = new ProjectBookContext();
                account = context.Accounts.FirstOrDefault(c => c.AccountId == id);
            }
            catch (Exception)
            {

                throw;
            }
            return account;
        }

        public void AddAccount(Account account)
        {
            try
            {
                    using var context = new ProjectBookContext();
                    context.Accounts.Add(account);
                    context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateAccount(Account account)
        {
            try
            {
                    using var context = new ProjectBookContext();
                    context.Accounts.Update(account);
                    context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void RemoveAccount(int accountID)
        {
            try
            {
                Account account = GetAccountByID(accountID);
                if (account != null)
                {
                    using var context = new ProjectBookContext();
                    context.Accounts.Remove(account);
                    context.SaveChanges();
                }
                else
                    throw new Exception("The account does not already exits");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}