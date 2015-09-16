﻿namespace JSIL.Proxies
{
    using System;
    using System.Reflection;
    using JSIL.Meta;
    using JSIL.Proxy;

    [JSProxy(
        new[]
        {
            typeof (object), typeof (ValueType),
            typeof (Type),
            typeof (MemberInfo), typeof (MethodBase),
            typeof (MethodInfo), typeof (FieldInfo),
            typeof (ConstructorInfo), typeof (PropertyInfo), typeof (EventInfo),
            typeof (Array), typeof (Delegate), typeof (MulticastDelegate),
            typeof (Byte), typeof (SByte),
            typeof (UInt16), typeof (Int16),
            typeof (UInt32), typeof (Int32),
            typeof (UInt64), typeof (Int64),
            typeof (Single), typeof (Double),
            typeof (Boolean), typeof (Char),
            typeof (Assembly),
            typeof (Attribute),
            typeof (Decimal),
            typeof (IntPtr), typeof (UIntPtr)
        },
        inheritable: false)]
    [JSSuppressTypeDeclaration]
    public class SuppressDeclarationByType
    {
    }

    [JSProxy(
        new[]
        {
            "System.Reflection.TypeInfo", "System.RuntimeType",
            "System.Reflection.RuntimeAssembly"
        },
        inheritable: false)]
    [JSSuppressTypeDeclaration]
    public class SuppressDeclarationByString
    {
    }
}
