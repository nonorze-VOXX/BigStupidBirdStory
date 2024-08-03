using UnityEngine;

namespace DefaultNamespace
{
    public class SingleTon<T> : MonoBehaviour where T : new()
    {
        private static T instance;

        public static T GetInstance()
        {
            if (instance == null) instance = new T();

            return instance;
        }
    }
}