﻿// Copyright (c) Microsoft Corporation.  All Rights Reserved.  See License.txt in the project root for license information.

using System;
using Microsoft.Tools.WindowsInstallerXml;

namespace FSharp.WIX.Extensions
{
    public class FSharpWixExtension : WixExtension
    {
        private readonly Lazy<FSharpPreprocessorExtension> preprocessorExtension = new Lazy<FSharpPreprocessorExtension>();

        public override PreprocessorExtension PreprocessorExtension
        {
            get { return this.preprocessorExtension.Value; }
        }
    }
}
