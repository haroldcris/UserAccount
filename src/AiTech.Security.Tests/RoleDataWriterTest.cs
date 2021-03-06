// <copyright file="RoleDataWriterTest.cs">Copyright ©  2017</copyright>
using System;
using AiTech.Security;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AiTech.Security.Tests
{
    /// <summary>This class contains parameterized unit tests for RoleDataWriter</summary>
    [PexClass(typeof(RoleDataWriter))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class RoleDataWriterTest
    {
        /// <summary>Test stub for SaveChanges()</summary>
        [PexMethod]
        public bool SaveChangesTest([PexAssumeUnderTest]RoleDataWriter target)
        {
            bool result = target.SaveChanges();
            return result;
            // TODO: add assertions to method RoleDataWriterTest.SaveChangesTest(RoleDataWriter)
        }
    }
}
