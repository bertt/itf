namespace itf;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ITF - IGN Tiff Filter");
        
        // nantes
        var xmin = 345;
        var xmax = 350;
        var ymin = 6680;
        var ymax = 6700;


        // lyon
        // var xmin = 830;
        // var xmax = 850;
        // var ymin = 6510;
        // var ymax = 6530;
        
        Console.WriteLine($"Arguments: {xmin},{ymin},{xmax},{ymax}");

        var testpath = @"D:\gisdata\dems\nantes\tifs\RGEALTI_2-0_1M_ASC_LAMB93-IGN69_D044_2022-12-20\RGEALTI\1_DONNEES_LIVRAISON_2023-01-00125\RGEALTI_MNT_1M_ASC_LAMB93_IGN69_D044_20230113";
        // Get all tif files in current directory Directory.GetCurrentDirectory()
        var files = Directory.GetFiles(testpath, "*.asc");
        Console.WriteLine("Found {0} files", files.Length);
        var i = 0;
        foreach (var file in files)
        {
            // get filename only //RGEALTI_FXX_0276_6717_DST_LAMB93_IGN69.tif
            var filename = Path.GetFileName(file);
            var split = filename.Split("_");

            var x = Int32.Parse(split[2]);
            var y = Int32.Parse(split[3]);

            if(x>= xmin && x <= xmax && y >= ymin && y <= ymax)
            {
                i++;
                Console.WriteLine(filename);
            }
            else
            {
                File.Delete(file);
            }
        }

        Console.WriteLine("Found {0} files", i);

    }
}
