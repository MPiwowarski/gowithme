using GoWithMe.Model.ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using GoWithMe.Model.Extras;

namespace GoWithMe.Model.Repo
{
    public interface ITblUserRepository
    {
        List<tblUser> GetUsers();
        void AddNewUser(tblUser newUser);
        bool SearchIfGivenLoginAlreadyExists(string login);
        bool TryToLogIn(string login, string password);
        tblUser GetUserByGivenEmailAddress(string email);
        string ResetPasswordLoginHelpdesk(tblUser updatedUser);
       
        tblUser GetUserByGivenLogin(string login);
        void UpdateUserData(tblUser updatedUser);
        tblUser GetUserById(int userId);
    }

    

    public class TblUserRepository: DataRepository, ITblUserRepository
    {
        
        public TblUserRepository()
        {
            
        }

        public List<tblUser> GetUsers()
        {
            return DBContext.Users.ToList();
        }

        public void AddNewUser(tblUser newUser)
        {
            DBContext.Users.Add(newUser);
            DBContext.SaveChanges();
        }

        public bool SearchIfGivenLoginAlreadyExists(string login)
        {
            tblUser user = new tblUser();
            user = DBContext.Users.Where(x => x.Login == login).Select(x => x).FirstOrDefault();

            if (user != null)
            { return true; }
            else { return false; }

        }

        public bool TryToLogIn(string login, string password)
        {
            tblUser user = new tblUser();
            user = DBContext.Users.Where(x => x.Login == login).Select(x => x).FirstOrDefault();

            if (user != null && user.Password == password)
            {
                return true;
            }
            else
                return false;
        }

        public tblUser GetUserByGivenEmailAddress(string email)
        {
            tblUser user = new tblUser();
            user = DBContext.Users.Where(x => x.Email == email).Select(x => x).FirstOrDefault();
            return user;
        }

        public string ResetPasswordLoginHelpdesk(tblUser updatedUser)
        {
            IExtrasModel extras = new ExtrasModel();
             
            string newRandomPassword = extras.CreatePassword(10);
            DBContext.Users.Attach(updatedUser);

            updatedUser.Password = newRandomPassword;
            var entry = DBContext.Entry(updatedUser);
            entry.Property(e => e.Password).IsModified = true;
            // other changed properties
            DBContext.SaveChanges();

            return newRandomPassword;
        }

       

        public tblUser GetUserByGivenLogin(string login)
        {
            tblUser user = new tblUser();
            user = DBContext.Users.Where(x => x.Login == login).Select(x => x).FirstOrDefault();
            return user;
        }

        public void UpdateUserData(tblUser updatedUser)
        {
            var original = DBContext.Users.Find(updatedUser.ID);

            DBContext.Entry(original).CurrentValues.SetValues(updatedUser);
            DBContext.SaveChanges();
        }

        public tblUser GetUserById(int userId)
        {
            tblUser user = new tblUser();
            user = DBContext.Users.Where(x => x.ID == userId).Select(x => x).FirstOrDefault();
            return user;
        }
    }
}