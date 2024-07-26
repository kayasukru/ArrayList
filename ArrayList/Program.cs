using System.Collections;

ArrayList1();

ArrayList2();

ArrayList3();





static void ArrayList1()
{
    Console.WriteLine("ArrayList1");
    Console.WriteLine();

    //Tanımlama
    ArrayList arrayList1 = new ArrayList();

    //Ekleme
    arrayList1.Add(100); // boxing işlemi
    arrayList1.Add("Şükrü Kaya");
    arrayList1.Add(true);
    arrayList1.Add('s');

    foreach (var i in arrayList1)
    {
        Console.WriteLine(i + " -> " + i.GetType());
    }
    Console.WriteLine();
    Console.WriteLine("-----------------------------------");
    Console.WriteLine();
}

static void ArrayList2()
{
    Console.WriteLine("ArrayList2");
    Console.WriteLine();

    var arrayList2 = new ArrayList()
        {
            200, "Seher", false, 'p'
        };

    foreach (var item in arrayList2)
    {
        Console.WriteLine(item + " -> " + item.GetType());
    }
    Console.WriteLine();
    Console.WriteLine("-----------------------------------");
    Console.WriteLine();
}

static void ArrayList3()
{
    Console.WriteLine("ArrayList3");
    Console.WriteLine();

    var arrayList3 = new ArrayList();

    int[] sayilar = new int[] { 30, 40, 50, 60 };

    arrayList3.Add(150);
    arrayList3.Add("Güneş");
    arrayList3.Add(true);
    arrayList3.Add('w');

    arrayList3.AddRange(sayilar);

    //Dolaşma
    foreach (var item in arrayList3)
    {
        Console.WriteLine(item + " -> " + item.GetType());
    }
    Console.WriteLine();
    Console.WriteLine("-------------------");
    Console.WriteLine();

    //Elemana erişme
    Console.WriteLine(arrayList3[3]);
    Console.WriteLine("Dizinin 5. elemanı: " + arrayList3[5] + " -> " + arrayList3[5].GetType());

    //Elemana erişme - atama
    int x = (int)arrayList3[0]; //casting, unboxing

    Console.WriteLine(x+20);

    Console.WriteLine();
    Console.WriteLine("-----------------------------------");
    Console.WriteLine();

    Console.WriteLine("Listeden eleman silme: 150 değerine sahip eleman silinir");
    arrayList3.Remove(150); // 150 değerine sahip eleman silinir

    foreach (var item in arrayList3)
    {
        Console.WriteLine(item + " -> " + item.GetType());
    }

    Console.WriteLine();
    Console.WriteLine("-------------------");
    Console.WriteLine();

    Console.WriteLine("Listeden eleman silme: 3. indisli eleman silinir");
    arrayList3.RemoveAt(3); // 3. indisli eleman silinir

    foreach (var item in arrayList3)
    {
        Console.WriteLine(item + " -> " + item.GetType());
    }

    Console.WriteLine();
    Console.WriteLine("-------------------");
    Console.WriteLine();


    Console.WriteLine("Listeden eleman silme: 3. indisten başlayarak 2 eleman silinir");
    arrayList3.RemoveRange(3,2); // 3. indisten başlayarak 2 eleman silinir

    foreach (var item in arrayList3)
    {
        Console.WriteLine(item + " -> " + item.GetType());
    }

    Console.WriteLine();
    Console.WriteLine("-------------------");
    Console.WriteLine();
}
