﻿using System;

namespace Alpaca.Markets
{
    /// <summary>
    /// Encapsulates account update infromation from Alpaca streaming API.
    /// </summary>
    public interface IAccountUpdate
    {
        /// <summary>
        /// Gets unique account identifier.
        /// </summary>
        Guid AccountId { get; }

        /// <summary>
        /// Gets updated account status.
        /// </summary>
        AccountStatus Status { get; }

        /// <summary>
        /// Gets main account currency.
        /// </summary>
        String Currency { get; }

        /// <summary>
        /// Gets amount of money avaliable for trading.
        /// </summary>
        Decimal TradableCash { get; }

        /// <summary>
        /// Gets amount of money avaliable for withdraw.
        /// </summary>
        Decimal WithdrawableCash { get; }

        /// <summary>
        /// Gets timestamp of account creation event.
        /// </summary>
        DateTime CreatedAt { get; }

        /// <summary>
        /// Gets timestamp of last account update event.
        /// </summary>
        DateTime UpdatedAt { get; }

        /// <summary>
        /// Gets timestamp of account deletion event.
        /// </summary>
        DateTime? DeletedAt { get; }
    }
}