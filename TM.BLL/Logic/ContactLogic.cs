namespace TM.BLL.Logic
{
    public class ContactLogic
    {
        public string fullname { get; set; }

        public string email { get; set; }

        public string message { get; set; }

        public DAL.DataModels.Contact toDomain()
        {
            var domain = new DAL.DataModels.Contact();

            domain.Email = this.email;
            domain.FullName = this.fullname;
            domain.Message = this.message;

            return domain;
        }
    }
}