using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using SystemInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PredicateBuilder;

namespace MRManager_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            List<string> typeChain = new List<string> { "Changes", "Count" };

            // A real live predicate built up from string values. Set a breakpoint and examine the predicate.DebugView
            Type type = typeof (IEntityViewWithChangesFound<IUserSignIn>);
            Expression<Func<IEntityViewWithChangesFound<IUserSignIn>, bool>> predicate = (Expression<Func<IEntityViewWithChangesFound<IUserSignIn>, bool>>) typeof(Instance)
                .GetMethod("Build", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
                .MakeGenericMethod(type)
                .Invoke(null, new object[] { typeChain, OperatorType.Equal, "2", null });
           // Expression<Func<IEntityViewWithChangesFound<IUserSignIn>, bool>> predicate = PredicateBuilder.Instance.Build(type,typeChain, OperatorType.Equal, "2", null);
        }
    }
}
