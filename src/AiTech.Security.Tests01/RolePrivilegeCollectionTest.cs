// <copyright file="RolePrivilegeCollectionTest.cs">Copyright ©  2017</copyright>
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AiTech.Security.Tests
{
    /// <summary>This class contains parameterized unit tests for RolePrivilegeCollection</summary>
    [PexClass(typeof(RolePrivilegeCollection))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class RolePrivilegeCollectionTest
    {
        /// <summary>Test stub for LoadItemsFromDb()</summary>
        [PexMethod]
        public void LoadItemsFromDbTest([PexAssumeUnderTest]RolePrivilegeCollection target)
        {
            target.LoadItemsFromDb();
            // TODO: add assertions to method RolePrivilegeCollectionTest.LoadItemsFromDbTest(RolePrivilegeCollection)

            Assert.AreEqual(1, 2);
        }
    }
}
