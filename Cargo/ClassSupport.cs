namespace Cargo
{
    public static class ClassSupport
    {
        public static string AddClass(this string currentClass, string? classToAdd)
        {
            if (!String.IsNullOrWhiteSpace(classToAdd) && !currentClass.Contains(classToAdd)) return currentClass + " " + classToAdd;
            return currentClass;
        }

        public static string ToggleClass(this string currentClass, string? classToToggle)
        {
            if (!String.IsNullOrWhiteSpace(classToToggle))
            {
                int index = currentClass.IndexOf(classToToggle);

                if (index == 0 && currentClass.Length == classToToggle.Length)
                {
                    return String.Empty;
                }

                if (index == 0)
                {
                    return currentClass.Remove(index, classToToggle.Length + 1);
                }

                if (index == -1)
                {
                    return currentClass + " " + classToToggle;
                }

                if (index > 0)
                {
                    return currentClass.Remove(index - 1, classToToggle.Length + 1);
                }
            }
            return currentClass;
        }
    }
}
