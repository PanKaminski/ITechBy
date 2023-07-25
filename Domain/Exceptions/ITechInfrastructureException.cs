namespace Domain.Exceptions
{
    public class ITechInfrastructureException : Exception
    {
        public string[] Parameters { get; set; } = new string[0];
        public ExceptionCode ExceptionCode { get; set; }

        public ITechInfrastructureException(string message) : base(message) { }

        public ITechInfrastructureException(ExceptionCode code, string message) : base(message) 
        {
            ExceptionCode = code;
        }

        public ITechInfrastructureException(ExceptionCode code) : this(code, string.Empty)
        {
        }

        public ITechInfrastructureException(ExceptionCode code, string message, params string[] parameters) : this(code, message)
        {
            Parameters = parameters;
        }

        public ITechInfrastructureException(string message, params string[] parameters) : base(message) 
        { 
            Parameters =  parameters;
        }

        public ITechInfrastructureException(string message, Exception inner) : base(message, inner) { }

    }
}
