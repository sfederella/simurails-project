﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuRails.Models;

namespace Tests.ModelsTests
{
    [TestClass]
    public class ReporingTest
    {
        Traza traza;
        
        [TestInitialize]
        public void Init()
        {
            ModelMock modelMock = new ModelMock();
            modelMock.MockResultados();
            traza = modelMock.Traza;
        }
        
        [TestMethod]
        public void Report()
        {
            // hacer algo con la traza
            Assert.IsTrue(true);
        }

    }
}
