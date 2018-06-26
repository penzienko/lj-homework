using System;

namespace lj_framework.Utils
{
    public static class ParseUrl
    {
        public static string GetAbsolutePath(Uri url)
        {
            return url.AbsolutePath;
        }
    }
}
