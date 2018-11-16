﻿using NTwain.Data;
using NTwain.Internals;

namespace NTwain.Triplets.Control
{
    sealed class Callback2 : BaseTriplet
    {
        internal Callback2(TwainSession session) : base(session) { }

        public ReturnCode RegisterCallback(ref TW_CALLBACK2 callback)
        {
            return NativeMethods.DsmWin32(Session.Config.AppWin32, Session.CurrentSource.Identity,
                DataGroups.Control, DataArgumentType.Callback2, Message.RegisterCallback, ref callback);
        }
    }
}