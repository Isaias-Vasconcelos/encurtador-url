using NanoidDotNet;

namespace Application.Utils;

public static class ShortLink
{
    public static string Generate()
    {
        var shortLink = Nanoid.Generate(Nanoid.Alphabets.Letters,7);
        return shortLink;
    }
}