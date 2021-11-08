﻿using CryptoExchange.Net.Converters;
using Kucoin.Net.Enums;
using Kucoin.Net.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kucoin.Net.Converters
{
    internal class BorrowStatusConverter : BaseConverter<BorrowStatus>
    {
        public BorrowStatusConverter() : this(true) { }
        public BorrowStatusConverter(bool quotes) : base(quotes) { }
        protected override List<KeyValuePair<BorrowStatus, string>> Mapping => new List<KeyValuePair<BorrowStatus, string>>
        {
            new KeyValuePair<BorrowStatus, string>(BorrowStatus.Processing, "Processing"),
            new KeyValuePair<BorrowStatus, string>(BorrowStatus.Done, "Done"),
        };
    }
}
