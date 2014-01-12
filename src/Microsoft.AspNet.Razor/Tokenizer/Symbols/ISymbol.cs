﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using Microsoft.AspNet.Razor.Text;

namespace Microsoft.AspNet.Razor.Tokenizer.Symbols
{
    public interface ISymbol
    {
        SourceLocation Start { get; }
        string Content { get; }

        void OffsetStart(SourceLocation documentStart);
        void ChangeStart(SourceLocation newStart);
    }
}
