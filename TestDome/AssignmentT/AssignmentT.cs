using AssignmentTDome;
using System;
using System.Linq;
using System.Reflection;

namespace AssignmentT
{
    public class AssignmentT
    {
        public static T ToT<T>(object Source, T t)
        {
            var sourceProperties = Source.GetType().GetProperties();
            var tProperties = t.GetType().GetProperties();

            foreach (PropertyInfo item in sourceProperties)
            {
                var tPropertie = tProperties.FirstOrDefault(x => x.Name == item.Name);
                if (tPropertie != null)
                {
                    var val = new object();
                    switch (item.PropertyType.FullName)
                    {
                        case "System.String": val = item.GetValue(Source) + ""; break;
                        case "System.Int32": val = StringExtension.StringConvertToInt(item.GetValue(Source) + ""); break;
                        case "System.Boolean": val = StringExtension.StringFormat(item.GetValue(Source) + ""); break;
                        default:
                            break;
                    }
                    tPropertie.SetValue(t, val);
                }
            }

            return t;
        }
    }
}
