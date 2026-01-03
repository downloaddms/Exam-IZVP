namespace Exam_IZVP.Core
{
    public static class ValidationHelper
    {
        public static bool IsNotEmpty(string text) =>
            !string.IsNullOrWhiteSpace(text);

        public static bool IsNumber(string text) =>
            decimal.TryParse(text, out _);

        public static bool IsValidDate(string text) =>
            System.DateTime.TryParse(text, out _);
    }
}