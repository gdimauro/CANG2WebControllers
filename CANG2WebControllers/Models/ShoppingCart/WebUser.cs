
/* Generated from GenMyModel */


namespace CAEP5MockServer.Models.ShoppingCart
{
    public enum UserState
    {
        New = 0x01,
        Active = 0x02,
        Banned = 0x04
    }

    public class WebUser
    {
        protected string login;
        private string password;
        public UserState state;

    }
}
