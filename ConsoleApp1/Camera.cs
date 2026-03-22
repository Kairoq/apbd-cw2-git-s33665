namespace ConsoleApp1;

public class Camera : Equipment
{
    public int Megapixels { get; set; }
    public bool HasFlash { get; set; }
    public bool CanRecordVideo { get; set; }
    public int OpticalZoom { get; set; }

    public Camera(string name, int megapixels, bool hasFlash, bool canRecordVideo, int opticalZoom)
        : base(name)
    {
        Megapixels = megapixels;
        HasFlash = hasFlash;
        CanRecordVideo = canRecordVideo;
        OpticalZoom = opticalZoom;
    }

    public override string ToString()
    {
        return $"{base.ToString()} | {Megapixels}MP " +
               $"| Flash: {HasFlash} " +
               $"| Video: {CanRecordVideo} " +
               $"| Zoom: {OpticalZoom}x";
    }
}