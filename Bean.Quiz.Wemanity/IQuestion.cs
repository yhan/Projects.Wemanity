using System;

namespace Bean.Q.Wemanity
{
    public interface IQuestion : IEquatable<IQuestion>
    {
        TypeQuestion Type { get; }
        int Id { get; }

    }
}