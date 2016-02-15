﻿// Copyright (c) 2012 Markus Jarderot
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.

using System;

namespace AndroidXml.Res
{
    [Serializable]
    public class ResTable_entry
    {
        public ushort Size { get; set; }
        public EntryFlags Flags { get; set; }
        public ResStringPool_ref Key { get; set; }
    }

    [Flags]
    public enum EntryFlags
    {
        FLAG_COMPLEX = 0x0001,
        FLAG_PUBLIC = 0x0002,
    }
}