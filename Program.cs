//Console.WriteLine("Hello, World!");

FightSystem.start();
Console.WriteLine(FightSystem.status);

Hero miya = new Hero("Miya",10,90,400);

Hero alucard = new Hero("Alucard",9,60,700);
alucard.nama = "Alucard";
alucard.attack_power = 60;
alucard.health_point = 700;

//contoh penggunaan namespace
Update.Hero Lesley = new Update.Hero();
Lesley.nama = "Lesley";
Lesley.attack_power = 100;
Lesley.health_point = 390;

Lesley.ShowInfo();

Console.WriteLine($"Hero {miya.nama} memiliki attack power {miya.attack_power} dan health point {miya.health_point}");
Console.WriteLine($"Hero {alucard.nama} memiliki attack power {alucard.attack_power} dan health point {alucard.health_point}");

alucard.attack(miya);

Console.WriteLine($"UPDATE: Hero {miya.nama} memiliki attack power {miya.attack_power} dan health point {miya.health_point}");
Console.WriteLine($"UPDATE: Hero {alucard.nama} memiliki attack power {alucard.attack_power} dan health point {alucard.health_point}");

FightSystem.stop();


class Hero
{
    public string nama;
    public int attack_speed;
    public int attack_power;
    public int health_point;

    public Hero(string nama, int attack_speed, int attack_power, int health_point)
    {
        this.nama = nama;
        this.attack_speed = attack_speed;
        this.attack_power = attack_power;
        this.health_point = health_point;
        Console.WriteLine($"Sebuah Hero telah Muncul {this.nama}");
    }

    public void attack(Hero AttackedHero)
    {
        AttackedHero.health_point = AttackedHero.health_point - this.attack_power;
        Console.WriteLine($"ATTACK: Hero {this.nama} menyerang Hero {AttackedHero.nama} sebesar {this.attack_power} poin");
    }
}


//Contoh namespace
namespace Update
{
    class Hero
    {
        public string nama;
        public int attack_power;
        public int health_point;

        public void attack(Hero AttackedHero)
        {
            AttackedHero.health_point = AttackedHero.health_point - this.attack_power;
            Console.WriteLine($"ATTACK: Hero {this.nama} menyerang Hero {AttackedHero.nama} sebesar {this.attack_power} poin");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Nama Hero {this.nama}");
            Console.WriteLine($"Attack Hero {this.attack_power}");
            Console.WriteLine($"HP Hero {this.health_point}");
        }
    }
}

//contoh static
class FightSystem
{
    public static string status = "Belum dimulai";
    public static void start()
    {
        Console.WriteLine("Pertandingan dimulai");
        status = "Dimulai";
    }
    public static void stop() 
    {
        Console.WriteLine("Pertandingan Selesai");
        status = "Selesai";
     }
}
