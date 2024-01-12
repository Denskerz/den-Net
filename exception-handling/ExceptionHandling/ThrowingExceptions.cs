using System;

namespace ExceptionHandling
{
    public static class ThrowingExceptions
    {
        public static void CheckParameterAndThrowException(object obj)
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
        }

        public static void CheckBothParametersAndThrowException(object obj1, object obj2)
        {
            if (obj1 is null)
            {
                throw new ArgumentNullException(nameof(obj1));
            }
            else if (obj2 is null)
            {
                throw new ArgumentNullException(nameof(obj2));
            }
        }

        public static string CheckStringAndThrowException(string str)
        {
            // TODO #8. Replace the method code to throw an "ArgumentNullException" exception if the "str" parameter is null or equals to ""; otherwise return "str" value. Use string.IsNullOrEmpty method. Use "nameof" expression to get a parameter name for an exception constructor.
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException(nameof(str));
            }
            else
            {
                return str;
            }
        }

        public static string CheckBothStringsAndThrowException(string str1, string str2)
        {
            if (string.IsNullOrEmpty(str1))
            {
                throw new ArgumentNullException(nameof(str1));
            }
            else if (string.IsNullOrEmpty(str2))
            {
                throw new ArgumentNullException(nameof(str2));
            }
            else
            {
                return string.Concat(str1, str2);
            }
        }

        public static int CheckEvenNumberAndThrowException(int evenNumber)
        {
            if (evenNumber % 2 == 1)
            {
                throw new ArgumentException(null, nameof(evenNumber));
            }
            else
            {
                return evenNumber;
            }
        }

        public static int CheckCandidateAgeAndThrowException(int candidateAge, bool isCandidateWoman)
        {
            // TODO #11. Replace the method code to throw an "ArgumentOutOfRange" exception if a value of the "candidateAge" parameter is less than 16 or greater then 63 (for a male candidate) or 58 (for a female candidate); otherwise return "candidateAge" value. Use "nameof" expression to get a parameter name for an exception constructor.
            if (isCandidateWoman)
            {
                if (candidateAge < 16 || candidateAge > 58)
                {
                    throw new ArgumentOutOfRangeException(nameof(candidateAge));
                }
            }
            else if (candidateAge < 16 || candidateAge > 63)
            {
                throw new ArgumentOutOfRangeException(nameof(candidateAge));
            }

            return candidateAge;
        }

        public static string GenerateUserCode(int day, int month, string username)
        {
            // TODO #12. Add new code to the method to validate method parameters and throw exceptions in case of validation errors:
            // * Throw "ArgumentOutOfRangeException" exception if "day" parameter is less then 1 or greater then 31.
            // * Throw "ArgumentOutOfRangeException" exception if "month" parameter is less then 1 or greater then 12.
            // * Throw "ArgumentNullException" exception if "username" parameter is null or equals to "".
            // Use "nameof" expression to get a parameter name for an exception constructor.
            if (day < 1 || day > 31)
            {
                throw new ArgumentOutOfRangeException(nameof(day));
            }

            if (month < 1 || month > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(month));
            }

            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException(nameof(username));
            }

            return $"{username}-{day}{month}";
        }
    }
}
