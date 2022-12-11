using System.ComponentModel.DataAnnotations;

namespace FibCalc.Models;

public class FibonacciModel
{
    [Range(0, 20)]
    public ulong Value { get; set; }
    public ulong Result { get; set; }
}