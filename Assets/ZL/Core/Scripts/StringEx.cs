using System;

using System.Collections.Generic;

using System.Linq;

using Unity.VisualScripting;

using ZL.CS;

namespace ZL.Unity
{
    public static partial class StringEx
    {
        public static string Concat(params char[] characters)
        {
            int length = characters.Length;

            return string.Create(length, characters, (span, state) =>
            {
                for (int i = 0; i < length; ++i)
                {
                    span[i] = state[i];
                }
            });
        }

        public static bool IsNullOrEmpty(this string instance)
        {
            return string.IsNullOrEmpty(instance);
        }

        public static string RemoveFromFront(this string instance, string toRemove)
        {
            return instance.Remove(instance.IndexOf(toRemove), toRemove.Length);
        }

        public static string RemoveFromBehind(this string instance, string toRemove)
        {
            return instance.Remove(instance.LastIndexOf(toRemove), toRemove.Length);
        }

        public static string Append(this string instance, char value)
        {
            int length = instance.Length;

            return string.Create(length + 1, instance, (span, state) =>
            {
                for (int i = 0; i < length; ++i)
                {
                    span[i] = state[i];
                }

                span[length] = value;
            });
        }

        public static string ToCamelCase(this string instance)
        {
            return instance.ToLetterCase(LetterCaseStyle.Camel);
        }

        public static string ToPascalCase(this string instance)
        {
            return instance.ToLetterCase(LetterCaseStyle.Title);
        }

        public static string ToUpperCase(this string instance)
        {
            return instance.ToLetterCase(LetterCaseStyle.Upper, ' ');
        }

        public static string ToTitleCase(this string instance)
        {
            return instance.ToLetterCase(LetterCaseStyle.Title, ' ');
        }

        public static string ToSentenceCase(this string instance)
        {
            return instance.ToLetterCase(LetterCaseStyle.Sentence, ' ');
        }

        public static string ToKebabCase(this string instance)
        {
            return instance.ToLetterCase(LetterCaseStyle.Lower, '-');
        }

        public static string ToUpperKebabCase(this string instance)
        {
            return instance.ToLetterCase(LetterCaseStyle.Upper, '-');
        }

        public static string ToSnakeCase(this string instance)
        {
            return instance.ToLetterCase(LetterCaseStyle.Lower, '_');
        }

        public static string ToUpperSnakeCase(this string instance)
        {
            return instance.ToLetterCase(LetterCaseStyle.Upper, '_');
        }

        public static string ToLetterCase(this string instance, LetterCaseStyle style, char separator = '\0')
        {
            switch (style)
            {
                case LetterCaseStyle.Upper:

                    instance = instance.SplitToWords().Join(separator);

                    instance = instance.ToUpper();

                    break;

                case LetterCaseStyle.Title:

                    instance = instance.SplitToWords().Select((word) => word.ToUpperInitial()).Join(separator);

                    break;

                case LetterCaseStyle.Sentence:

                    instance = instance.SplitToWords().Select((word) => word.ToLower()).Join(separator);

                    instance = instance.ToUpperInitial();

                    break;

                case LetterCaseStyle.Camel:

                    instance = instance.SplitToWords().Select((word) => word.ToUpperInitial()).Join(separator);

                    instance = instance.ToLowerInitial();

                    break;

                case LetterCaseStyle.Lower:

                    instance = instance.SplitToWords().Join(separator);

                    instance = instance.ToLower();

                    break;
            }

            return instance;
        }

        public static string Join<T>(this IEnumerable<T> instance, char separator = '\0')
        {
            if (separator == '\0')
            {
                return string.Join("", instance);
            }

            return string.Join(separator, instance);
        }

        private static readonly char[] splitSeparator = new char[] { ' ', '-', '_' };

        public static string[] SplitToWords(this string instance)
        {
            var words = instance.SplitWords(' ');

            return words.Split(splitSeparator, StringSplitOptions.RemoveEmptyEntries);
        }

        public static string ToUpperInitial(this string instance)
        {
            if (instance.IsNullOrEmpty() == true)
            {
                return "";
            }

            char initial = char.ToUpper(instance[0]);

            if (instance.Length > 1)
            {
                instance.ToLower();

                return initial.Append(instance[1..]);
            }

            return initial.ToString();
        }

        public static string ToLowerInitial(this string instance)
        {
            if (instance.IsNullOrEmpty() == true)
            {
                return "";
            }

            char initial = char.ToLower(instance[0]);

            if (instance.Length > 1)
            {
                return initial.Append(instance[1..]);
            }

            return initial.ToString();
        }
    }
}