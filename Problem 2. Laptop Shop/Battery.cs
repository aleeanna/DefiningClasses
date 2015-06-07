using System;

public class Battery 
{
    private string batteryType;
    private int numOfCells;
    private int mAh;
    private double batteryLife;

    public string BatteryType
    {
        get
        {
            return this.batteryType;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Battery type cannot be empty!");
            }
            this.batteryType = value;
        }
    }

    public int NumOfCells
    {
        get
        {
            return this.numOfCells;
        }
        set
        {
            if (value<=0)
            {
                throw new ArgumentOutOfRangeException("Battery cell count cannot be a negative number, and cannot be zero!");
            }
            this.numOfCells = value;
        }
    }

    public int MAH
    {
        get
        {
            return this.mAh;
        }
        set
        {
            if (value<=0)
            {
                throw new ArgumentOutOfRangeException("Battery mAh cannot be a negative number, and cannot equal zero!");
            }
            this.mAh = value;
        }
    }

    public double BatteryLife
    {
        get
        {
            return this.batteryLife;
        }
        set
        {
            if (value<=0)
            {
                throw new ArgumentOutOfRangeException("Battery life cannot be a negative number and cannot be zero!");
            }
            this.batteryLife = value;
        }
    }

    public Battery(string batteryType, int numOfCells, int mAh) 
    {
        this.BatteryType = batteryType;
        this.NumOfCells = numOfCells;
        this.MAH = mAh;
    }

    public override string ToString()
    {
        return string.Format("{0}, {1}-cells, {2} mAh", this.BatteryType, this.NumOfCells, this.MAH);
    }
}

