namespace Testing
{
    public class StrOperations
    {
        // Конкатенация двух строк
        public string Concatenate(string str1, string str2)
        {
            return str1 + str2;
        }

        // Преобразование в верхний регистр
        public string ToUpperCase(string input)
        {
            return input.ToUpper();
        }

        // Преобразование в нижний регистр
        public string ToLowerCase(string input)
        {
            return input.ToLower();
        }

        // Проверка, содержит ли строка подстроку
        public bool ContainsSubstring(string mainStr, string subStr)
        {
            return mainStr.Contains(subStr);
        }

        // Замена символов в строке
        public string ReplaceSubstring(string input, string oldValue, string newValue)
        {
            return input.Replace(oldValue, newValue);
        }
    }
}
