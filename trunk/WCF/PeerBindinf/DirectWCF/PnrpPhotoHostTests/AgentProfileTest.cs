﻿using WCFDirectHost.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Controls;
using System.Drawing;
namespace WCFDirectHostTests
{
    
    
    /// <summary>
    ///This is a test class for AgentProfileTest and is intended
    ///to contain all AgentProfileTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AgentProfileTest {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext {
            get {
                return testContextInstance;
            }
            set {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for AgentProfile Constructor
        ///</summary>
        [TestMethod()]
        public void AgentProfileConstructorTest_With_Agent_Only() {
            string agent = "agent"; 
            AgentProfile target = new AgentProfile(agent);
            Assert.AreEqual<string>(agent, target.Agent);
        }

        [TestMethod()]
        public void AgentProfileConstructorTest_With_AgentAndImage() {
            string agent = "agent";
            Bitmap image = new Bitmap(100, 100);
            AgentProfile target = new AgentProfile(agent,image);
            Assert.AreEqual<Bitmap>(image, target.Image);
        }
    }
}
