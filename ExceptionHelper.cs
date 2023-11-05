using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5_GenericsTask_Due5Nov.Exceptions;

namespace Week5_GenericsTask_Due5Nov
{
    internal static class ExceptionHelper
    {
        private const string CustomIndexOutOfBoundsExceptionMessage = "Index out of bounds";
        private const string CustomCustomArgumentOutOfBoundsException = "Argument out of bounds";

        public static void ThrowCustomIndexOutOfBoundsException(string msg = CustomIndexOutOfBoundsExceptionMessage)
            => throw new CustomIndexOutOfBoundsException(msg);

        public static void ThrowCustomArgumentOutOfBoundsException(string msg = CustomArgumentOutOfBoundsException)
            => throw new CustomCustomArgumentOutOfBoundsException(msg);
    }
}
