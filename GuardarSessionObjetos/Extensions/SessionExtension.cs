using Newtonsoft.Json;

namespace GuardarSessionObjetos.Extensions
{
    public static class SessionExtension
    {
        //MÉTODO PARA RECUPERAR CUALQUIER OBJETO
        public static T GetObject<T>(this ISession session , string key)
        {
            string json = session.GetString(key);
            if(json == null)
            {
                return default(T);
            }
            else
            {
                T data = JsonConvert.DeserializeObject<T>(json);
                return data;
            }
        }

        //MÉTODO PARA ALMACENAR CUALQUIER OBJETO
        public static void SetObject(this ISession session, string key, object value)
        {
            string data = JsonConvert.SerializeObject(value);
            session.SetString(key, data);
        }
    }
}
