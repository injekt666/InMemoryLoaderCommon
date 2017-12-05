﻿//
// TestHelper.Base.cs
//
// Author: responsive kaysta <me@responsive-kaysta.ch>
//
// Copyright (c) 2017 responsive kaysta
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

using InMemoryLoaderCommon;

namespace InMemoryLoaderCommonNunit.Application
{
    /// <summary>
    /// Test helper.
    /// </summary>
    internal partial class TestHelper: AbstractCommonBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestHelper"/> class.
        /// </summary>
        /// <param name="culture">Culture.</param>
        /// <param name="path">Path.</param>
        /// <param name="initComponent">If set to <c>true</c> init component.</param>
        internal TestHelper(string culture, string path, bool initComponent)
        {
            base.ConsoleCulture = culture;
            base.AssemblyPath = path;
            if (initComponent)
            {
                InitCommonComponent();
            }
        }

        /// <summary>
        /// Inits the common component.
        /// </summary>
        void InitCommonComponent()
        {
            base.GetAssemblyPath();
            base.SetCulture();
            base.SetInMemoryLoader();
            base.SetInMemoryLoaderCommon();
            base.SetClassRegistry();
        }

    }

}