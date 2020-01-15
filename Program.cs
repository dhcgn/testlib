using System;
using System.Threading;
using Org.BouncyCastle.Crypto;
using Jose;
using Newtonsoft.Json;
using Saxon.Api;
using SixLabors;

namespace TestLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("START Namesspaces");

            Console.Out.WriteLine(typeof(Org.BouncyCastle.Crypto.CryptoException).Namespace);
            Console.Out.WriteLine(typeof(Jose.AesGcm).Namespace);
            Console.Out.WriteLine(typeof(Newtonsoft.Json.JsonArrayAttribute).Namespace);
            Console.Out.WriteLine(typeof(Saxon.Api.DocumentBuilder).Namespace);
            Console.Out.WriteLine(typeof(SixLabors.GeometryUtilities).Namespace);

            Console.Out.WriteLine("END Namesspaces\r\n");

            Console.WriteLine("Hello and bye in 5s");
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }
    }
}
