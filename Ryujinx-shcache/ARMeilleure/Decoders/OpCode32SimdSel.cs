﻿namespace ARMeilleure.Decoders
{
    class OpCode32SimdSel : OpCode32SimdRegS
    {
        public OpCode32SimdSelMode Cc { get; private set; }

        public OpCode32SimdSel(InstDescriptor inst, ulong address, int opCode) : base(inst, address, opCode)
        {
            Cc = (OpCode32SimdSelMode)((opCode >> 20) & 3);
        }
    }

    enum OpCode32SimdSelMode : int
    {
        Eq = 0,
        Vs,
        Ge,
        Gt
    }
}
