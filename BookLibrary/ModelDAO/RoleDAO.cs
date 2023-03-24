using BookLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.ModelDAO
{
    public class RoleDAO
    {
        public IEnumerable<Role> GetRoleList()
        {
            var roles = new List<Role>();
            try
            {
                using var context = new ProjectBookContext();
                roles = context.Roles.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return roles;
        }

        public Role GetRoleByID(int id)
        {
            Role role = null;
            try
            {
                using var context = new ProjectBookContext();
                role = context.Roles.FirstOrDefault(c => c.RoleId== id);
            }
            catch (Exception)
            {

                throw;
            }
            return role;
        }

        public void AddRole(Role role)
        {
            try
            {
                Role _role = GetRoleByID(role.RoleId);
                if (_role == null)
                {
                    using var context = new ProjectBookContext();
                    context.Roles.Add(role);
                    context.SaveChanges();
                }
                else
                    throw new Exception("The role is already exits");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateRole(Role role)
        {
            try
            {
                Role _role = GetRoleByID(role.RoleId);
                if (_role != null)
                {
                    using var context = new ProjectBookContext();
                    context.Roles.Update(role);
                    context.SaveChanges();
                }
                else
                    throw new Exception("The role does not already exits");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void RemoveRole(int  roleID)
        {
            try
            {
                Role role = GetRoleByID(roleID);
                if (role != null)
                {
                    using var context = new ProjectBookContext();
                    context.Roles.Remove(role);
                    context.SaveChanges();
                }
                else
                    throw new Exception("The role does not already exits");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
