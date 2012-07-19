﻿using Rock.CMS;
using Xunit;

namespace Rock.Tests.CMS
{
    public class BlockTests
    {
        public class TheExportObjectMethod
        {
            [Fact]
            public void ShouldCopyDTO()
            {
                var block = new Block() {Name = "some block"};
                dynamic result = block.ExportObject();
                Assert.Equal( result.Name, block.Name );
            }
        }

        public class TheExportJsonMethod
        {
            [Fact]
            public void ShouldNotBeEmpty()
            {
                var block = new Block() { Name = "some block" };
                var result = block.ExportJson();
                Assert.NotEmpty( result );
            }
        }
    }
}
