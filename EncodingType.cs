// Copyright (c) 2009 Mark Beaton
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.

namespace TidyManaged
{
	/// <summary>
	/// Represents the supported encodings.
	/// </summary>
	public enum EncodingType
	{
		Raw = 0,
		Ascii = 1,
		Latin0 = 2,
		Latin1 = 3,
		Utf8 = 4,
		Iso2022 = 5,
		MacRoman = 6,
		Win1252 = 7,
		Ibm858 = 8,
#if (!NO_SUPPORT_UTF16_ENCODINGS)
		Utf16LittleEndian = 9,
		Utf16BigEndian = 10,
		Utf16 = 11,
#endif
#if (!NO_SUPPORT_ASIAN_ENCODINGS)
#if (!NO_SUPPORT_UTF16_ENCODINGS)
		Big5 = 12,
		ShiftJIS = 13
#else
		Big5 = 9,
		ShiftJIS = 10
#endif
#endif
	}
}
