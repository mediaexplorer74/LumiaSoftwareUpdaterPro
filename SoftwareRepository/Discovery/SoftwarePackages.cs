﻿// Decompiled with JetBrains decompiler
// Type: SoftwareRepository.Discovery.SoftwarePackages
// Assembly: SoftwareRepository, Version=2.1.5.19959, Culture=neutral, PublicKeyToken=null
// MVID: E5A69774-90A6-4202-AB96-618C2EE657B8
// Assembly location: C:\ProgramData\Microsoft\Lumia Software Updater Pro\Bin\SoftwareRepository.dll

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SoftwareRepository.Discovery
{
  [DataContract]
  public class SoftwarePackages
  {
    [DataMember(Name = "softwarePackages")]
    public List<SoftwarePackage> SoftwarePackageList { get; set; }
  }
}
