using System;
using System.Linq.Expressions;

namespace HeptaSoft.Common.Providers
{
    internal interface IRepositoryFilterExecutorRegistrator
    {
        void RegisterFilterExecutor(Type entityType, LambdaExpression executeFilterExpression);
    }
}