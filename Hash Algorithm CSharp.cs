using System;

namespace Program {
    class HashAlgorithm {
        static void BasicHash() {
            string[] eng = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
                            "n", "o","p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};

            Console.WriteLine (eng[5].ToUpper()+eng[20]+eng[2]+eng[10]+" "+eng[15].ToUpper()+
                               eng[17]+eng[0]+eng[24]+eng[20]+eng[19]+eng[4]);
        }
        static void AdvancedHash() {
            string[] eng = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
                            "n", "o","p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
            int a = (2*4)-3;
            int b = 5*4;
            int c = (2+2)*1/2;
            int d = 100/10;
            int e = (28-4)*(3*17)-1209;
            int f = 1+(8*2);
            int g = (112/904)*0;
            int h = 12*(12/2)-(6*8);
            int i = 20+20+20+20-60;
            int j = (112*904)-101255+7+19;
            int k = 1+1+1+1+1-1;
            Console.WriteLine (eng[a].ToUpper()+eng[b]+eng[c]+eng[d]+" "+eng[e].ToUpper()+
                               eng[f]+eng[g]+eng[h]+eng[i]+eng[j]+eng[k]);
        }
        static void Main (string[] args) {
            BasicHash();
            AdvancedHash();
            Console.ReadKey();
        }
    }
}