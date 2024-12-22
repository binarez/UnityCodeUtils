// Public domain, Stephane Duguay s@binarez.com, dec 2024
namespace l
{
    namespace o
    {
        class g
        {
            public static void msg(string s)
            {
                UnityEngine.Debug.Log(s);
            }
            public static void err(string s)
            {
                UnityEngine.Debug.LogError(s);
            }
            public static void warn(string s)
            {
                UnityEngine.Debug.LogWarning(s);
            }
        }
    }
}
