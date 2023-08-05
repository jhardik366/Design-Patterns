using ObserverPattern.Observable;
using ObserverPattern.Observer;

class Program
{
    public static void Main()
    {
        /*
            Observable: IPhoneStockObservable
            Observer: EmailAlertObserver, MessageAlertObserve
         */

        IphoneStockObservable iphoneStockObservable = new IphoneStockObservable();

        EmailAlertObserver emailAlertObserver = new EmailAlertObserver("test@yopmail.com", iphoneStockObservable);
        EmailAlertObserver emailAlertObserver1 = new EmailAlertObserver("test1@yopmail.com", iphoneStockObservable);
        MessageAlertObserver messageAlertObserver = new MessageAlertObserver("+91 9999999999", iphoneStockObservable);

        iphoneStockObservable.Add(emailAlertObserver);
        iphoneStockObservable.Add(emailAlertObserver1);
        iphoneStockObservable.Add(messageAlertObserver);

        iphoneStockObservable.SetStockCount(10);
        iphoneStockObservable.SetStockCount(0);
        iphoneStockObservable.SetStockCount(50);
    }
}