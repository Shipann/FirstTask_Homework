namespace EnumHW
{
    enum Direction
    {
        
        Eror400series = 1, BadRequest = 400, Unauthorized, PaymentRequired, Forbidden, NotFound,
                        MethodNotAllowed, NotAcceptable, ProxyAuthenticationRequired, RequestTimeout,
                        Conflict, Gone, LenghtRequired, PreconditionFailed, PayloadTooLarge, URLTooLong,
                        UnsupportedMediatype, RangeNotSasfiable, ExpectationFailed, ImATeapot, AuthenticationTimeout,
                        MisdirectedRequest = 421, UnprocessableEntity, Locked, FailedDependency, TooEarly,
                        UpgradeRequired, PreconditionRequired = 428, TooManyRequests, RequestHeaderFieldsTooLarge = 431,
                        RetryWith = 449, UnavailableForLegalReasons = 451, ClientClosedRequest = 499
    }
    internal class EnumTusk
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of eror 400 series ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine((Direction)a);
        }
    }
}