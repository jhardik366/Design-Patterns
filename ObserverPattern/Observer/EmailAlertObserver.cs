using ObserverPattern.Observable;

namespace ObserverPattern.Observer
{
    public class EmailAlertObserver : IObserver
    {
        string _emailId;
        IObservable observable;

        // constructor injection, in case EmailAlertObserver is used some other observable
        public EmailAlertObserver(string emailId, IObservable observable)
        {
            _emailId = emailId;
            this.observable = observable;
        }

        public void Update()
        {
            SendEmail(_emailId);
        }

        public static void SendEmail(string email)
        {
            Console.WriteLine($"Product is in stock. Mail sent to {email}");
        }
    }
}
