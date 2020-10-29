using System;
using System.Collections.Generic;
using System.Text;

namespace SS.DataAccess.Enums
{
    public enum Status
    {
        InActive,
        Acticve,
        
    }
    public enum NewsStatus
    {
        Approved,
        Pedding
    }
    public enum OrderStatus
    {
        InProgress,
        Confirmed,
        Shipping,
        Success,
        Canceled
    }
    public enum TransactionStatus
    {
        Success,
        Failed
    }
}
