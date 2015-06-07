using System;

public class LaptopShop
{
    private static void Main()
    {
        Console.Write("Please enter laptop model: ");
        string laptopModel = Console.ReadLine();

        Console.Write("Please enter laptop manufacturer (optional): ");
        string laptopManufacturer = Console.ReadLine();

        Console.Write("Please enter processor specs: ");
        string laptopProcessor = Console.ReadLine();

        Console.Write("Please enter laptop RAM: ");
        string RAMinput = Console.ReadLine();
        int laptopRam;

        if (int.TryParse(RAMinput, out laptopRam))
        {
            laptopRam = int.Parse(RAMinput);
        }
        else
        {
            Console.WriteLine("Invalid input in RAM field! RAM must be a positive integer number!");
        }

        Console.Write("Please enter graphic card specs: ");
        string laptopGraphicCard = Console.ReadLine();

        Console.Write("Please enter HDD specs: ");
        string inputHDD = Console.ReadLine();
        int laptopHDD;

        if (int.TryParse(inputHDD, out laptopHDD))
        {
            laptopHDD = int.Parse(inputHDD);
        }
        else
        {
            Console.WriteLine("HDD size needs to be a number!");
        }

        Console.Write("Please enter screen specs: ");
        string laptopScreen = Console.ReadLine();

        Console.Write("Please enter battery type: ");
        string laptopBatteryType = Console.ReadLine();

        Console.Write("Please enter number of battery cells: ");
        string cellCountInput = Console.ReadLine();
        int cellCount;

        if (int.TryParse(cellCountInput, out cellCount))
        {
            laptopRam = int.Parse(cellCountInput);
        }
        else
        {
            Console.WriteLine("Invalid input in cell-count field! Cell-count must be a positive integer number!");
        }

        Console.Write("Please enter battery charge in mAh: ");
        string laptopBatteryCharge = Console.ReadLine();
        int batteryCharge;

        if (int.TryParse(laptopBatteryCharge, out batteryCharge))
        {
            batteryCharge = int.Parse(laptopBatteryCharge);
        }
        else
        {
            Console.WriteLine("Invalid input in battery-charge field! Battery-charge must be a positive integer number!");
        }

        Console.Write("Please enter battery life (in hours): ");
        string inputBatteryLife = Console.ReadLine();
        double laptopBatteryLife;       

        if (double.TryParse(inputBatteryLife, out laptopBatteryLife))
        {
            laptopBatteryLife = double.Parse(inputBatteryLife);
        }
        else
        {
            Console.WriteLine("Invalid input in battery-charge field! Battery-charge must be a positive integer number!");
        }

        Console.Write("Please enter laptop price: ");
        string inputPrice = Console.ReadLine();
        decimal laptopPrice;

        if (decimal.TryParse(inputPrice, out laptopPrice))
        {
            laptopPrice = decimal.Parse(inputPrice);
        }
        else
        {
            Console.WriteLine("Invalid input in laptop price field! Laptop price must be a positive number!");
        }

        //Battery laptopBattery = new Battery(laptopBatteryType,cellCount,batteryCharge);

        Laptop currentLaptop = new Laptop(laptopModel, laptopManufacturer, laptopProcessor,laptopRam, laptopGraphicCard, laptopHDD, laptopScreen, new Battery(laptopBatteryType, cellCount, batteryCharge), laptopPrice);

        Console.WriteLine(currentLaptop);
    }
}

