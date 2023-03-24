using BookLibrary.DataAccess;
using BookLibrary.ModelDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public class AccountRepo
    {
        private AccountDAO acc = new AccountDAO();

        public IEnumerable<Account> GetListAccount() => acc.GetAccountList();
        public Account CheckAuthentication(String username, String password)
        {
            foreach (Account account in acc.GetAccountList())
            {
                if(account.Username.Equals(username) && account.Password.Equals(password))
                    return account;
            }
            return null;
        }

        public Account CheckAuthentication(String username)
        {
            foreach (Account account in acc.GetAccountList())
            {
                if (account.Username.Equals(username))
                    return account;
            }
            return null;
        }

        public void AddAccount(Account account) => acc.AddAccount(account);

        public void UpdateAccount(Account account) => acc.UpdateAccount(account);
       
    }
}
