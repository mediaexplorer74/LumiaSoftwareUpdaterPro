﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.LsuPro.SecureFlashProtocolNotSupportedException
// Assembly: CommonClasses, Version=16.5.3001.0, Culture=neutral, PublicKeyToken=null
// MVID: 9C5F53C6-7909-4C9A-87E3-489AF522B35E
// Assembly location: C:\ProgramData\Microsoft\Lumia Software Updater Pro\Bin\CommonClasses.dll

using System;

namespace Microsoft.LsuPro
{
  [Serializable]
  public class SecureFlashProtocolNotSupportedException : FlashException
  {
    public SecureFlashProtocolNotSupportedException(uint errorCode)
      : base(errorCode)
    {
    }

    public SecureFlashProtocolNotSupportedException(uint errorCode, string message)
      : base(errorCode, message)
    {
    }

    public SecureFlashProtocolNotSupportedException(
      uint errorCode,
      string message,
      Exception innerException)
      : base(errorCode, message, innerException)
    {
    }
  }
}
