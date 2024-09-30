using StringSorterApp.Dto;
using StringSorterApp.Enums;
using StringSorterApp.Service.SortService;

namespace StringSorterApp.Test.Services
{
    public class SortServiceTests
    {
        private readonly SortService _sortService;

        public SortServiceTests()
        {
            _sortService = new SortService();
        }

        [Fact]
        public void BubbleSort_ShouldReturnSortedString()
        {
            // Arrange
            var requestDto = new SortRequestDto
            {
                InputString = "dcba",
                SortStrategy = SortStrategyType.BubbleSort
            };

            // Act
            var result = _sortService.SortString(requestDto);

            // Assert
            Assert.Equal("abcd", result.SortedString);
        }

        [Fact]
        public void QuickSort_ShouldReturnSortedString()
        {
            // Arrange
            var requestDto = new SortRequestDto
            {
                InputString = "gfedcba",
                SortStrategy = SortStrategyType.QuickSort
            };

            // Act
            var result = _sortService.SortString(requestDto);

            // Assert
            Assert.Equal("abcdefg", result.SortedString);
        }

        [Fact]
        public void Sort_ShouldReturnEmptyString_WhenInputIsEmpty()
        {
            // Arrange
            var requestDto = new SortRequestDto
            {
                InputString = "",
                SortStrategy = SortStrategyType.BubbleSort
            };

            // Act
            var result = _sortService.SortString(requestDto);

            // Assert
            Assert.Equal("", result.SortedString);
        }

        [Fact]
        public void Sort_ShouldThrowException_WhenStrategyIsInvalid()
        {
            // Arrange
            var requestDto = new SortRequestDto
            {
                InputString = "abc",
                SortStrategy = (SortStrategyType)999 // Invalid enum value
            };

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => _sortService.SortString(requestDto));
        }
    }
}

