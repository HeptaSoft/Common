using System;
using System.Linq.Expressions;

namespace HeptaSoft.Common.Providers
{
    internal interface IRepositoryFilterExecutorProvider
    {
        LambdaExpression GetFilterExecutor(Type entityType);
    }
}