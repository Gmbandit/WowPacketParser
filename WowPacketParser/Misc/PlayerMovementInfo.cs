namespace WowPacketParser.Misc
{
    public enum MovementStatusElements
    {
        MSEHasGuidByte0,
        MSEHasGuidByte1,
        MSEHasGuidByte2,
        MSEHasGuidByte3,
        MSEHasGuidByte4,
        MSEHasGuidByte5,
        MSEHasGuidByte6,
        MSEHasGuidByte7,
        MSEHasMovementFlags,
        MSEHasMovementFlags2,
        MSEHasTimestamp,
        MSEHasOrientation,
        MSEHasUnkTime,
        MSECounterCount,
        MSEHasTransportData,
        MSEHasTransportGuidByte0,
        MSEHasTransportGuidByte1,
        MSEHasTransportGuidByte2,
        MSEHasTransportGuidByte3,
        MSEHasTransportGuidByte4,
        MSEHasTransportGuidByte5,
        MSEHasTransportGuidByte6,
        MSEHasTransportGuidByte7,
        MSEHasTransportTime2,
        MSEHasTransportTime3,
        MSEHasPitch,
        MSEHasFallData,
        MSEHasFallDirection,
        MSEHasSplineElevation,
        MSEHasSpline,

        MSEGuidByte0,
        MSEGuidByte1,
        MSEGuidByte2,
        MSEGuidByte3,
        MSEGuidByte4,
        MSEGuidByte5,
        MSEGuidByte6,
        MSEGuidByte7,
        MSEMovementFlags,
        MSEMovementFlags2,
        MSETimestamp,
        MSEPositionX,
        MSEPositionY,
        MSEPositionZ,
        MSEOrientation,
        MSETransportGuidByte0,
        MSETransportGuidByte1,
        MSETransportGuidByte2,
        MSETransportGuidByte3,
        MSETransportGuidByte4,
        MSETransportGuidByte5,
        MSETransportGuidByte6,
        MSETransportGuidByte7,
        MSETransportPositionX,
        MSETransportPositionY,
        MSETransportPositionZ,
        MSETransportOrientation,
        MSETransportSeat,
        MSETransportTime,
        MSETransportTime2,
        MSETransportTime3,
        MSEFallTime,
        MSEFallVerticalSpeed,
        MSEFallCosAngle,
        MSEFallSinAngle,
        MSEFallHorizontalSpeed,
        MSEUnkTime,
        MSEPitch,
        MSESplineElevation,

        MSECount,
        MSECounter,

        MSEHasUnkBitA,
        MSEUnkBitABit,
        MSEUnkBitAByte,

        // Special
        MSEZeroBit,         // writes bit value 1 or skips read bit
        MSEOneBit,          // writes bit value 0 or skips read bit
        MSEEnd,             // marks end of parsing
    }
}
