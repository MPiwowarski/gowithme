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
        private GoWithMeDBContext _context;
        public TblUserRepository()
        {
            _context = DBContext;
        }
        public TblUserRepository(GoWithMeDBContext context)
        {
            _context = context;
        }
        

        public List<tblUser> GetUsers()
        {
            return _context.Users.ToList();
        }

        public void AddNewUser(tblUser newUser)
        {
            ExtrasModel extrasModel = new ExtrasModel();
            newUser.Password = extrasModel.encryptPhraseUsingSha256(newUser.Password);
            _context.Users.Add(newUser);
            _context.SaveChanges();
        }

        public bool SearchIfGivenLoginAlreadyExists(string login)
        {
            tblUser user = new tblUser();
            user = _context.Users.Where(x => x.Login == login).Select(x => x).FirstOrDefault();

            if (user != null)
            { return true; }
            else { return false; }

        }

        public bool TryToLogIn(string login, string password)
        {
            tblUser user = new tblUser();
            ExtrasModel extrasModel = new ExtrasModel();
            password = extrasModel.encryptPhraseUsingSha256(password);
            user = _context.Users.Where(x => x.Login == login).Select(x => x).FirstOrDefault();

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
            user = _context.Users.Where(x => x.Email == email).Select(x => x).FirstOrDefault();
            return user;
        }

        public string ResetPasswordLoginHelpdesk(tblUser updatedUser)
        {
            IExtrasModel extras = new ExtrasModel();
             
            string newRandomPassword = extras.CreatePassword(10);
            _context.Users.Attach(updatedUser);


            ExtrasModel extrasModel = new ExtrasModel();
            updatedUser.Password = extrasModel.encryptPhraseUsingSha256(newRandomPassword);
            var entry = _context.Entry(updatedUser);
            entry.Property(e => e.Password).IsModified = true;
            // other changed properties
            _context.SaveChanges();

            return newRandomPassword;
        }

       

        public tblUser GetUserByGivenLogin(string login)
        {
            tblUser user = new tblUser();
            user = _context.Users.Where(x => x.Login == login).Select(x => x).FirstOrDefault();
            return user;
        }

        public void UpdateUserData(tblUser updatedUser)
        {
            var original = _context.Users.Find(updatedUser.ID);
            ExtrasModel extrasModel = new ExtrasModel();
            updatedUser.Password = extrasModel.encryptPhraseUsingSha256(updatedUser.Password);

            _context.Entry(original).CurrentValues.SetValues(updatedUser);
            _context.SaveChanges();
        }

        public tblUser GetUserById(int userId)
        {
            tblUser user = new tblUser();
            user = _context.Users.Where(x => x.ID == userId).Select(x => x).FirstOrDefault();
            return user;
        }
    }
}