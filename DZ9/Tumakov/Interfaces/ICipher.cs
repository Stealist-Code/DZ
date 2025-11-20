using System;

namespace Tumakov.Interfaces
{
    public interface ICipher
    {
        void Encode(string input);
        void Decode();
    }
}
