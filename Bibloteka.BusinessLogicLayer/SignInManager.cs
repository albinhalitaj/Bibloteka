using Bibloteka.BusinessObjects;
using Bibloteka.DataAccessLayer;

namespace Bibloteka.BusinessLogicLayer
{
    public class SignInManager
    {
        private readonly LoginDal _context;
        
        public SignInManager() => _context = new LoginDal();

        public Perdoruesi LoginUser(Perdoruesi user) => _context.Login(user);
    }
}