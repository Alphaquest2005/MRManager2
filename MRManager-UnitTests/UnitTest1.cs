using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using SystemInterfaces;
using BootStrapper;
using GenSoft.Entities;
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

            var p = new Predicate { Type = "IEntityViewWithChangesFound<IUserSignIn>", Path = "Changes", Operation = "Count", Value = "2" };
            var type = BootStrapper.BootStrapper.Container.GetExportedTypes(p.Type).FirstOrDefault();

            var rpredicate =
                typeof(Utilities.Predicate).GetMethod("GetTypePredicate")
                    .MakeGenericMethod(type)
                    .Invoke(null, new object[] { p });

            var predicate = Utilities.Predicate.GetTypePredicate<IEntityViewWithChangesFound<IUserSignIn>>(p);
        }
    }
}
