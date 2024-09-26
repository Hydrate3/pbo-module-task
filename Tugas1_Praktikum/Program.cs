using System;
public class Hewan
{
    public string Nama { get; set; }
    public int Umur { get; set; }

    public Hewan(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }

    public virtual string Suara()
    {
        return "Hewan ini bersuara";
    }

    public string InfoHewan()
    {
        return $"Nama: {Nama}, Umur: {Umur} tahun";
    }
}
public class Mamalia : Hewan
{
    public int JumlahKaki { get; set; }

    public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
    {
        JumlahKaki = jumlahKaki;
    }

    public override string Suara()
    {
        return "Mamalia ini bersuara";
    }
}
public class Reptil : Hewan
{
    public double PanjangTubuh { get; set; }

    public Reptil(string nama, int umur, double panjangTubuh) : base(nama, umur)
    {
        PanjangTubuh = panjangTubuh;
    }

    public override string Suara()
    {
        return "Reptil ini bersuara";
    }
}
public class Singa : Mamalia
{
    public Singa(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki)
    {
    }

    public override string Suara()
    {
        return "Singa ini mendengkur";
    }

    public string Mengaum()
    {
        return "Singa ini mengaum (blud pikir dirinya adalah raja)";
    }
}
public class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki)
    {
    }

    public override string Suara()
    {
        return "Gajah ini bunyiin klakson";
    }
}
public class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh)
    {
    }

    public override string Suara()
    {
        return "Ular ini berdesis";
    }

    public string Merayap()
    {
        return "Ular ini merayap di tembok njir";
    }
}
public class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh)
    {
    }

    public override string Suara()
    {
        return "Buaya ini berbunyi";
    }
}
public class KebunBinatang
{
    private List<Hewan> hewanList = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        hewanList.Add(hewan);
    }

    public void DaftarHewan()
    {
        foreach (var hewan in hewanList)
        {
            Console.WriteLine(hewan.InfoHewan());
        }
    }
}
class Program
{
    static void Main(string[] args)
    {

        KebunBinatang kebunBinatang = new KebunBinatang();

        Singa singa = new Singa("Singa atas nama aleks", 5, 4);
        Gajah gajah = new Gajah("Gajah atas nama xin fu tang", 10, 4);
        Ular ular = new Ular("Ular sanca njir", 3, 1.5);
        Buaya buaya = new Buaya("Buaya air asin", 7, 2.5);
        Reptil reptil = new Reptil("Buaya",5,5.5);
        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        kebunBinatang.DaftarHewan();

        Console.WriteLine(singa.Suara());
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());
        Console.WriteLine(buaya.Suara());

        Console.WriteLine(singa.Mengaum());
        Console.WriteLine(ular.Merayap());
        Console.WriteLine(reptil.Suara());
    }
}