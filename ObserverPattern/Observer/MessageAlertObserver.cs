using ObserverPattern.Observable;

namespace ObserverPattern.Observer
{
    public class MessageAlertObserver : IObserver
    {
        string _phoneNo;
        IObservable observable;

        // constructor injection, in case MessageAlertObserver is used some other observable
        public MessageAlertObserver(string phoneNo, IObservable observable)
        {
            _phoneNo = phoneNo;
            this.observable = observable;
        }

        public void Update()
        {
            SendSMS(_phoneNo);
        }

        public static void SendSMS(string phoneNo)
        {
            Console.WriteLine($"Product is in stock. SMS sent to {phoneNo}");
        }
    }
}
