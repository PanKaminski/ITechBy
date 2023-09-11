namespace Services.Abstractions.Common.OperationResult
{
    public class ServerOperationResult
    {
        public ServerOperationResult(ResultCode resultCode, ServerMessageCode messageCode = ServerMessageCode.None)
        {
            ResultCode = resultCode;
            MessageCode = messageCode;
        }

        public ResultCode ResultCode { get; set; }

        public ServerMessageCode MessageCode { get; set; }
    }
}
