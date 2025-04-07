using System.Reflection;

namespace chapter03_6Apr2025.Common
{
    public class PropertyHelper
    {
        public static string[] GetPropertyList(Type objType, string labelName)
        {
            PropertyInfo[] properties = objType.GetProperties();
            List<string> propertyNames = new List<string>();

            foreach (PropertyInfo property in properties)
            {
                if (property.Name != labelName)
                {
                    propertyNames.Add(property.Name);
                }
            }

            return propertyNames.ToArray();
        }
    }

}
