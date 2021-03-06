﻿using System.ComponentModel;
using System.Runtime.Serialization;

namespace Midway.ObjectModel
{
    /// <summary>
    /// Версия формата титула перевозчика транспортной накладной.
    /// </summary>
    [DataContract]
    public enum TransportWaybillCarrierTitleFormatVersion
    {
        /// <summary>
        /// Не указана.
        /// </summary>
        [EnumMember]
        [Description("Не указана")]
        None = 0,

        /// <summary>
        /// Версия 1.00.
        /// </summary>
        [EnumMember]
        [Description("Версия 1.00")]
        V100 = 1,
    }
}