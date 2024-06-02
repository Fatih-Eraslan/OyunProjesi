namespace GameProject;

public class Project
{
    public static void Main()
    {
        GameCharacter gameCharacter = new GameCharacter();
        Enemy enemy = new Enemy();
        
            while (true)
            {
                Console.WriteLine(@"
=========================================
            OYUN KARAKTERİ 
=========================================

1. Saldırı yap
2. Savunma yap
3. Seviye atla
4. Durum göster
5. Çıkış

seçiminizi yapın: ");

                int choise = Convert.ToInt32(Console.ReadLine());

                if (choise == 1)
                {
                    gameCharacter.Attack(enemy);
                }
                else if (choise == 2)
                {
                    gameCharacter.Defend();
                }
                else if (choise == 3)
                {
                    gameCharacter.LevelUp();
                }
                else if (choise == 4)
                {
                    gameCharacter.ShowStatus();
                }
                else if (choise == 5)
                {
                    Console.WriteLine("Hoşçakalın");
                    break;
                }
            }
    }
}