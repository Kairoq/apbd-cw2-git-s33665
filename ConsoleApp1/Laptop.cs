namespace ConsoleApp1;

public class Laptop : Equipment 
{
    public int StorageSize { get; set; }
    public int RamSize { get; set; }
    public String GraphicCard { get; set; }
    public int VRamSize { get; set; }
    public String Processor { get; set; }

    public Laptop(string name, int storageSize, int ramSize, string graphicCard, int vRamSize, string processor) : base(name)
    {
        StorageSize = storageSize;
        RamSize = ramSize;
        GraphicCard = graphicCard;
        VRamSize = vRamSize;
        Processor = processor;
    }

    public override string ToString()
    {
        return $"{base.ToString()} | Storage: {StorageSize}GB " +
               $"| RAM: {RamSize}GB " +
               $"| GPU: {GraphicCard} ({VRamSize}GB VRAM) " +
               $"| CPU: {Processor}";
    }

}