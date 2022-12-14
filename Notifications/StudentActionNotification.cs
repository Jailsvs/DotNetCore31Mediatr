using MediatR;

namespace AspNetMediatr.Notifications
{
    public class StudentActionNotification : INotification
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ActionNotification Action { get; set; }
    }
}