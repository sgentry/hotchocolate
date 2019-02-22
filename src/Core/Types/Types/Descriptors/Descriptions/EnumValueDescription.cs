﻿using HotChocolate.Language;

namespace HotChocolate.Types.Descriptors
{
    public class EnumValueDescription
        : TypeDescriptionBase<EnumValueDefinitionNode>
        , ICanBeDeprecated
    {
        public string DeprecationReason { get; set; }

        public bool IsDeprecated => !string.IsNullOrEmpty(DeprecationReason);

        public object Value { get; set; }
    }
}