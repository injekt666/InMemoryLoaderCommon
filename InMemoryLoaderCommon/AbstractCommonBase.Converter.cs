﻿//
// AbstractCommonBase.Converter.cs
//
// Author: Kay Stuckenschmidt
//
// Copyright (c) 2019 responsive IT
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System.IO;
using System.Text;
using System.Threading.Tasks;
using InMemoryLoader;
using InMemoryLoaderBase;

namespace InMemoryLoaderCommon
{
    public abstract partial class AbstractCommonBase : AbstractLoaderBase
    {

        #region Converter

        IDynamicClassInfo Converter;
        bool CoverterSet;

        private void SetConverter()
        {
            if (Converter == null)
            {
                Converter = ComponentLoader.GetClassReference("Converter");
            }
            CoverterSet = true;
        }

        // StringToBoolean
        // ####################################################################################

        public dynamic StringToBoolean(string paramValue)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramValue };
            return ComponentLoader.InvokeMethod(Converter, "StringToBoolean", paramArgs);
        }

        public async Task<dynamic> StringToBooleanAsync(string paramValue)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramValue };
            return await InvokeMethodAsync(Converter, "StringToBoolean", paramArgs);
        }


        // CharToBoolean
        // ####################################################################################

        public dynamic CharToBoolean(char paramValue)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramValue };
            return ComponentLoader.InvokeMethod(Converter, "CharToBoolean", paramArgs);
        }

        public async Task<dynamic> CharToBooleanAsync(char paramValue)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramValue };
            return await InvokeMethodAsync(Converter, "CharToBoolean", paramArgs);
        }


        // BooleanToString
        // ####################################################################################

        public dynamic BooleanToString(bool paramValue)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramValue };
            return ComponentLoader.InvokeMethod(Converter, "BooleanToString", paramArgs);
        }

        public async Task<dynamic> BooleanToStringAsync(bool paramValue)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramValue };
            return await InvokeMethodAsync(Converter, "BooleanToString", paramArgs);
        }


        // BooleanToChar
        // ####################################################################################

        public dynamic BooleanToChar(bool paramValue)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramValue };
            return ComponentLoader.InvokeMethod(Converter, "BooleanToChar", paramArgs);
        }

        public async Task<dynamic> BooleanToCharAsync(bool paramValue)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramValue };
            return await InvokeMethodAsync(Converter, "BooleanToChar", paramArgs);
        }


        // StringToByteArray
        // ####################################################################################

        public dynamic StringToByteArray(string paramValue)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramValue };
            return ComponentLoader.InvokeMethod(Converter, "StringToByteArray", paramArgs);
        }

        public async Task<dynamic> StringToByteArrayAsync(string paramValue)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramValue };
            return await InvokeMethodAsync(Converter, "StringToByteArray", paramArgs);
        }

        public dynamic StringToByteArray(string paramValue, Encoding encoding)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramValue };
            return ComponentLoader.InvokeMethod(Converter, "StringToByteArray", paramArgs);
        }

        public async Task<dynamic> StringToByteArrayAsync(string paramValue, Encoding encoding)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramValue };
            return await InvokeMethodAsync(Converter, "StringToByteArray", paramArgs);
        }


        // StringToHashtable
        // ####################################################################################

        public dynamic StringToHashtable(string paramValue, char paramDelimit)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramValue, paramDelimit };
            return ComponentLoader.InvokeMethod(Converter, "StringToHashtable", paramArgs);
        }

        public async Task<dynamic> StringToHashtableAsync(string paramValue, char paramDelimit)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramValue, paramDelimit };
            return await InvokeMethodAsync(Converter, "StringToHashtable", paramArgs);
        }


        // MemoryStreamToString
        // ####################################################################################

        public dynamic MemoryStreamToString(MemoryStream parmStream)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { parmStream };
            return ComponentLoader.InvokeMethod(Converter, "MemoryStreamToString", paramArgs);
        }

        public async Task<dynamic> MemoryStreamToStringAsync(MemoryStream parmStream)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { parmStream };
            return await InvokeMethodAsync(Converter, "MemoryStreamToString", paramArgs);
        }


        // ByteArrayToString
        // ####################################################################################

        public dynamic ByteArrayToString(byte[] paramByteArray)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramByteArray };
            return ComponentLoader.InvokeMethod(Converter, "ByteArrayToString", paramArgs);
        }

        public async Task<dynamic> ByteArrayToStringAsync(byte[] paramByteArray)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramByteArray };
            return await InvokeMethodAsync(Converter, "ByteArrayToString", paramArgs);
        }

        public dynamic ByteArrayToString(byte[] paramByteArray, Encoding paramEncoding)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramByteArray, paramEncoding };
            return ComponentLoader.InvokeMethod(Converter, "ByteArrayToString", paramArgs);
        }

        public async Task<dynamic> ByteArrayToStringAsync(byte[] paramByteArray, Encoding paramEncoding)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramByteArray, paramEncoding };
            return await InvokeMethodAsync(Converter, "ByteArrayToString", paramArgs);
        }


        // StringFromUtf8ToAscii
        // ####################################################################################

        public dynamic StringFromUtf8ToAscii(string paramValue)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramValue };
            return ComponentLoader.InvokeMethod(Converter, "StringFromUtf8ToAscii", paramArgs);
        }

        public async Task<dynamic> StringFromUtf8ToAsciiAsync(string paramValue)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramValue };
            return await InvokeMethodAsync(Converter, "StringFromUtf8ToAscii", paramArgs);
        }


        // StringFromUtf8ToLatin1
        // ####################################################################################

        public dynamic StringFromUtf8ToLatin1(string paramValue)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramValue };
            return ComponentLoader.InvokeMethod(Converter, "StringFromUtf8ToLatin1", paramArgs);
        }

        public async Task<dynamic> StringFromUtf8ToLatin1Async(string paramValue)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramValue };
            return await InvokeMethodAsync(Converter, "StringFromUtf8ToLatin1", paramArgs);
        }


        // StringTo converter
        // ####################################################################################

        public dynamic TryParseStringToLong(string paramValue)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramValue };
            return ComponentLoader.InvokeMethod(Converter, "TryParseStringToLong", paramArgs);
        }

        public async Task<dynamic> TryParseStringToLongAsync(string paramValue)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramValue };
            return await InvokeMethodAsync(Converter, "TryParseStringToLong", paramArgs);
        }


        public dynamic TryParseStringToInt(string paramValue)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramValue };
            return ComponentLoader.InvokeMethod(Converter, "TryParseStringToInt", paramArgs);
        }

        public async Task<dynamic> TryParseStringToIntAsync(string paramValue)
        {
            if (!CoverterSet) SetConverter();
            object[] paramArgs = { paramValue };
            return await InvokeMethodAsync(Converter, "TryParseStringToInt", paramArgs);
        }


        #endregion

    }

}
