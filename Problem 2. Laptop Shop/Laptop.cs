using System;

public class Laptop
{
    private string model;
    private string manufacturer;
    private string currentProcessor;
    private int ram;
    private string graphicsCard;
    private int currentHdd;
    private string screen;
    private decimal price;

    public Laptop(string model, string manufacturer, string currentProcessor, int ram, string graphicsCard, int currentHdd, string screen, Battery currentBattery, decimal price)
        : this(null, 0m)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.CurrentProcessor = currentProcessor;
        this.Ram = ram;
        this.GraphicsCard = graphicsCard;
        this.CurrentHdd = currentHdd;
        this.Screen = screen;
        this.CurrentBattery = currentBattery;
        this.Price = price;
    }

    public Laptop(string model, decimal price)
    {
        this.Model = model;
        this.Price = price;
    }

    public Laptop(string model, string currentProcessor, int currentHdd, decimal price)
        : this(null, 0m)
    {
        this.Model = model;
        this.CurrentProcessor = currentProcessor;
        this.CurrentHdd = currentHdd;
        this.Price = price;
    }
    
    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Laptop model is a mandatory field and cannot be left blank!");
            }
            this.model = value;
        }
    }

    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Manufacturer cannot be left blank");
            }
            this.manufacturer = value;
        }
    }

    public string CurrentProcessor
    {
        get
        {
            return this.currentProcessor;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Processor field cannot be left blank!");
            }
            this.currentProcessor = value;
        }
    }

    public int Ram
    {
        get
        {
            return this.ram;
        }
        set
        {
            if (value<=0)
            {
                throw new ArgumentOutOfRangeException("RAM cannot be a negative number or zero!");
            }
            this.ram = value;
        }
    }

    public string GraphicsCard
    {
        get
        {
            return this.graphicsCard;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Graphics card field cannot be left blank!");
            }
            this.graphicsCard = value;
        }
    }

    public int CurrentHdd
    {
        get
        {
            return this.currentHdd;
        }
        set
        {
            if (value<=0)
            {
                throw new ArgumentOutOfRangeException("HDD size cannot be a negative number or zero!");
            }
            this.currentHdd = value;
        }
    }

    public string Screen
    {
        get
        {
            return this.screen;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Screen field cannot be left blank!");
            }
            this.screen = value;
        }
    }

    public Battery CurrentBattery { get; set; }

    public decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value<=0)
            {
                throw new ArgumentOutOfRangeException("Price cannot be zero or a negative number!");
            }
            this.price = value;
        }
    }

    

    public override string ToString()
    {
        return string.Format("Model| {0}\nManufacturer| {1}\nProcessor| {2}\nRAM| {3} GB\nGraphics card| {4}\nHDD| {5} GB SSD\nScreen| {6}\nBattery| {7}\nBattery Life| {8} hours\nPrice| {9}", this.Model, this.Manufacturer, this.CurrentProcessor,this.Ram, this.GraphicsCard, this.CurrentHdd, this.Screen,this.CurrentBattery,this.CurrentBattery.BatteryLife, this.Price);
    }
}

