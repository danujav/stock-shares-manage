﻿namespace api;

public class CreateStockRequestDto
{
    public string Symbol { get; set; } = string.Empty;
    public string CompanyName { get; set; } = string.Empty;
    public decimal Purchase { get; set; }
    public decimal Lastdiv { get; set; }
    public string Industry { get; set; } = string.Empty;
    public long MarketCap { get; set; }
}