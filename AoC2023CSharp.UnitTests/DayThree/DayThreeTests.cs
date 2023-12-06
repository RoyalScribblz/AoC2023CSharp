using FluentAssertions;

namespace AoC2023CSharp.UnitTests.DayThree;

public class DayThreeTests
{
    [Fact]
    public void Part_One()
    {
        // Arrange
        List<string> input = new ()
        {
            "467..114..",
            "...*......",
            "..35...633",
            "......#...",
            "617*......",
            ".....+.58.",
            "..592.....",
            "......755.",
            "...$.*....",
            ".664.598.."
        };

        // Act
        int result = AoC2023CSharp.DayThree.DayThree.PartOne(input);

        
        // Assert
        result.Should().Be(4361);
    }
    
    // [Fact]
    // public void Part_Two()
    // {
    //     // Arrange
    //     string[] input =
    //     {
    //         "467..114..",
    //         "...*......",
    //         "..35...633",
    //         "......#...",
    //         "617*......",
    //         ".....+.58.",
    //         "..592.....",
    //         "......755.",
    //         "...$.*....",
    //         ".664.598.."
    //     };
    //
    //     // Act
    //     int result = AoC2023CSharp.DayThree.DayThree.PartTwo(input);
    //
    //     
    //     // Assert
    //     result.Should().Be(4361);
    // }
}