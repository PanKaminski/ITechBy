namespace Domain.Exceptions
{
    public class ITechCoreException : Exception
    {
        public string[] Parameters { get; set; } = new string[0];
        public ExceptionCode ExceptionCode { get; set; }

        public ITechCoreException(string message) : base(message) { }

        public ITechCoreException(ExceptionCode code, string message) : base(message)
        {
            ExceptionCode = code;
        }

        public ITechCoreException(ExceptionCode code) : this(code, string.Empty)
        {
        }

        public ITechCoreException(ExceptionCode code, string message, params string[] parameters) : this(code, message)
        {
            Parameters = parameters;
        }

        public ITechCoreException(string message, params string[] parameters) : base(message)
        {
            Parameters = parameters;
        }

        public ITechCoreException(string message, Exception inner) : base(message, inner) { }
    }
}
