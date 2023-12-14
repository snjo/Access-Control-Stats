using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Control_Stats
{
    internal static class EncodingTools
    {
        /// <summary>
        /// Get encoding from an encoding name or alias
        /// </summary>
        /// <param name="encodingName">name of an encoding</param>
        /// <returns>encoding matching the codepage, or UTF-8 if it can't be found<</returns>
        public static (Encoding encoding, bool byteOrderMark) GetEncoding(string encodingName)
        {
            bool ByteOrderMark = false;
            Debug.WriteLine("Getting encoding from value:" + encodingName);
            switch (encodingName.ToLowerInvariant())
            {
                case "":
                    return (Encoding.UTF8, ByteOrderMark);
                case "default":
                    return (Encoding.Default, ByteOrderMark);
                case "utf-8":
                case "utf8":
                    return (Encoding.UTF8, ByteOrderMark);
                case "utf-8-bom":
                case "utf8bom":
                    ByteOrderMark = true;
                    return (Encoding.UTF8, ByteOrderMark);
                case "latin1":
                    return (Encoding.Latin1, ByteOrderMark);
                case "ascii":
                    return (Encoding.ASCII, ByteOrderMark);
                case "ansi":
                    return (Encoding.GetEncoding("ISO-8859-1"), ByteOrderMark);
                default:
                    try
                    {
                        Debug.WriteLine("Custom encoding detected");
                        if (int.TryParse(encodingName, out int value))
                        {
                            Debug.WriteLine("Encoding, parsing codepage: " + value);
                            Debug.WriteLine("Encoding result:" + GetEncodingDOS(value).EncodingName);
                            return (GetEncodingDOS(value), ByteOrderMark);
                        }
                        else
                        {
                            Debug.WriteLine("Encoding, parsing name: " + encodingName);
                            Debug.WriteLine("Encoding result:" + Encoding.GetEncoding(encodingName));
                            return (Encoding.GetEncoding(encodingName), ByteOrderMark);
                        }
                    }
                    catch
                    {
                        Debug.WriteLine("Error parsing encoding " + encodingName);
                        return (Encoding.UTF8, ByteOrderMark); // should be unreachable
                    }
            }
        }

        /// <summary>
        /// Gets the encoding corresponding with a numbered codepage
        /// </summary>
        /// <param name="codepage">a numbered codepage</param>
        /// <returns>encoding matching the codepage, or UTF-8 if it can't be found</returns>
        public static Encoding GetEncodingDOS(int codepage)
        {
            Encoding encoding;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            try
            {
                encoding = Encoding.GetEncoding(codepage);
            }
            catch
            {
                encoding = Encoding.UTF8;
            }
            return encoding;
        }
    }
}
