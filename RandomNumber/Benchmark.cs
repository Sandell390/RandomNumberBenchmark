using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;

namespace RandomNumber;

public class Benchmark
{
    [Benchmark]
    public void Random()
    {
        Random random = new Random();
        for(int i = 0; i < 1000; i++)
        {
            random.Next();
        }
    }
    
    [Benchmark]
    public void CryptoRandom()
    {
        RandomNumberGenerator generator = RandomNumberGenerator.Create();
        Span<Byte> bytes = stackalloc Byte[4];
        for (int i = 0; i < 1000; i++)
        {
            generator.GetNonZeroBytes(bytes);
            BitConverter.ToInt32(bytes); 
        }
    }
}