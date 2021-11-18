using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace XC_Common
{
    // Stolen from https://stackoverflow.com/questions/3377036/how-can-i-xml-serialize-a-datetimeoffset-property
    // But it doesn't pay attention to AspectToStringFormat in ObjectListView. Pity. Probably won't ever be used. 

    /// <remarks>
    /// The default value is <c>DateTimeOffset.MinValue</c>. This is a value
    /// type and has the same hash code as <c>DateTimeOffset</c>! Implicit
    /// assignment from <c>DateTime</c> is neither implemented nor desirable!
    /// </remarks>
    public struct DateTimeOffsetSerializable : IXmlSerializable
    {
        private DateTimeOffset value;

        public DateTimeOffsetSerializable(DateTimeOffset value)
        {
            this.value = value;
        }

        public static implicit operator DateTimeOffsetSerializable(DateTimeOffset value)
        {
            return new DateTimeOffsetSerializable(value);
        }

        public static implicit operator DateTimeOffset(DateTimeOffsetSerializable instance)
        {
            return instance.value;
        }

        public static bool operator ==(DateTimeOffsetSerializable a, DateTimeOffsetSerializable b)
        {
            return a.value == b.value;
        }

        public static bool operator !=(DateTimeOffsetSerializable a, DateTimeOffsetSerializable b)
        {
            return a.value != b.value;
        }

        public static bool operator <(DateTimeOffsetSerializable a, DateTimeOffsetSerializable b)
        {
            return a.value < b.value;
        }

        public static bool operator >(DateTimeOffsetSerializable a, DateTimeOffsetSerializable b)
        {
            return a.value > b.value;
        }

        public override bool Equals(object o)
        {
            if (o is DateTimeOffsetSerializable)
                return value.Equals(((DateTimeOffsetSerializable)o).value);
            else if (o is DateTimeOffset)
                return value.Equals((DateTimeOffset)o);
            else
                return false;
        }

        public override int GetHashCode()
        {
            return value.GetHashCode();
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            var text = reader.ReadElementString();

            if (text.Length == 33)
            {
                // 2011-11-11T15:05:46.4733406+01:00
                value = DateTimeOffset.ParseExact(text, format: "o", CultureInfo.InvariantCulture);
            }
            else
            {
                string format = "yyyy-MM-ddTHH:mm:sszzz";
                value = DateTimeOffset.ParseExact(text, format, formatProvider: CultureInfo.InvariantCulture);
            }
            //value = DateTimeOffset.ParseExact(text, format: "o", formatProvider: null);
        }

        public override string ToString()
        {
            return value.ToString(format: "o");
        }

        public string ToString(string format)
        {
            return value.ToString(format);
        }
        public string ToString(string format, IFormatProvider provider)
        {
            return value.ToString(format, provider);
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteString(value.ToString(format: "o"));
        }
    }
}
