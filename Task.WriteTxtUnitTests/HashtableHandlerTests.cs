using System;
using CloudCore;
using NUnit.Framework;
using NSubstitute;
using System.Collections;
using Task.WriteTxt;
namespace Task.WriteTxtUnitTests
{
    [TestFixture]
    public class HashtableHandlerTests
    {
        [TestCase("ttt","123",TestName ="Sample01")]
        public void WritToHashtable_KeyHaveExists_CreateErrorKey(string key,string value)
        {
            // Arrange
            var task = Substitute.For<ITask>();
            task.hashtable.Returns(new Hashtable());
            task.hashtable.Add(key, value);
            HashtableHandler _HashtableHandler = new HashtableHandler(task);
            // Act
            _HashtableHandler.WritToHashtable(key, value);

            // Assert 驗證是否有執行HashtableKeyHaveExists,
            task.Received().HashtableKeyHaveExists(key);

            // 錯誤寫法,因為並沒有真正的new Task,這邊是new ITask
            // 如果要使用這寫法驗證需要修改測試寫法
            //StringAssert.Contains("have exists", task.hashtable["Error"].ToString());
        }
        [TestCase("ttt", "123", TestName = "Sample02")]
        public void WritToHashtable_KeyIsNotExists_ReturnValue(string key, string value)
        {
            // Arrange
            var task = Substitute.For<ITask>();
            task.hashtable.Returns(new Hashtable());
            HashtableHandler _HashtableHandler = new HashtableHandler(task);
            // Act
            _HashtableHandler.WritToHashtable(key, value);
            // Assert
            Assert.AreEqual(value, task.hashtable[key].ToString());
        }
    }
}
