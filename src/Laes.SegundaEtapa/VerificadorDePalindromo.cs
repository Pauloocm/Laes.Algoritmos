namespace Laes.SegundaEtapa
{
    public static class VerificadorDePalindromo
    {
        public static bool IsPalindrome(string s)
        {
            if (s.Length == 1) return true;

            var value = string.Concat(s.Where(c => Char.IsLetter(c))).ToLower();

            if (string.IsNullOrWhiteSpace(value)) return true;

            if (value.Length == 1 && s.Any(c => Char.IsNumber(c)))
            {
                return false;
            }
            else if (value.Length == 1 && !Char.IsNumber(s[1]))
            {
                return true;
            }

            return value == string.Concat(value.Reverse());
        }
    }
}
