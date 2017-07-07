# csharp-dictionaries
 NSS Exercise


## Instructions

A block of publicly traded stock has a variety of attributes, we'll look at a few of them. A stock has a ticker symbol and a company name. Create a simple dictionary with ticker symbols and company names in the Main method.

#### Example

```csharp
Dictionary<string, string> stocks = new Dictionary<string, string>();
stocks.Add("GM", "General Motors");
stocks.Add("CAT", "Caterpillar");
// Add a few more of your favorite stocks
```

To find a value in a Dictionary, you can use square bracket notation much like JavaScript object key lookups.

```csharp
string GM = stocks["GM"];   <--- "General Motors"
```
Create list of ValueTuples that represents stock purchases. Properties will be ticker, shares, price.

```csharp
List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();
```

#### Example

```csharp
purchases.Add((ticker: "GE", shares: 150, price: 23.21));
purchases.Add((ticker: "GE", shares: 32, price: 17.87));
purchases.Add((ticker: "GE", shares: 80, price: 19.02));
// Add more for each stock you added to the stocks dictionary
```

Create a total ownership report that computes the total value of each stock that you have purchased. This is the basic relational database join algorithm between two tables.

```csharp
/* 
    Define a new Dictionary to hold the aggregated purchase information.
    - The key should be a string that is the full company name.
    - The value will be the valuation of each stock (price*amount)

    {
        "General Electric": 35900,
        "AAPL": 8445,
        ...
    }
*/

// Iterate over the purchases and 
foreach ((string ticker, int shares, double price) purchase in purchases)
{
    // Does the company name key already exist in the report dictionary?

    // If it does, update the total valuation

    // If not, add the new key and set its value
}
```