namespace P02_Bridge.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using P02_Bridge.Implementation.Models;

    public class ColorFactory
    {
        private const string COLOR_SUFFIX = "color";

        private const string INVALID_COLOR_ERROR_MESSAGE = "Invalid color type!";

        public Color Create(string colorType)
        {
            colorType = colorType.ToLower() + COLOR_SUFFIX;

            Type type = Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name.ToLower() == colorType);

            if (type == null)
            {
                throw new ArgumentException(INVALID_COLOR_ERROR_MESSAGE);
            }

            Color color = (Color)Activator.CreateInstance(type);

            return color;
        }
    }
}
