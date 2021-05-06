#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class AppleTangle
    {
        private static byte[] data = System.Convert.FromBase64String("wc/Gg9DXws3HwtHHg9fG0c7Qg8LELKsXg1RoD4+DzNMVnKKTLxTgbIyTImClq4iloqampKGhkyIVuSIQI7eIc8rkN9WqXVfILo3jBVTk7tyN4wVU5O7cq/2TvKWg9r6Ap7uTtauIpaKmpqShorW9y9fX09CZjIzUC3/dgZZphnZ6rHXIdwGHgLJUAg+npbCh9vCSsJOypaD2p6mwqeLT09HCwNfKwMaD0NfC18bOxs3X0I2TNj3ZrwfkKPh3tZSQaGes7m23ynKloPa+rae1p7eIc8rkN9WqXVfILvoEpqrftOP1sr3XcBQogJjkAHbMCADSMeTw9mIMjOIQW1hA025FAO+8JiAmuDqe5JRRCjjjLY93EjOxe4WTh6Wg9qeosL7i09PPxoPgxtHXpE/emiAo8INwm2cSHDnsqchciF8Sk/tP+aeRL8sQLL59xtBcxP3GH4PCzceDwMbR18rFysDC18rMzYPTz8aD6s3AjZKFk4eloPanqLC+4tOupaqJJeslVK6ioqamo6AhoqKj/xaZDlesraMxqBKCtY3Xdp+ueMG1epXcYiT2egQ6GpHhWHt20j3dAvFqutFW/q123Pw4UYagGfYs7v6uUodBSHIU03ys5kKEaVLO205EFrS008/Gg/HMzNeD4OKTvbSuk5WTl5Hxxs/Kws3AxoPMzYPXy8rQg8DG0Si6Kn1a6M9WpAiBk6FLu51b86pwtZO3paD2p6CwruLT08/Gg/HMzNfag8LQ0NbOxtCDwsDAxtPXws3AxpaRkpeTkJX5tK6QlpORk5qRkpeTkyGnGJMhoAADoKGioaGioZOuparm3bzvyPM14ipn18GosyDiJJApItfLzNHK19qStZO3paD2p6CwruLTrD6eUIjqi7lrXW0WGq16/b91aJ6lk6yloPa+sKKiXKemk6CiolyTvokl6yVUrqKipqajk8GSqJOqpaD2g+DikyGigZOupaqJJeslVK6ioqKTsqWg9qepsKni09PPxoPqzcCNkmPAkNRUmaSP9Uh5rIKteRnQuuwW6nvVPJC3xgLUN2qOoaCio6IAIaKr/ZMhorKloPa+g6choquTIaKnkxS4HjDhh7GJZKy+Fe4//cBr6CO008/Gg+DG0dfKxcrAwtfKzM2D4taehcSDKZDJVK4hbH1IAIxa8Mn4x9ziCztacmnFP4fIsnMAGEe4iWC81NSNwtPTz8aNwMzOjMLT08/GwMLNx4PAzM3HytfKzM3Qg8zFg9bQxseWgLbotvq+EDdUVT89bPMZYvvzLNAiw2W4+KqMMRFb5+tTw5s9tlaQlfmTwZKok6qloPanpbCh9vCSsMrFysDC18rMzYPi1tfLzNHK19qSg8zFg9fLxoPXy8bNg8LT08/KwMLXysXKwMLXxoPB2oPCzdqD08LR14+DwMbR18rFysDC18aD08zPysDapqOgIaKso5MhoqmhIaKio0cyCqohoqOlqokl6yVUwMemopMiUZOJpZU6747bFE4vOH9Q1DhR1XHUk+xivDJ4veTzSKZO/donjkiVAfTv9k8dV9A4TXHHrGja7Jd7AZ1a21zIa9mTIaLVk62loPa+rKKiXKenoKGi8wkpdnlHX3OqpJQT1taC");
        private static int[] order = new int[] { 42,21,37,32,31,35,54,37,46,18,30,52,24,49,30,51,26,45,32,47,23,58,47,53,54,38,26,54,40,37,42,38,35,47,37,58,49,58,57,54,47,59,57,56,45,49,56,53,55,56,52,59,54,56,57,58,58,59,59,59,60 };
        private static int key = 163;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
