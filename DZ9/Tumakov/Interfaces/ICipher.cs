using System;

namespace Tumakov.Interfaces
{
    public interface ICipher
    {
        string Encode(string input);
        string Decode(string input);
    }
}
