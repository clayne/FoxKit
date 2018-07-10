// Copyright (c) Rotorz Limited. All rights reserved.
// Licensed under the MIT license.

using Rotorz.Games.Collections;
using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace FoxKit.Utils.UI.StringMap
{
    public sealed class EditableOrderedDictionary_string_sbyte : EditableEntry<OrderedDictionary_string_sbyte>
    {
    }

    [Serializable, EditableEntry(typeof(EditableOrderedDictionary_string_sbyte))]
    public sealed class OrderedDictionary_string_sbyte : OrderedDictionary<string, sbyte>
    {
    }
}