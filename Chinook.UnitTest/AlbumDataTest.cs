using System;
using System.Collections.Generic;
using Chinook.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chinook.UnitTest
{
    [TestClass]
    public class AlbumDataTest
    {
        [TestMethod]
        public void GetAll()
        {
            List<Album> albums = DataRepoistory.Album.GetAll();

            Assert.IsTrue(albums.Count > 200);
        }
    }
}
