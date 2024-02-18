namespace w3schools.Managers
{
    public static class Utility
    {
        public static bool IsNumOnly(this string me)
        {
            if (string.IsNullOrEmpty(me)) return false;
            
            foreach (char c in me)
            {
                if (!char.IsDigit(c)) return false;
            }

            return true;
        }
    }
}
