namespace GameProject;

public class GameCharacter
{ 
    public string Name { get; set; }
    public int Level { get; set; }
    public int Hp { get; set; }
    public string Weapon { get; set; }

    public GameCharacter()
    {
        this.Name = "fatih";
        this.Weapon = "Katana";
        this.Hp = 100;
        this.Level = 1;
    }

    public void Attack(Enemy enemy)
    {
        Console.WriteLine("fatih, Aslan a saldırıya geçti.");
        Console.WriteLine("saldırmak istediğiniz hasar şiddetini giriniz:  ");
        int Damage = Convert.ToInt32(Console.ReadLine());
        enemy.HealthPoint -= Damage;
        Console.WriteLine($"aslan {Damage} can kaybetti");
        Console.WriteLine("-----------------------------------");

    }

    public void Defend()
    {
        Console.WriteLine("fatih savunmaya geçiyor");
        Console.WriteLine("aslanın atağı fatih tarafından savuruldu");
        Console.WriteLine("-----------------------------------");        
    }

    public void LevelUp()
    {
        Console.WriteLine("seviye arttırıldı");
        Level += 1;
    }

    public void ShowStatus()
    {
        Console.WriteLine($"seviye = {Level}, can = {Hp}, silah = {Weapon}");
        Console.WriteLine($"düşmanın sağlık durumu = {Hp}");
    }
}