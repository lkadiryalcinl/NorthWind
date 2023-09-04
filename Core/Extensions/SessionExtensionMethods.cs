using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Text;

namespace MvcWebUI.Extensions
{
    public static class SessionExtensionMethods
    {
        public static void SetString(this ISession session, string key, string value)
        {
            if (session == null)
            {
                throw new ArgumentNullException(nameof(session));
            }

            if (value == null)
            {
                session.Remove(key);
            }
            else
            {
                session.Set(key, Encoding.UTF8.GetBytes(value));
            }
        }

        public static string GetString(this ISession session, string key)
        {
            if (session == null)
            {
                throw new ArgumentNullException(nameof(session));
            }

            if (session.TryGetValue(key, out byte[] data))
            {
                return Encoding.UTF8.GetString(data);
            }
            return null;
        }

        public static void SetObject(this ISession session, string key, object value)
        {
            string objectString = JsonConvert.SerializeObject(value);
            session.SetString(key, objectString);
        }

        public static T GetObject<T>(this ISession session, string key)
        where T : class
        {
            string objectString = session.GetString(key);

            if (string.IsNullOrEmpty(objectString))
            {
                return null;
            }
            else
            {
                T value = JsonConvert.DeserializeObject<T>(objectString);
                return value;
            }
        }

    }
}
