﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.LsuPro.OemFlashCompletedEventArgs
// Assembly: Wp8OemFlasher, Version=16.5.3001.0, Culture=neutral, PublicKeyToken=null
// MVID: DD0F564F-0EF5-4D78-8BB5-4C7A3BFE4321
// Assembly location: C:\ProgramData\Microsoft\Lumia Software Updater Pro\Bin\Wp8OemFlasher.dll

using System;

namespace Microsoft.LsuPro
{
  public class OemFlashCompletedEventArgs : EventArgs
  {
    public OemFlashCompletedEventArgs(OemFlasherResult result) => this.Result = result;

    public OemFlasherResult Result { get; private set; }
  }
}
