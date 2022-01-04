using FluentAssertions;
using UUID;
using UUID_Test.Fixture;
using Xunit;

namespace UUID_Test
{
    public class FindSequenceTest : IClassFixture<FindSequenceFixture>
    {
        private readonly FindSequenceFixture _fixture;
        public FindSequenceTest(FindSequenceFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void TestCase01()
        {
            //Arrange
            var service = new FindSequence();

            //Act
            var result = service.FindMaxSequence(_fixture.TestCase01Input);

            //Assert
            result.Should().Be(_fixture.TestCase01Output);
        }
        
        [Fact]
        public void TestCase02()
        {
            //Arrange
            var service = new FindSequence();

            var result = service.FindMaxSequence(_fixture.TestCase02Input);

            //Assert
            result.Should().Be(_fixture.TestCase02Output);
        }

        [Fact]
        public void TestCase03()
        {
            //Arrange
            var service = new FindSequence();

            //Act
            var result = service.FindMaxSequence(_fixture.TestCase03Input);

            //Assert
            result.Should().Be(_fixture.TestCase03Output);           
        }

        [Fact]
        public void TestCase04()
        {
            //Arrange
            var service = new FindSequence();

            //Act
            var result = service.FindMaxSequence(_fixture.TestCase04Input);

            //Assert
            result.Should().Be(_fixture.TestCase04Output);
        }

        [Fact]
        public void TestCase05()
        {
            //Arrange
            var service = new FindSequence();

            //Act
            var result  = service.FindMaxSequence(_fixture.TestCase05Input);

            //Assert
            result.Should().Be(_fixture.TestCase05Output);
        }

        [Fact]
        public void TestCase06()
        {
            //Arrange
            var service = new FindSequence();

            //Act
            var result  = service.FindMaxSequence(_fixture.TestCase06Input);

            //Assert
            result.Should().Be(_fixture.TestCase06Output);
        }

        [Fact]
        public void TestCase07()
        {
            //Arrange
            var service = new FindSequence();

            //Act
            var result = service.FindMaxSequence(_fixture.TestCase07Input);

            //Assert
            result.Should().Be(_fixture.TestCase07Output);
                       
        }

        [Fact]
        public void TestCase08()
        {
            //Arrange
            var service = new FindSequence();

            //Act
            var result  = service.FindMaxSequence(_fixture.TestCase08Input);

            //Assert
            result.Should().Be(_fixture.TestCase08Output);
        }

        [Fact]
        public void TestCase09()
        {
            //Arrange
            var service = new FindSequence();

            //Act
             var result  = service.FindMaxSequence(_fixture.TestCase09Input);

            //Assert
            result.Should().Be(_fixture.TestCase09Output);
        }

        [Fact]
        public void TestCase10()
        {
            //Arrange
            var service = new FindSequence();

            //Act
            var result = service.FindMaxSequence(_fixture.TestCase10Input);

            //Assert
            result.Should().Be(_fixture.TestCase10Output);
        }

        [Fact]
        public void TestCase11()
        {
            //Arrange
            var service = new FindSequence();

            //Act
            var result = service.FindMaxSequence(_fixture.TestCase11Input);

            //Assert
            result.Should().Be(_fixture.TestCase11Output);
        }
    }
}
