using System;

namespace AspNetIdentity.Utilities
{
    public static class ExceptionExtension
    {
        public static string GetMessage(this Exception ex)
        {
            return ex.InnerException != null && !string.IsNullOrEmpty(ex.InnerException.Message) ? ex.InnerException.Message : ex.Message;
        }
    }
}
