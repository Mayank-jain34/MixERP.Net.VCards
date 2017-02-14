using MixERP.Net.VCards.Models;
using MixERP.Net.VCards.Types;

namespace MixERP.Net.VCards.Processors
{
    internal static class SoundProcessor
    {
        internal static string Serialize(VCard vcard)
        {
            //The property "SOUND" is valid only for VCardVersion 3.0 and above.
            if (vcard.Version == VCardVersion.V2_1)
            {
                return string.Empty;
            }

            return Base64ImageProcessor.SerializeBase64String(vcard.Sound, "SOUND", "BASIC", vcard.Version);
        }

        internal static void Parse(Token token, ref VCard vcard)
        {
            vcard.Sound = token.Values[0];
        }
    }
}