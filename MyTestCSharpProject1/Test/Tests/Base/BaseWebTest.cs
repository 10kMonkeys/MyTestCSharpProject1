using System;
using MyTestCSharpProject1.Src.PageObject.Pages.Base;
using MyTestCSharpProject1.Src.PageObject.Steps.StepsFactory;

namespace MyTestCSharpProject1.Test.Tests.Base
{
    public class BaseWebTest : BaseTest, IDisposable
    {
        public BaseWebTest()
        {
            InitTest();
        }

        private void InitTest()
        {
            user = new StepsFactory(new PageProvider());
        }

        public void Dispose()
        {
            user.pageProvider.Quit();
        }
    }
}
