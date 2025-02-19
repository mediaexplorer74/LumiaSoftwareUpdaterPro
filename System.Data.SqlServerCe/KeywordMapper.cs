﻿// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.KeywordMapper
// Assembly: System.Data.SqlServerCe, Version=4.0.0.1, Culture=neutral, PublicKeyToken=89845dcd8080cc91
// MVID: 7FFB8205-147A-42A6-BE59-8BAD2AC4B376
// Assembly location: C:\ProgramData\Microsoft\Lumia Software Updater Pro\Bin\System.Data.SqlServerCe.dll

using System.Collections;
using System.Collections.Generic;

namespace System.Data.SqlServerCe
{
  internal sealed class KeywordMapper
  {
    private const int _connectionOptions = 40;
    private static readonly Hashtable _keywordSynonymsMapping;
    private static readonly string[] _validKeywords;
    private static readonly Dictionary<string, Keywords> _keywords;
    private static readonly Dictionary<string, string> _oledbAdoDotNetKeywordsMapping;

    static KeywordMapper()
    {
      string[] strArray = new string[18]
      {
        "Autoshrink Threshold",
        "Case Sensitive",
        "Data Source",
        "Default Lock Escalation",
        "Default Lock Timeout",
        null,
        "Encryption Mode",
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null
      };
      strArray[5] = "Encrypt Database";
      strArray[7] = "Enlist";
      strArray[8] = "File Access Retry Timeout";
      strArray[9] = "Mode";
      strArray[10] = "Flush Interval";
      strArray[11] = "Locale Identifier";
      strArray[12] = "Max Buffer Size";
      strArray[13] = "Max Database Size";
      strArray[14] = "Password";
      strArray[15] = "Persist Security Info";
      strArray[16] = "Temp File Max Size";
      strArray[17] = "Temp File Directory";
      KeywordMapper._validKeywords = strArray;
      KeywordMapper._keywordSynonymsMapping = new Hashtable(40)
      {
        {
          (object) "Autoshrink Threshold",
          (object) "Autoshrink Threshold"
        },
        {
          (object) "ssce:autoshrink threshold",
          (object) "Autoshrink Threshold"
        },
        {
          (object) "Case Sensitive",
          (object) "Case Sensitive"
        },
        {
          (object) "ssce:case sensitive",
          (object) "Case Sensitive"
        },
        {
          (object) "casesensitive",
          (object) "Case Sensitive"
        },
        {
          (object) "Data Source",
          (object) "Data Source"
        },
        {
          (object) "datasource",
          (object) "Data Source"
        },
        {
          (object) "Default Lock Escalation",
          (object) "Default Lock Escalation"
        },
        {
          (object) "ssce:default lock escalation",
          (object) "Default Lock Escalation"
        },
        {
          (object) "Default Lock Timeout",
          (object) "Default Lock Timeout"
        },
        {
          (object) "ssce:default lock timeout",
          (object) "Default Lock Timeout"
        },
        {
          (object) "Encrypt Database",
          (object) "Encrypt Database"
        },
        {
          (object) "ssce:encrypt database",
          (object) "Encrypt Database"
        },
        {
          (object) "encrypt",
          (object) "Encrypt Database"
        },
        {
          (object) "Encryption Mode",
          (object) "Encryption Mode"
        },
        {
          (object) "ssce:encryption mode",
          (object) "Encryption Mode"
        },
        {
          (object) "Enlist",
          (object) "Enlist"
        },
        {
          (object) "ssce:enlist",
          (object) "Enlist"
        },
        {
          (object) "File Access Retry Timeout",
          (object) "File Access Retry Timeout"
        },
        {
          (object) "Flush Interval",
          (object) "Flush Interval"
        },
        {
          (object) "ssce:flush interval",
          (object) "Flush Interval"
        },
        {
          (object) "Locale Identifier",
          (object) "Locale Identifier"
        },
        {
          (object) "initial lcid",
          (object) "Locale Identifier"
        },
        {
          (object) "lcid",
          (object) "Locale Identifier"
        },
        {
          (object) "Max Buffer Size",
          (object) "Max Buffer Size"
        },
        {
          (object) "ssce:max buffer size",
          (object) "Max Buffer Size"
        },
        {
          (object) "Max Database Size",
          (object) "Max Database Size"
        },
        {
          (object) "ssce:max database size",
          (object) "Max Database Size"
        },
        {
          (object) "Mode",
          (object) "Mode"
        },
        {
          (object) "ssce:mode",
          (object) "Mode"
        },
        {
          (object) "file mode",
          (object) "Mode"
        },
        {
          (object) "Password",
          (object) "Password"
        },
        {
          (object) "pwd",
          (object) "Password"
        },
        {
          (object) "database password",
          (object) "Password"
        },
        {
          (object) "ssce:database password",
          (object) "Password"
        },
        {
          (object) "Persist Security Info",
          (object) "Persist Security Info"
        },
        {
          (object) "Temp File Max Size",
          (object) "Temp File Max Size"
        },
        {
          (object) "ssce:temp file max size",
          (object) "Temp File Max Size"
        },
        {
          (object) "Temp File Directory",
          (object) "Temp File Directory"
        },
        {
          (object) "ssce:temp file directory",
          (object) "Temp File Directory"
        },
        {
          (object) "temp path",
          (object) "Temp File Directory"
        }
      };
      KeywordMapper._oledbAdoDotNetKeywordsMapping = new Dictionary<string, string>(25, (IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase)
      {
        {
          "Autoshrink Threshold",
          "ssce:autoshrink threshold"
        },
        {
          "Case Sensitive",
          "ssce:case sensitive"
        },
        {
          "casesensitive",
          "ssce:case sensitive"
        },
        {
          "datasource",
          "Data Source"
        },
        {
          "Default Lock Escalation",
          "ssce:default lock escalation"
        },
        {
          "Default Lock Timeout",
          "ssce:default lock timeout"
        },
        {
          "Encrypt Database",
          "ssce:encrypt database"
        },
        {
          "encrypt",
          "ssce:encrypt database"
        },
        {
          "Encryption Mode",
          "ssce:encryption mode"
        },
        {
          "Flush Interval",
          "ssce:flush interval"
        },
        {
          "initial lcid",
          "Locale Identifier"
        },
        {
          "lcid",
          "Locale Identifier"
        },
        {
          "Max Buffer Size",
          "ssce:max buffer size"
        },
        {
          "Max Database Size",
          "ssce:max database size"
        },
        {
          "Mode",
          "ssce:mode"
        },
        {
          "file mode",
          "ssce:mode"
        },
        {
          "pwd",
          "ssce:database password"
        },
        {
          "database password",
          "ssce:database password"
        },
        {
          "Password",
          "ssce:database password"
        },
        {
          "Temp File Max Size",
          "ssce:temp file max size"
        },
        {
          "Temp File Directory",
          "ssce:temp file directory"
        },
        {
          "temp path",
          "ssce:temp file directory"
        }
      };
      KeywordMapper._keywords = new Dictionary<string, Keywords>(50, (IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase)
      {
        {
          "Autoshrink Threshold",
          Keywords.AutoshrinkThreshold
        },
        {
          "ssce:autoshrink threshold",
          Keywords.AutoshrinkThreshold
        },
        {
          "Case Sensitive",
          Keywords.CaseSensitive
        },
        {
          "ssce:case sensitive",
          Keywords.CaseSensitive
        },
        {
          "casesensitive",
          Keywords.CaseSensitive
        },
        {
          "Data Source",
          Keywords.DataSource
        },
        {
          "datasource",
          Keywords.DataSource
        },
        {
          "Default Lock Escalation",
          Keywords.DefaultLockEscalation
        },
        {
          "ssce:default lock escalation",
          Keywords.DefaultLockEscalation
        },
        {
          "Default Lock Timeout",
          Keywords.DefaultLockTimeout
        },
        {
          "ssce:default lock timeout",
          Keywords.DefaultLockTimeout
        },
        {
          "Encrypt Database",
          Keywords.Encrypt
        },
        {
          "ssce:encrypt database",
          Keywords.Encrypt
        },
        {
          "encrypt",
          Keywords.Encrypt
        },
        {
          "Encryption Mode",
          Keywords.EncryptionMode
        },
        {
          "ssce:encryption mode",
          Keywords.EncryptionMode
        },
        {
          "Enlist",
          Keywords.Enlist
        },
        {
          "ssce:enlist",
          Keywords.Enlist
        },
        {
          "File Access Retry Timeout",
          Keywords.FileAccessRetryTimeout
        },
        {
          "Flush Interval",
          Keywords.FlushInterval
        },
        {
          "ssce:flush interval",
          Keywords.FlushInterval
        },
        {
          "Locale Identifier",
          Keywords.InitialLcid
        },
        {
          "initial lcid",
          Keywords.InitialLcid
        },
        {
          "lcid",
          Keywords.InitialLcid
        },
        {
          "Max Buffer Size",
          Keywords.MaxBufferSize
        },
        {
          "ssce:max buffer size",
          Keywords.MaxBufferSize
        },
        {
          "Max Database Size",
          Keywords.MaxDatabaseSize
        },
        {
          "ssce:max database size",
          Keywords.MaxDatabaseSize
        },
        {
          "Mode",
          Keywords.FileMode
        },
        {
          "ssce:mode",
          Keywords.FileMode
        },
        {
          "file mode",
          Keywords.FileMode
        },
        {
          "Password",
          Keywords.Password
        },
        {
          "pwd",
          Keywords.Password
        },
        {
          "database password",
          Keywords.Password
        },
        {
          "ssce:database password",
          Keywords.Password
        },
        {
          "Persist Security Info",
          Keywords.PersistSecurityInfo
        },
        {
          "Temp File Max Size",
          Keywords.TempFileMaxSize
        },
        {
          "ssce:temp file max size",
          Keywords.TempFileMaxSize
        },
        {
          "Temp File Directory",
          Keywords.TempFilePath
        },
        {
          "ssce:temp file directory",
          Keywords.TempFilePath
        },
        {
          "temp path",
          Keywords.TempFilePath
        }
      };
    }

    public static Hashtable KeywordSynonymsMapping => KeywordMapper._keywordSynonymsMapping;

    public static Dictionary<string, string> OledbAdoDotNetKeywordsMapping => KeywordMapper._oledbAdoDotNetKeywordsMapping;

    public static string[] ValidKeywords => KeywordMapper._validKeywords;

    public static Dictionary<string, Keywords> KeywordsDictionary => KeywordMapper._keywords;
  }
}
