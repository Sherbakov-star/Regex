using Microsoft.VisualStudio.TestTools.UnitTesting;
using Regextext;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Regtext regtext = new Regtext();
        [TestMethod]
        public void TestMethod1()
        {
            string str = "codeblog";
            string s = regtext.regtext(str);
            Assert.AreEqual("true", s);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string str = "blog";
            string s = regtext.regtext(str);
            Assert.AreEqual("false", s);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string str = "ааа";
            string s = regtext.regreplace(str);
            Assert.AreEqual("ооо", s);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string str = "вов";
            string s = regtext.regreplace(str);
            Assert.AreEqual("вов", s);
        }
        [TestMethod]
        public void TestMethod5()
        {
            string str = "123абвг";
            string s = regtext.regciv(str);
            Assert.AreEqual("3", s);
        }
        [TestMethod]
        public void TestMethod6()
        {
            string str = "абвг";
            string s = regtext.regciv(str);
            Assert.AreEqual("0", s);
        }
        [TestMethod]
        public void TestMethod7()
        {
            string str = "Sherbakov";
            string s = regtext.regmail(str);
            Assert.AreEqual("false", s);
        }
        [TestMethod]
        public void TestMethod8()
        {
            string str = "sherbakov.dimon@gmail.com";
            string s = regtext.regmail(str);
            Assert.AreEqual("true", s);
        }
        [TestMethod]
        public void TestMethod9()
        {
            string str = "user=23";
            int s = regtext.reguserid(str);
            Assert.AreEqual(23, s);
        }
        [TestMethod]
        public void TestMethod10()
        {
            string str = "user";
            int s = regtext.reguserid(str);
            Assert.AreEqual(0, s);
        }
        [TestMethod]
        public void TestMethod11()
        {
            string str = "user user user";
            int s = regtext.regwcount(str);
            Assert.AreEqual(3, s);
        }
        [TestMethod]
        public void TestMethod12()
        {
            string str = "user";
            int s = regtext.regwcount(str);
            Assert.AreEqual(1, s);
        }
        [TestMethod]
        public void TestMethod13()
        {
            string str = "Dima,Sherbakov";
            string s = regtext.regname(str);
            Assert.AreEqual("Sherbakov,Dima", s);
        }
        [TestMethod]
        public void TestMethod14()
        {
            string str = "Sherbakov,Dima";
            string s = regtext.regname(str);
            Assert.AreEqual("Dima,Sherbakov", s);
        }
        [TestMethod]
        public void TestMethod15()
        {
            string str = "Sherbakov,Dima";
            string s = regtext.named_replace(str);
            Assert.AreEqual("Dima Sherbakov", s);
        }
        [TestMethod]
        public void TestMethod16()
        {
            string str = "Dima,Sherbakov";
            string s = regtext.named_replace(str);
            Assert.AreEqual("Sherbakov Dima", s);
        }
        [TestMethod]
        public void TestMethod17()
        {
            string str = "<br>Text</br>";
            string s = regtext.first_tag(str);
            Assert.AreEqual("br", s);
        }
        [TestMethod]
        public void TestMethod18()
        {
            string str = "<br>fghd";
            string s = regtext.first_tag(str);
            Assert.AreEqual("", s);
        }
        [TestMethod]
        public void TestMethod19()
        {
            string str = "-1 0 2 -2 3";
            int s = regtext.n_count(str);
            Assert.AreEqual(3, s);
        }
        [TestMethod]
        public void TestMethod20()
        {
            string str = "-1 -2 -4 3";
            int s = regtext.n_count(str);
            Assert.AreEqual(1, s);
        }
        [TestMethod]
        public void TestMethod21()
        {
            string str = "\"str\":10";
            int s = regtext.keys_count(str);
            Assert.AreEqual(1, s);
        }
        [TestMethod]
        public void TestMethod22()
        {
            string str = "str:10";
            int s = regtext.keys_count(str);
            Assert.AreEqual(0, s);
        }


    }
}
