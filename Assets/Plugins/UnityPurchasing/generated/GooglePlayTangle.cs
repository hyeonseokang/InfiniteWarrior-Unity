#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("l7MZs/g58BmmdNXvQB8H/TDWDUeUzDvhXo/g00zFvrVxP/o2Ptj58Nm36VwnF584Y0msEN3gdnQNVZHX5PdSro99yco/aCOcBFRnbTS83d2WQlwSzzvzTXs8zzLCycFrHJ3V+dDKmp35eDWUITUQIUAmHTEo3wqbHIi64PoVENPAYcjVG3OPA9yVlwVX1zJQt3P1LronIESWxeF3UEgN7aY6XdwZCOnkdb5AKz3N/kn97dpazU0zlNwOEpy96cG3dWugI/SCfQOpAv1DQ9NJ/+PtrDiem3xTIKQP0bEyPDMDsTI5MbEyMjOAGQ2S+Jk5A7EyEQM+NToZtXu1xD4yMjI2MzD+cmwQclaK6AuACA4wurMTyPjnCnGBniQZixb72jEwMjMy");
        private static int[] order = new int[] { 7,3,9,11,9,10,9,9,8,13,10,11,13,13,14 };
        private static int key = 51;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
