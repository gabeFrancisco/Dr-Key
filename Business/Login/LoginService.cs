using Domain.Entities.Security;
using Repository.DataAcess;
using Repository.DataAcess.SerialObjects;

namespace Business.Login
{
    public static class LoginService
    {
        private static LoginData _data = new LoginData();
        public static LoginMemory _memory = new LoginMemory();

        public static void VerifyLogin(string username, string password)
        {
            UserData userData = new UserData();
            if (userData.VerifyUser(username, password) == true)
            {
                _memory = _data.ReadData();
            }
        }

        public  static void SaveUserState(bool state)
        {
            if (state == true)
            {
                _memory.IsLoginSaved = true;
                _data.SetData(_memory);
            }
            else
            {
                _memory.IsLoginSaved = false;
                _data.SetData(_memory);
            }
            
        }

        public static void LoadData()
        {
            _memory = _data.ReadData();
        }
    }
}
