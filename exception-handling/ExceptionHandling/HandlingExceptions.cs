using System;

namespace ExceptionHandling
{
    public static class HandlingExceptions
    {
        public static bool CatchException(object obj)
        {
            try
            {
                if (obj is null)
                {
                    throw new ArgumentNullException(nameof(obj));
                }
            }
            catch (ArgumentNullException)
            {
                return true;
            }

            return false;
        }

        public static bool CatchArgumentNullException(object obj, out string exceptionMessage)
        {
            exceptionMessage = string.Empty;

            try
            {
                if (obj is null)
                {
                    throw new ArgumentNullException(exceptionMessage);
                }
            }
            catch (ArgumentNullException)
            {
                exceptionMessage = $"obj is null. (Parameter '{nameof(obj)}')";
                return true;
            }

            return false;
        }

        public static bool CatchArgumentException(int i, out string exceptionMessage)
        {
            exceptionMessage = string.Empty;
            try
            {
                if (i is 0)
                {
                    throw new ArgumentException(nameof(i) + exceptionMessage);
                }
            }
            catch (ArgumentException)
            {
                exceptionMessage = $"{nameof(i)} parameter is invalid. (Parameter '{nameof(i)}')";
                return true;
            }

            return false;
        }

        public static bool CatchArgumentOutOfRangeException(int j, out string exceptionMessage)
        {
            exceptionMessage = string.Empty;
            try
            {
                if (j < 0 || j > 10)
                {
                    throw new ArgumentOutOfRangeException(exceptionMessage);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                exceptionMessage = $"{nameof(j)} is out of range. (Parameter '{nameof(j)}')";
                return true;
            }

            return false;
        }

        public static bool CatchExceptions(object obj, int i, int j, bool throwException, out string exceptionMessage)
        {
            exceptionMessage = string.Empty;

            try
            {
                if (obj is null)
                {
                    throw new ArgumentNullException(nameof(obj), "obj is null.");
                }

                if (i is 0)
                {
                    throw new ArgumentException("i parameter is invalid.", nameof(i));
                }

                if (j < 0 || j > 10)
                {
                    throw new ArgumentOutOfRangeException(nameof(j), "j is out of range.");
                }

                if (throwException)
                {
                    throw new AggregateException("exception is thrown.");
                }
            }
            catch (ArgumentNullException)
            {
                exceptionMessage = $"obj is null. (Parameter '{nameof(obj)}')";
                return true;
            }
            catch (ArgumentOutOfRangeException)
            {
                exceptionMessage = $"{nameof(j)} is out of range. (Parameter '{nameof(j)}')";
                return true;
            }
            catch (ArgumentException)
            {
                exceptionMessage = $"{nameof(i)} parameter is invalid. (Parameter '{nameof(i)}')";
                return true;
            }
            catch (AggregateException)
            {
                exceptionMessage = "exception is thrown.";
                return true;
            }

            return false;
        }
    }
}
