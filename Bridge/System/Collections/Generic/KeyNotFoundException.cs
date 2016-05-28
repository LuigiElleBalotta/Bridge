using Bridge;

namespace System.Collections.Generic
{
    [External]
    public class KeyNotFoundException : Exception, IBridgeClass
    {
        public extern KeyNotFoundException();

        public extern KeyNotFoundException(string message);

        public extern KeyNotFoundException(string message, Exception innerException);
    }
}