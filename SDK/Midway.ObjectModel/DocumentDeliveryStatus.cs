﻿using System.Runtime.Serialization;

namespace Midway.ObjectModel
{
    /// <summary>
    /// Статус получения документа.
    /// </summary>
    [DataContract]
    public enum DocumentDeliveryStatus
    {
        /// <summary>
        /// Документ получен сервером. 
        /// Статус означает, что сервис принял документ, но еще не передал его получателю (или другому оператору).
        /// </summary>
        [EnumMember]
        RecievedByService = 0x00,

        /// <summary>
        /// Документ отправлен получателю. 
        /// Если получатель локальный, то статус означает, что документ находится в папке входящих получателя.
        /// Если получатель зарегистрирован у другого оператора, то статус означает, что сервис передал документ оператору по протоколу роуминга,
        /// в этом случае за доставку документа уже отвечает оператор получателя.
        /// </summary>
        [EnumMember]
        SentToRecipient = 0x01,

        /// <summary>
        /// Документ доставлен получателю. 
        /// Статус означает, что получено подтверждение от получателя о доставке документа.
        /// </summary>
        [EnumMember]
        DeliveredToRecipient = 0x2,

        /// <summary>
        /// Документ не доставлен получателю. 
        /// Статус означает, что отправителем получена квитанция об ошибке от сервиса.
        /// </summary>
        [EnumMember]
        NotDeliveredToRecipient = 0x3,
    }
}
