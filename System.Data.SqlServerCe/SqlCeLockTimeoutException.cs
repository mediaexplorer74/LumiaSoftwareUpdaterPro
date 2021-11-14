﻿// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.SqlCeLockTimeoutException
// Assembly: System.Data.SqlServerCe, Version=4.0.0.1, Culture=neutral, PublicKeyToken=89845dcd8080cc91
// MVID: 7FFB8205-147A-42A6-BE59-8BAD2AC4B376
// Assembly location: C:\ProgramData\Microsoft\Lumia Software Updater Pro\Bin\System.Data.SqlServerCe.dll

using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace System.Data.SqlServerCe
{
  [Serializable]
  public class SqlCeLockTimeoutException : SqlCeException
  {
    static SqlCeLockTimeoutException() => KillBitHelper.ThrowIfKillBitIsSet();

    internal SqlCeLockTimeoutException(SqlCeErrorCollection errors)
      : base(errors)
    {
    }

    protected SqlCeLockTimeoutException(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
    }

    [SecurityCritical]
    [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      if (info == null)
        throw new ArgumentNullException(nameof (info));
      base.GetObjectData(info, context);
    }
  }
}
