using System;
using System.Runtime.InteropServices;

[Serializable]
[StructLayout(LayoutKind.Explicit)]
public readonly struct ValueUnion
{
    [FieldOffset(0)] public readonly ulong uint64_0;

    [FieldOffset(0)] public readonly long int64_0;

    [FieldOffset(0)] public readonly double float64_0;

    [FieldOffset(0)] public readonly uint uint32_0;
    [FieldOffset(4)] public readonly uint uint32_1;

    [FieldOffset(0)] public readonly int int32_0;
    [FieldOffset(4)] public readonly int int32_1;

    [FieldOffset(0)] public readonly float float32_0;
    [FieldOffset(4)] public readonly float float32_1;

    [FieldOffset(0)] public readonly ushort uint16_0;
    [FieldOffset(2)] public readonly ushort uint16_1;
    [FieldOffset(4)] public readonly ushort uint16_2;
    [FieldOffset(6)] public readonly ushort uint16_3;

    [FieldOffset(0)] public readonly short int16_0;
    [FieldOffset(2)] public readonly short int16_1;
    [FieldOffset(4)] public readonly short int16_2;
    [FieldOffset(6)] public readonly short int16_3;

    [FieldOffset(0)] public readonly byte uint8_0;
    [FieldOffset(1)] public readonly byte uint8_1;
    [FieldOffset(2)] public readonly byte uint8_2;
    [FieldOffset(3)] public readonly byte uint8_3;
    [FieldOffset(4)] public readonly byte uint8_4;
    [FieldOffset(5)] public readonly byte uint8_5;
    [FieldOffset(6)] public readonly byte uint8_6;
    [FieldOffset(7)] public readonly byte uint8_7;

    [FieldOffset(0)] public readonly sbyte int8_0;
    [FieldOffset(1)] public readonly sbyte int8_1;
    [FieldOffset(2)] public readonly sbyte int8_2;
    [FieldOffset(3)] public readonly sbyte int8_3;
    [FieldOffset(4)] public readonly sbyte int8_4;
    [FieldOffset(5)] public readonly sbyte int8_5;
    [FieldOffset(6)] public readonly sbyte int8_6;
    [FieldOffset(7)] public readonly sbyte int8_7;

    public ValueUnion(ulong v)
    {
        // uint64_0 = 0;
        int64_0    = 0;
        float64_0  = 0;
        uint32_0   = 0;
        uint32_1   = 0;
        int32_0    = 0;
        int32_1    = 0;
        float32_0  = 0;
        float32_1  = 0;
        uint16_0   = 0;
        uint16_1   = 0;
        uint16_2   = 0;
        uint16_3   = 0;
        int16_0    = 0;
        int16_1    = 0;
        int16_2    = 0;
        int16_3    = 0;
        uint8_0    = 0;
        uint8_1    = 0;
        uint8_2    = 0;
        uint8_3    = 0;
        uint8_4    = 0;
        uint8_5    = 0;
        uint8_6    = 0;
        uint8_7    = 0;
        int8_0     = 0;
        int8_1     = 0;
        int8_2     = 0;
        int8_3     = 0;
        int8_4     = 0;
        int8_5     = 0;
        int8_6     = 0;
        int8_7     = 0;

        uint64_0 = v;
    }

    public ValueUnion(long v0) : this(0UL) => int64_0 = v0;

    public ValueUnion(double v0) : this(0UL) => float64_0 = v0;

    public ValueUnion(uint v0) : this(0UL) => uint32_0 = v0;

    public ValueUnion(uint v0, uint v1) : this(0UL)
    {
        uint32_0 = v0;
        uint32_1 = v1;
    }

    public ValueUnion(int v0) : this(0UL) => int32_0 = v0;

    public ValueUnion(int v0, int v1) : this(0UL)
    {
        int32_0 = v0;
        int32_1 = v1;
    }

    public ValueUnion(float v0) : this(0UL) => float32_0 = v0;

    public ValueUnion(float v0, float v1) : this(0UL)
    {
        float32_0 = v0;
        float32_1 = v1;
    }

    public ValueUnion(ushort v0) : this(0UL) => uint16_0 = v0;

    public ValueUnion(ushort v0, ushort v1) : this(0UL)
    {
        uint16_0 = v0;
        uint16_1 = v1;
    }

    public ValueUnion(ushort v0, ushort v1, ushort v2) : this(0UL)
    {
        uint16_0 = v0;
        uint16_1 = v1;
        uint16_2 = v2;
    }

    public ValueUnion(ushort v0, ushort v1, ushort v2, ushort v3) : this(0UL)
    {
        uint16_0 = v0;
        uint16_1 = v1;
        uint16_2 = v2;
        uint16_3 = v3;
    }

    public ValueUnion(short v0) : this(0UL) => int16_0 = v0;

    public ValueUnion(short v0, short v1) : this(0UL)
    {
        int16_0 = v0;
        int16_1 = v1;
    }

    public ValueUnion(short v0, short v1, short v2) : this(0UL)
    {
        int16_0 = v0;
        int16_1 = v1;
        int16_2 = v2;
    }

    public ValueUnion(short v0, short v1, short v2, short v3) : this(0UL)
    {
        int16_0 = v0;
        int16_1 = v1;
        int16_2 = v2;
        int16_3 = v3;
    }

    public ValueUnion(byte v0) : this(0UL) => uint8_0 = v0;

    public ValueUnion(byte v0, byte v1) : this(0UL)
    {
        uint8_0 = v0;
        uint8_1 = v1;
    }

    public ValueUnion(byte v0, byte v1, byte v2) : this(0UL)
    {
        uint8_0 = v0;
        uint8_1 = v1;
        uint8_2 = v2;
    }

    public ValueUnion(byte v0, byte v1, byte v2, byte v3) : this(0UL)
    {
        uint8_0 = v0;
        uint8_1 = v1;
        uint8_2 = v2;
        uint8_3 = v3;
    }

    public ValueUnion(byte v0, byte v1, byte v2, byte v3, byte v4) : this(0UL)
    {
        uint8_0 = v0;
        uint8_1 = v1;
        uint8_2 = v2;
        uint8_3 = v3;
        uint8_4 = v4;
    }

    public ValueUnion(byte v0, byte v1, byte v2, byte v3, byte v4, byte v5) : this(0UL)
    {
        uint8_0 = v0;
        uint8_1 = v1;
        uint8_2 = v2;
        uint8_3 = v3;
        uint8_4 = v4;
        uint8_5 = v5;
    }

    public ValueUnion(byte v0, byte v1, byte v2, byte v3, byte v4, byte v5, byte v6) : this(0UL)
    {
        uint8_0 = v0;
        uint8_1 = v1;
        uint8_2 = v2;
        uint8_3 = v3;
        uint8_4 = v4;
        uint8_5 = v5;
        uint8_6 = v6;
    }

    public ValueUnion(byte v0, byte v1, byte v2, byte v3, byte v4, byte v5, byte v6, byte v7) : this(0UL)
    {
        uint8_0 = v0;
        uint8_1 = v1;
        uint8_2 = v2;
        uint8_3 = v3;
        uint8_4 = v4;
        uint8_5 = v5;
        uint8_6 = v6;
        uint8_7 = v7;
    }

    public ValueUnion(sbyte v0) : this(0UL) => int8_0 = v0;

    public ValueUnion(sbyte v0, sbyte v1) : this(0UL)
    {
        int8_0 = v0;
        int8_1 = v1;
    }

    public ValueUnion(sbyte v0, sbyte v1, sbyte v2) : this(0UL)
    {
        int8_0 = v0;
        int8_1 = v1;
        int8_2 = v2;
    }

    public ValueUnion(sbyte v0, sbyte v1, sbyte v2, sbyte v3) : this(0UL)
    {
        int8_0 = v0;
        int8_1 = v1;
        int8_2 = v2;
        int8_3 = v3;
    }

    public ValueUnion(sbyte v0, sbyte v1, sbyte v2, sbyte v3, sbyte v4) : this(0UL)
    {
        int8_0 = v0;
        int8_1 = v1;
        int8_2 = v2;
        int8_3 = v3;
        int8_4 = v4;
    }

    public ValueUnion(sbyte v0, sbyte v1, sbyte v2, sbyte v3, sbyte v4, sbyte v5) : this(0UL)
    {
        int8_0 = v0;
        int8_1 = v1;
        int8_2 = v2;
        int8_3 = v3;
        int8_4 = v4;
        int8_5 = v5;
    }

    public ValueUnion(sbyte v0, sbyte v1, sbyte v2, sbyte v3, sbyte v4, sbyte v5, sbyte v6) : this(0UL)
    {
        int8_0 = v0;
        int8_1 = v1;
        int8_2 = v2;
        int8_3 = v3;
        int8_4 = v4;
        int8_5 = v5;
        int8_6 = v6;
    }

    public ValueUnion(sbyte v0, sbyte v1, sbyte v2, sbyte v3, sbyte v4, sbyte v5, sbyte v6, sbyte v7) : this(0UL)
    {
        int8_0 = v0;
        int8_1 = v1;
        int8_2 = v2;
        int8_3 = v3;
        int8_4 = v4;
        int8_5 = v5;
        int8_6 = v6;
        int8_7 = v7;
    }

    public static implicit operator ValueUnion(ulong v) => new(v);
    public static implicit operator ulong(ValueUnion v) => v.uint64_0;

    public static implicit operator ValueUnion(long v) => new(v);
    public static implicit operator long(ValueUnion v) => v.int64_0;

    public static implicit operator ValueUnion(double v) => new(v);
    public static implicit operator double(ValueUnion v) => v.float64_0;

    public static implicit operator ValueUnion(uint v) => new(v);
    public static implicit operator uint(ValueUnion v) => v.uint32_0;

    public static implicit operator ValueUnion(int v) => new(v);
    public static implicit operator int(ValueUnion v) => v.int32_0;

    public static implicit operator ValueUnion(float v) => new(v);
    public static implicit operator float(ValueUnion v) => v.float32_0;

    public static implicit operator ValueUnion(ushort v) => new(v);
    public static implicit operator ushort(ValueUnion v) => v.uint16_0;

    public static implicit operator ValueUnion(short v) => new(v);
    public static implicit operator short(ValueUnion v) => v.int16_0;

    public static implicit operator ValueUnion(byte v) => new(v);
    public static implicit operator byte(ValueUnion v) => v.uint8_0;

    public static implicit operator ValueUnion(sbyte v) => new(v);
    public static implicit operator sbyte(ValueUnion v) => v.int8_0;
}
