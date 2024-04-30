using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareIIb.DAL.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DateTimeKindAttribute : Attribute
    {
        private readonly DateTimeKind _kind;
        private readonly DateTimeKind _propKind;

        public DateTimeKindAttribute(DateTimeKind readKind, DateTimeKind propKind = DateTimeKind.Local )
        {
            _kind = readKind;
            _propKind = propKind;
        }

        public DateTimeKind Kind
        {
            get { return _kind; }
        }

        public DateTimeKind PropKind
        {
            get { return _propKind; }
        }

        public static void Apply(object entity)
        {
            if (entity == null)
                return;

            var properties = entity.GetType().GetProperties()
                .Where(x => x.PropertyType == typeof(DateTime) || x.PropertyType == typeof(DateTime?));

            foreach (var property in properties)
            {
                var attr = property.GetCustomAttribute<DateTimeKindAttribute>();
                if (attr == null)
                    continue;

                var dt = property.PropertyType == typeof(DateTime?)
                    ? (DateTime?)property.GetValue(entity)
                    : (DateTime)property.GetValue(entity);

                if (dt == null)
                    continue;

                if (dt.Value.Kind == DateTimeKind.Local)
                {
                    dt = dt.Value.ToUniversalTime();
                }
                if (attr.Kind != attr.PropKind)
                {
                    switch (attr.PropKind) {
                        case DateTimeKind.Local:
                            property.SetValue(entity, DateTime.SpecifyKind(dt.Value, attr.Kind).ToLocalTime());
                            break;
                        case DateTimeKind.Utc:
                            property.SetValue(entity, DateTime.SpecifyKind(dt.Value, attr.Kind).ToUniversalTime());
                            break;
                        default:
                            // default is property to be local time
                            property.SetValue(entity, DateTime.SpecifyKind(dt.Value, attr.Kind).ToLocalTime());
                            break;
                    }
                }
            }
        }
    }
}
