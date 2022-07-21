using LmsApi.Modals;

namespace LmsApi.Repository.Crud
{
    public interface ICrud
    {
        public int Login(LoginModal login);

        public int ApproveDeny(StatusModal status);
    }
}
