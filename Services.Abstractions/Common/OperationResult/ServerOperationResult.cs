namespace Services.Abstractions.Common.OperationResult
{
    public class ServerOperationResult
    {
        public ServerOperationResult(ResultCode resultCode, ServerMessageCode messageCode = ServerMessageCode.None, string message = null)
        {
            ResultCode = resultCode;
            MessageCode = messageCode;
            Message = message ?? string.Empty;
        }

        public ResultCode ResultCode { get; set; }

        public ServerMessageCode MessageCode { get; set; }

        public string Message { get; set; }
    }
}
